using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        private bool AutoResize;
        private FileInfo FileRename;
        private string LBuffer;
        private string RBuffer;
        private bool left;
        private bool rename;

        public Form1()
        {
            InitializeComponent();

            DriveInfo[] drives = DriveInfo.GetDrives();



            LeftDrive.Items.AddRange(drives);
            RightDrive.Items.AddRange(drives);

            Load();
            
            WindowResized(this,null);
        }

        private void Open(DataGridView Explorer, string path)
        {
            if (AutoResize) ColumnsDefault(null, null);

            TextBox Path;
            if (Explorer == LeftExplorer)
                Path = LeftPath;
            else
                Path = RightPath;

            if (File.Exists(path))
            {
                Process.Start(path);
                return;
            }

            Explorer.Rows.Clear();
            if (Directory.Exists(path))
            {
                DirectoryInfo a = new DirectoryInfo(path);
                foreach (var dir in a.GetDirectories())
                {
                    Explorer.Rows.Add(dir.Name, dir.LastWriteTime, "", "");
                }

                foreach (var file in a.GetFiles())
                {
                    Explorer.Rows.Add(
                        file.Name.Substring(0,file.Name.LastIndexOf(file.Extension)),
                        file.LastWriteTime,
                        file.Extension, 
                        file.Length.ToString("N0") + " B");
                }
            }

            Path.Text = path;

            Focus_Leave(Path, null);

            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);


        }

        private void Exit(DataGridView obj)
        {
            var file = obj == LeftExplorer ? LeftPath.Text : RightPath.Text;
            if (file.Length == 0) return;
            file = file.Substring(0, file.LastIndexOf('\\'));
            if (!file.Contains('\\')) file += '\\';
            Open(obj,file);
        }
        private void DriveSelected(object sender, EventArgs e)
        {
            if (((sender as ComboBox).SelectedItem as DriveInfo).IsReady)
            {
                string file = (sender as ComboBox).SelectedItem.ToString();
                if ((sender as ComboBox) == LeftDrive)
                {
                    Open(LeftExplorer, file);
                    Open(LeftExplorer, file);
                }
                else
                {
                    Open(RightExplorer, file);
                }

                
            }
            else
            {
                MessageBox.Show("INSERT DRIVE", "", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void CheckBySquare(object sender, MouseEventArgs e)
        {
            if (!(sender is CheckedListBox checkedListBox)) return;
            if (checkedListBox.Items.Count == 0 || checkedListBox.SelectedIndex == -1) return;
            if (e.X > 13)
                checkedListBox.SetItemChecked(checkedListBox.SelectedIndex, !checkedListBox.GetItemChecked(checkedListBox.SelectedIndex));
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        private void Refresh()
        {
            if (Directory.Exists(LeftPath.Text))
                Open(LeftExplorer, LeftPath.Text);
            if (Directory.Exists(RightPath.Text))
                Open(RightExplorer, RightPath.Text);
        }

        private void Up(object sender, EventArgs e)
        {
            Exit((sender as Button) == LeftExit ? LeftExplorer : RightExplorer);
        }

        private void FilePathKeyDown(object sender, KeyEventArgs e)
        {
            Open(LeftExplorer, (sender as TextBox).Text);
        }

        private void PathChanged(object sender, EventArgs e)
        {
            TextBox path = sender as TextBox;
            if (File.Exists(path.Text) || Directory.Exists(path.Text))
            {
                if (path == LeftPath)
                    Open(LeftExplorer, (sender as TextBox).Text);
                else
                    Open(RightExplorer, (sender as TextBox).Text);
            }
        }

        private void WindowResized(object sender, EventArgs e)
        {
            LeftExplorer.Width = (int)(this.Size.Width / 2 - 50);
            RightExplorer.Width = (int)(this.Size.Width / 2 - 50);
            LeftExplorer.Height = this.Size.Height - 200;
            RightExplorer.Height = this.Size.Height - 200;
            int x = 40;
            LeftExplorer.Left = x;
            RightExplorer.Left = this.Size.Width - x - 16 - RightExplorer.Width;
            LeftExit.Left = LeftExplorer.Left;
            RightExit.Left = RightExplorer.Left;
            LeftPath.Left = LeftExplorer.Left + 20;
            RightPath.Left = RightExplorer.Left + 20;
            LeftPath.Width = LeftExplorer.Width - 20;
            RightPath.Width = LeftExplorer.Width - 20;
            LeftDrive.Left = LeftExplorer.Left + LeftExplorer.Width - LeftDrive.Width;
            RightDrive.Left = RightExplorer.Left + RightExplorer.Width - RightDrive.Width;

        }

        private void ExplorerOpen(object Explorer, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TextBox Path;
                if (Explorer == LeftExplorer)
                    Path = LeftPath;
                else
                    Path = RightPath;

                string name = (Explorer as DataGridView)?.Rows[e.RowIndex].Cells[0].Value.ToString();
                string extension = (Explorer as DataGridView)?.Rows[e.RowIndex].Cells[2].Value.ToString();
                string path;
                if (Path.Text.EndsWith("\\"))
                    path = Path.Text + name;
                else
                    path = Path.Text + '\\' + name;
                Open(Explorer as DataGridView, path + extension);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenameEnd(object Explorer, DataGridViewCellEventArgs e)
        {
            try
            {
                TextBox Path;
                if (Explorer == LeftExplorer)
                    Path = LeftPath;
                else
                    Path = RightPath;

                string name = (Explorer as DataGridView)?.Rows[e.RowIndex].Cells[0].Value.ToString();
                string path;
                if (Path.Text.EndsWith("\\"))
                    path = Path.Text + name;
                else
                    path = Path.Text + '\\' + name;
                if ((FileRename.Attributes & FileAttributes.Directory) == 0)
                    path += FileRename.Extension;
                FileRename.MoveTo(path);
                BeginInvoke(new MethodInvoker(Refresh));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BeginInvoke(new MethodInvoker(Refresh));    
            }
        }

        private void RenameBegin(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                TextBox Path;

                DataGridView Explorer = sender as DataGridView;

                if (Explorer == LeftExplorer)
                    Path = LeftPath;
                else
                    Path = RightPath;

                string name = Explorer.Rows[e.RowIndex].Cells[0].Value.ToString();
                string extension = Explorer.Rows[e.RowIndex].Cells[2].Value.ToString();
                string path;
                if (Path.Text.EndsWith("\\"))
                    path = Path.Text + name;
                else
                    path = Path.Text + '\\' + name;

                FileRename = new FileInfo(path + extension);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Focus_Enter(object sender, EventArgs e)
        {
            TextBox path = sender as TextBox;
            if (path == LeftPath)
                LBuffer = path.Text;
            else
                RBuffer = path.Text;
        }

        private void Focus_Leave(object sender, EventArgs e)
        {
            TextBox path = sender as TextBox;
            if (path == LeftPath)
                if (Directory.Exists(path.Text)) LBuffer = path.Text;
                else path.Text = LBuffer;
            else
                if (Directory.Exists(path.Text)) RBuffer = path.Text;
                else path.Text = RBuffer;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Remove(object sender, EventArgs e)
        {
            DataGridView Explorer;
            TextBox Path;

            if (left)
            {
                Explorer = LeftExplorer;
                Path = LeftPath;
            }
            else
            {
                Explorer = RightExplorer;
                Path = RightPath;
            }

            List<string> toDel = new List<string>();
            foreach (DataGridViewRow row in Explorer.SelectedRows)
            {
                string name = row.Cells[0].Value.ToString() + row.Cells[2].Value.ToString();
                if (Path.Text.EndsWith("\\"))
                    toDel.Add(Path.Text + name);
                else
                    toDel.Add(Path.Text + '\\' + name);
            }

            foreach (var name in toDel)
            {
                if (File.Exists(name))
                {
                    var res = MessageBox.Show($"You sure you want remove file {name}", "FILE REMOVING",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {

                        File.Delete(name);
                        MessageBox.Show($"File {name} removed", "FILE DELETED",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    try
                    {
                        Directory.Delete(name);
                        MessageBox.Show($"Folder {name} removed", "FOLDER REMOVED",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        var res = MessageBox.Show($"You sure you want remove not empty directory {name}", "FOLDER REMOVING",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (res == DialogResult.OK)
                        {
                            Directory.Delete(name, true);
                            MessageBox.Show($"Folder {name} removed", "FOLDER REMOVED",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            Refresh();
        }

        private void CreateTXT(object sender, EventArgs e)
        {
            TextBox Path;

            if (left)
            {
                Path = LeftPath;
            }
            else
            {
                Path = RightPath;
            }

            string path;
            string name = "New Text Document";
            if (Path.Text.EndsWith("\\"))
                path = Path.Text + name;
            else
                path = Path.Text + '\\' + name;

            if (File.Exists(path) || Directory.Exists(path))
            {
                int i = 1;
                string temp = name;
                while (true)
                {

                    name = temp + i + ".txt";

                    if (Path.Text.EndsWith("\\")) path = Path.Text + name;
                    else path = Path.Text + '\\' + name;
                    if (!Directory.Exists(path) && !File.Exists(path)) break;

                    i++;
                }
            }

            File.Create(path).Close();
            Refresh();
        }

        private void CreateDir(object sender, EventArgs e)
        {
            TextBox Path;

            if (left)
            {
                Path = LeftPath;
            }
            else
            {
                Path = RightPath;
            }

            string path;
            string name = "New Folder";
            if (Path.Text.EndsWith("\\"))
                path = Path.Text + name;
            else
                path = Path.Text + '\\' + name;

            if (File.Exists(path) || Directory.Exists(path))
            {
                int i = 1;
                string temp = name;
                while (true)
                {

                    name = temp + i;

                    if (Path.Text.EndsWith("\\")) path = Path.Text + name;
                    else path = Path.Text + '\\' + name;
                    if (!Directory.Exists(path) && !File.Exists(path)) break;

                    i++;
                }
            }

            Directory.CreateDirectory(path);
            Refresh();
        }

        private void Copy(object sender, EventArgs e)
        {
            try
            {
                DataGridView FromExplorer;
                TextBox FromPath;
                TextBox ToPath;

                if (left)
                {
                    FromExplorer = LeftExplorer;
                    FromPath = LeftPath;
                    ToPath = RightPath;
                }
                else
                {
                    FromExplorer = RightExplorer;
                    FromPath = RightPath;
                    ToPath = LeftPath;
                }

                foreach (DataGridViewRow row in FromExplorer.SelectedRows)
                {
                    string name = row.Cells[0].Value.ToString() + row.Cells[2].Value.ToString();
                    string from;
                    if (FromPath.Text.EndsWith("\\"))
                        from = FromPath.Text + name;
                    else
                        from = FromPath.Text + '\\' + name;

                    string to;
                    if (ToPath.Text.EndsWith("\\"))
                        to = ToPath.Text + name;
                    else
                        to = ToPath.Text + '\\' + name;

                    if (from == to)
                    {
                        MessageBox.Show("Source and destination is same", "Senseless operation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (File.Exists(from))
                    {
                        if (sender == CopyButton)
                            File.Copy(from, to);
                        else
                            File.Move(from, to);
                    }
                    else
                    {
                        if (sender == CopyButton)
                            DirectoryCopy(from, to, true);
                        else
                            Directory.Move(from, to);
                    }
                }

                Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Focus(object sender, EventArgs e)
        {
            left = sender == LeftExplorer;
        }

        private void Swap(object sender, EventArgs e)
        {
            try
            {
                List<FileInfo> LFiles = new List<FileInfo>();
                foreach (DataGridViewRow row in LeftExplorer.SelectedRows)
                {
                    string name = row.Cells[0].Value.ToString() + row.Cells[2].Value.ToString();
                    if (LeftPath.Text.EndsWith("\\")) name = LeftPath.Text + name;
                    else name = LeftPath.Text + "\\" + name;
                    LFiles.Add(new FileInfo(name));
                }

                List<FileInfo> RFiles = new List<FileInfo>();

                foreach (DataGridViewRow row in RightExplorer.SelectedRows)
                {
                    string name = row.Cells[0].Value.ToString() + row.Cells[2].Value.ToString();
                    if (RightPath.Text.EndsWith("\\")) name = RightPath.Text + name;
                    else name = RightPath.Text + "\\" + name;
                    RFiles.Add(new FileInfo(name));
                }

                if (LFiles.Count > 0 || RFiles.Count > 0)
                {
                    string dir1 = RFiles[0].DirectoryName;
                    string dir2 = LFiles[0].DirectoryName;
                    foreach (FileInfo file in LFiles)
                    {
                        string to;
                        if (dir1.EndsWith("\\")) to = dir1 + file.Name;
                        else to = dir1 + "\\" + file.Name;
                        file.MoveTo(to);
                    }

                    foreach (FileInfo file in RFiles)
                    {
                        string to;
                        if (dir2.EndsWith("\\")) to = dir2 + file.Name;
                        else to = dir2 + "\\" + file.Name;
                        file.MoveTo(to);
                    }
                }

                Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OnClose(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void ColumnsDefault(object sender, EventArgs e)
        {
            LeftExplorer.AutoResizeColumns();
            RightExplorer.AutoResizeColumns();
        }

        private void SetAutoResize(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (AutoResize)
            {
                button.Image = Image.FromFile("Disabled.png");
            }
            else
            {
                button.Image = Image.FromFile("Enabled.png");
            }
            AutoResize = !AutoResize;
        }

        private void Load()
        {
            AutoResize = false;

            if (File.Exists("save.txt"))
            {
                StreamReader reader = new StreamReader("save.txt");
                if (!reader.EndOfStream)
                {

                    string line = reader.ReadLine();
                    string[] strings = line.Remove(line.Length - 1).Split(' ');
                    for (int i = 0; i < strings.Length / 2; i++)
                    {
                        LeftExplorer.Columns[i].Width = int.Parse(strings[i]);
                    }

                    for (int i = strings.Length / 2; i < strings.Length; i++)
                    {
                        RightExplorer.Columns[i - strings.Length / 2].Width = int.Parse(strings[i]);
                    }
                
                    AutoResize = bool.Parse(reader.ReadLine());
                    strings = reader.ReadLine().Split(' ');
                    LeftExplorer.RowHeadersWidth = int.Parse(strings[0]);
                    RightExplorer.RowHeadersWidth = int.Parse(strings[1]);

                }

                reader.Close();
            }

            AutoResize = !AutoResize;
            SetAutoResize(toolStripButton2, null);
        }

        private void Save()
        {
            StreamWriter writer = new StreamWriter("save.txt");
            foreach (DataGridViewColumn column in LeftExplorer.Columns)
            {
                writer.Write($"{column.Width} ");
            }

            
            foreach (DataGridViewColumn column in RightExplorer.Columns)
            {
                writer.Write($"{column.Width} ");
            }
            writer.WriteLine();
            writer.WriteLine(AutoResize);
            writer.WriteLine($"{LeftExplorer.RowHeadersWidth} {RightExplorer.RowHeadersWidth}");
            writer.Close();
        }
    }
}
