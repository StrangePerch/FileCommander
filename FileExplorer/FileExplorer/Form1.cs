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
        private FileInfo FileRename;

        public Form1()
        {
            InitializeComponent();

            DriveInfo[] drives = DriveInfo.GetDrives();



            LeftDrive.Items.AddRange(drives);
            RightDrive.Items.AddRange(drives);

            WindowResized(this,null);
        }

        private void Open(DataGridView Explorer, string path)
        {
            ComboBox Path;
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

            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);


        }

        //OLD
        //private void Open(CheckedListBox obj, string path)
        //{
        //    bool isFile;
        //    isFile = File.Exists(path);

        //    if (isFile)
        //    {
        //        Process.Start(path);
        //        return;
        //    }


        //    if (obj == LeftExplorer)
        //    {
        //        LeftPath.Items.Clear();
        //        LeftPath.Items.AddRange(Directory.GetDirectories(path));
        //        LeftPath.Text = path;
        //    }
        //    else
        //    {
        //        RightPath.Items.Clear();
        //        RightPath.Items.AddRange(Directory.GetDirectories(path));
        //        RightPath.Text = path;
        //    }

        //    obj.Items.Clear();

        //    string[] dirs = Directory.GetDirectories(path);
        //    string[] files = Directory.GetFiles(path);

        //    foreach (var dir in dirs)
        //    {
        //        obj.Items.Add(dir.Substring(dir.LastIndexOf('\\') + 1));
        //    }

        //    foreach (var file in files)
        //    {
        //        obj.Items.Add(file.Substring(file.LastIndexOf('\\') + 1));
        //    }

        //    if (dirs.Length > 0)
        //     obj.SelectedIndex = 0;
        //}

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

        private void Action(object sender, EventArgs e)
        {
            try
            {
                DataGridView FromExplorer;
                DataGridView ToExplorer;
                ComboBox FromPath;
                ComboBox ToPath;
                if ((sender as Button) == button_left)
                {
                    FromExplorer = RightExplorer;
                    ToExplorer = LeftExplorer;
                    FromPath = RightPath;
                    ToPath = LeftPath;
                }
                else
                {
                    FromExplorer = LeftExplorer;
                    ToExplorer = RightExplorer;
                    FromPath = LeftPath;
                    ToPath = RightPath;
                }
                if (action.SelectedIndex != -1)
                {
                    switch (action.SelectedItem)
                    {
                        case "MOVE":
                            foreach (DataGridViewRow row in FromExplorer.SelectedRows)
                            {
                                string name = row.Cells[0].Value.ToString() + row.Cells[2].Value.ToString();
                                string from;
                                if (ToPath.Text.EndsWith("\\"))
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

                                if (File.Exists(name))
                                {
                                    File.Move(from, to);
                                }
                                else
                                {
                                    Directory.Move(from, to);
                                }
                            }
                            Refresh();
                            break;
                        case "COPY":
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
                                    File.Copy(from, to);
                                }
                                else
                                {
                                    DirectoryCopy(from, to, true);
                                }
                            }
                            Refresh();
                            break;
                        case "DELETE":
                            List<string> toDel = new List<string>();
                            foreach (DataGridViewRow row in ToExplorer.SelectedRows)
                            {
                                string name = row.Cells[0].Value.ToString() + row.Cells[2].Value.ToString();
                                if (ToPath.Text.EndsWith("\\"))
                                    toDel.Add(ToPath.Text + name);
                                else
                                    toDel.Add(ToPath.Text + '\\' + name);
                            }

                            foreach (var name in toDel)
                            {
                                if (File.Exists(name))
                                {
                                    var res = MessageBox.Show($"You sure you want remove file {name}", "FILE REMOVING",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                    if (res == DialogResult.OK)
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
                                    }
                                    catch
                                    {
                                        var res = MessageBox.Show($"You sure you want remove not empty directory {name}", "FOLDER REMOVING",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                        if (res == DialogResult.OK) Directory.Delete(name, true);
                                    }
                                    MessageBox.Show($"Folder {name} removed", "FOLDER REMOVED",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            Refresh();
                            break;
                        case "CREATE":

                            string path;

                            if (ToPath.Text.EndsWith("\\"))
                                path = ToPath.Text + CreateName.Text;
                            else
                                path = ToPath.Text + '\\' + CreateName.Text;
                            if (FileOrFolder.Text == "Folder" && !Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                            else if (FileOrFolder.Text == "File" && !File.Exists(path))
                            {
                                var my_file = File.Create(path);
                                my_file.Close();
                            }
                            else
                            {
                                MessageBox.Show("NAME IS TAKEN", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                int i = 1;
                                string temp = CreateName.Text;
                                while (true)
                                {
                                    if (FileOrFolder.Text == "Folder")
                                    {
                                        CreateName.Text = temp + i;
                                    }
                                    else
                                    {
                                        CreateName.Text = temp.Insert(temp.LastIndexOf("."), i.ToString());
                                    }

                                    if (ToPath.Text.EndsWith("\\")) path = ToPath.Text + CreateName.Text;
                                    else path = ToPath.Text + '\\' + CreateName.Text;
                                    if (FileOrFolder.Text == "Folder" && !Directory.Exists(path)) return;
                                    else if (FileOrFolder.Text == "File" && !File.Exists(path)) return;

                                    i++;
                                }
                            }
                            Refresh();
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Up(object sender, EventArgs e)
        {
            Exit((sender as Button) == LeftExit ? LeftExplorer : RightExplorer);
        }

        private void FilePathKeyDown(object sender, KeyEventArgs e)
        {
            Open(LeftExplorer, (sender as ComboBox).Text);
        }

        private void PathChanged(object sender, EventArgs e)
        {
            if((sender as ComboBox) == LeftPath)
                Open(LeftExplorer, (sender as ComboBox).Text);
            else
                Open(RightExplorer, (sender as ComboBox).Text);
        }

        private void action_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 2)
            {
                FileOrFolder.Visible = true;
                FileOrFolder.Enabled = true;
            }
            else
            {
                CreateName.Visible = false;
                CreateName.Enabled = false;
                FileOrFolder.Visible = false;
                FileOrFolder.Enabled = false;
            }
        }

        private void FileOrFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex != -1)
            {
                CreateName.Visible = true;
                CreateName.Enabled = true;
                if ((sender as ComboBox).SelectedIndex == 0) CreateName.Text = "NewFolder";
                else CreateName.Text = "NewFile.txt";
            }
            else
            {
                CreateName.Visible = false;
                CreateName.Enabled = false;
            }
        }
        private void FileOrFolder_EnabledChanged(object sender, EventArgs e)
        {
            if((sender as ComboBox).Enabled)
                FileOrFolder_SelectedIndexChanged(sender,e);
        }

        private void WindowResized(object sender, EventArgs e)
        {
            LeftExplorer.Width = (int)(this.Size.Width / 2 - 100);
            RightExplorer.Width = (int)(this.Size.Width / 2 - 100);
            LeftExplorer.Height = this.Size.Height - 150;
            RightExplorer.Height = this.Size.Height - 150;
            int x = 40;
            LeftExplorer.Left = x;
            RightExplorer.Left = this.Size.Width - x - 16 - RightExplorer.Width;
            button_left.Left = (int)(this.Size.Width / 2 - button_left.Width / 2 - 8);
            button_right.Left = (int)(this.Size.Width / 2 - button_right.Width / 2 - 8);
            action.Left = (int)(this.Size.Width / 2 - action.Width / 2 - 8);
            CreateName.Left = (int)(this.Size.Width / 2 - CreateName.Width / 2 - 8);
            FileOrFolder.Left = (int)(this.Size.Width / 2 - FileOrFolder.Width / 2 - 8);
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
                ComboBox Path;
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
                ComboBox Path;
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
                string name = LeftExplorer.Rows[e.RowIndex].Cells[0].Value.ToString();
                string extension = LeftExplorer.Rows[e.RowIndex].Cells[2].Value.ToString();
                string path;
                if (LeftPath.Text.EndsWith("\\"))
                    path = LeftPath.Text + name;
                else
                    path = LeftPath.Text + '\\' + name;

                FileRename = new FileInfo(path + extension);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
