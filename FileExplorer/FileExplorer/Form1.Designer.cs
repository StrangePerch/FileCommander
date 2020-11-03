namespace FileExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftDrive = new System.Windows.Forms.ComboBox();
            this.RightDrive = new System.Windows.Forms.ComboBox();
            this.LeftExit = new System.Windows.Forms.Button();
            this.RightExit = new System.Windows.Forms.Button();
            this.LeftExplorer = new System.Windows.Forms.DataGridView();
            this.LeftExplorerNameCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftExplorerDateModifiedCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftExplorerTypeCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftExplorerSizeCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightExplorer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateTXTButton = new System.Windows.Forms.Button();
            this.CreateDirButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SwapButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.LeftPath = new System.Windows.Forms.TextBox();
            this.RightPath = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LeftExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightExplorer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftDrive
            // 
            this.LeftDrive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftDrive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LeftDrive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LeftDrive.FormattingEnabled = true;
            this.LeftDrive.Location = new System.Drawing.Point(247, 40);
            this.LeftDrive.Name = "LeftDrive";
            this.LeftDrive.Size = new System.Drawing.Size(88, 21);
            this.LeftDrive.TabIndex = 0;
            this.LeftDrive.Text = "Choose drive";
            this.LeftDrive.SelectedIndexChanged += new System.EventHandler(this.DriveSelected);
            // 
            // RightDrive
            // 
            this.RightDrive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RightDrive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RightDrive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RightDrive.FormattingEnabled = true;
            this.RightDrive.Location = new System.Drawing.Point(633, 40);
            this.RightDrive.Name = "RightDrive";
            this.RightDrive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightDrive.Size = new System.Drawing.Size(86, 21);
            this.RightDrive.TabIndex = 1;
            this.RightDrive.Text = "ChooseDrive";
            this.RightDrive.SelectedIndexChanged += new System.EventHandler(this.DriveSelected);
            // 
            // LeftExit
            // 
            this.LeftExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftExit.ImageKey = "(none)";
            this.LeftExit.Location = new System.Drawing.Point(12, 65);
            this.LeftExit.Name = "LeftExit";
            this.LeftExit.Size = new System.Drawing.Size(16, 21);
            this.LeftExit.TabIndex = 8;
            this.LeftExit.Text = "🠕";
            this.LeftExit.UseVisualStyleBackColor = true;
            this.LeftExit.Click += new System.EventHandler(this.Up);
            // 
            // RightExit
            // 
            this.RightExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RightExit.ImageKey = "(none)";
            this.RightExit.Location = new System.Drawing.Point(613, 65);
            this.RightExit.Name = "RightExit";
            this.RightExit.Size = new System.Drawing.Size(16, 21);
            this.RightExit.TabIndex = 10;
            this.RightExit.Text = "🠕";
            this.RightExit.UseVisualStyleBackColor = true;
            this.RightExit.Click += new System.EventHandler(this.Up);
            // 
            // LeftExplorer
            // 
            this.LeftExplorer.AllowUserToAddRows = false;
            this.LeftExplorer.AllowUserToResizeRows = false;
            this.LeftExplorer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeftExplorer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeftExplorerNameCollum,
            this.LeftExplorerDateModifiedCollum,
            this.LeftExplorerTypeCollum,
            this.LeftExplorerSizeCollum});
            this.LeftExplorer.Location = new System.Drawing.Point(12, 90);
            this.LeftExplorer.Name = "LeftExplorer";
            this.LeftExplorer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LeftExplorer.Size = new System.Drawing.Size(373, 289);
            this.LeftExplorer.TabIndex = 13;
            this.LeftExplorer.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.RenameBegin);
            this.LeftExplorer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.RenameEnd);
            this.LeftExplorer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ExplorerOpen);
            this.LeftExplorer.Click += new System.EventHandler(this.Focus);
            this.LeftExplorer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // LeftExplorerNameCollum
            // 
            this.LeftExplorerNameCollum.HeaderText = "Name";
            this.LeftExplorerNameCollum.Name = "LeftExplorerNameCollum";
            // 
            // LeftExplorerDateModifiedCollum
            // 
            this.LeftExplorerDateModifiedCollum.HeaderText = "Date modified";
            this.LeftExplorerDateModifiedCollum.Name = "LeftExplorerDateModifiedCollum";
            this.LeftExplorerDateModifiedCollum.ReadOnly = true;
            // 
            // LeftExplorerTypeCollum
            // 
            this.LeftExplorerTypeCollum.HeaderText = "Type";
            this.LeftExplorerTypeCollum.Name = "LeftExplorerTypeCollum";
            this.LeftExplorerTypeCollum.ReadOnly = true;
            this.LeftExplorerTypeCollum.Width = 50;
            // 
            // LeftExplorerSizeCollum
            // 
            this.LeftExplorerSizeCollum.HeaderText = "Size";
            this.LeftExplorerSizeCollum.Name = "LeftExplorerSizeCollum";
            this.LeftExplorerSizeCollum.ReadOnly = true;
            // 
            // RightExplorer
            // 
            this.RightExplorer.AllowUserToAddRows = false;
            this.RightExplorer.AllowUserToResizeRows = false;
            this.RightExplorer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RightExplorer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.RightExplorer.Location = new System.Drawing.Point(531, 90);
            this.RightExplorer.Name = "RightExplorer";
            this.RightExplorer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RightExplorer.Size = new System.Drawing.Size(373, 289);
            this.RightExplorer.TabIndex = 14;
            this.RightExplorer.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.RenameBegin);
            this.RightExplorer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.RenameEnd);
            this.RightExplorer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ExplorerOpen);
            this.RightExplorer.Click += new System.EventHandler(this.Focus);
            this.RightExplorer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date modified";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.ExitButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreateTXTButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreateDirButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SwapButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MoveButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CopyButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 414);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 51);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(795, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 45);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit (ALT + F4)";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Close);
            // 
            // CreateTXTButton
            // 
            this.CreateTXTButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTXTButton.Location = new System.Drawing.Point(663, 3);
            this.CreateTXTButton.Name = "CreateTXTButton";
            this.CreateTXTButton.Size = new System.Drawing.Size(126, 45);
            this.CreateTXTButton.TabIndex = 5;
            this.CreateTXTButton.Text = "CreateTXT (F6)";
            this.CreateTXTButton.UseVisualStyleBackColor = true;
            this.CreateTXTButton.Click += new System.EventHandler(this.CreateTXT);
            // 
            // CreateDirButton
            // 
            this.CreateDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDirButton.Location = new System.Drawing.Point(531, 3);
            this.CreateDirButton.Name = "CreateDirButton";
            this.CreateDirButton.Size = new System.Drawing.Size(126, 45);
            this.CreateDirButton.TabIndex = 4;
            this.CreateDirButton.Text = "CreateDir (F5)";
            this.CreateDirButton.UseVisualStyleBackColor = true;
            this.CreateDirButton.Click += new System.EventHandler(this.CreateDir);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(399, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(126, 45);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove (F4)";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.Remove);
            // 
            // SwapButton
            // 
            this.SwapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwapButton.Location = new System.Drawing.Point(267, 3);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(126, 45);
            this.SwapButton.TabIndex = 2;
            this.SwapButton.Text = "Swap (F3)";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.Swap);
            // 
            // MoveButton
            // 
            this.MoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveButton.Location = new System.Drawing.Point(135, 3);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(126, 45);
            this.MoveButton.TabIndex = 1;
            this.MoveButton.Text = "Move (F2)";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.Copy);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Location = new System.Drawing.Point(3, 3);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(126, 45);
            this.CopyButton.TabIndex = 0;
            this.CopyButton.Text = "Copy (F1)";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.Copy);
            // 
            // LeftPath
            // 
            this.LeftPath.Location = new System.Drawing.Point(34, 66);
            this.LeftPath.Name = "LeftPath";
            this.LeftPath.Size = new System.Drawing.Size(100, 20);
            this.LeftPath.TabIndex = 25;
            this.LeftPath.TextChanged += new System.EventHandler(this.PathChanged);
            this.LeftPath.Enter += new System.EventHandler(this.Focus_Enter);
            this.LeftPath.Leave += new System.EventHandler(this.Focus_Leave);
            // 
            // RightPath
            // 
            this.RightPath.Location = new System.Drawing.Point(635, 67);
            this.RightPath.Name = "RightPath";
            this.RightPath.Size = new System.Drawing.Size(100, 20);
            this.RightPath.TabIndex = 26;
            this.RightPath.TextChanged += new System.EventHandler(this.PathChanged);
            this.RightPath.Enter += new System.EventHandler(this.Focus_Enter);
            this.RightPath.Leave += new System.EventHandler(this.Focus_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton1.Text = "ResizeColumns";
            this.toolStripButton1.Click += new System.EventHandler(this.ColumnsDefault);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton2.Text = "AutoResize";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton2.Click += new System.EventHandler(this.SetAutoResize);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(10, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 293);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(529, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(377, 293);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.RightPath);
            this.Controls.Add(this.LeftPath);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.RightExplorer);
            this.Controls.Add(this.LeftExplorer);
            this.Controls.Add(this.RightExit);
            this.Controls.Add(this.LeftExit);
            this.Controls.Add(this.RightDrive);
            this.Controls.Add(this.LeftDrive);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.Resize += new System.EventHandler(this.WindowResized);
            ((System.ComponentModel.ISupportInitialize)(this.LeftExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightExplorer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LeftDrive;
        private System.Windows.Forms.ComboBox RightDrive;
        private System.Windows.Forms.Button LeftExit;
        private System.Windows.Forms.Button RightExit;
        private System.Windows.Forms.DataGridView LeftExplorer;
        private System.Windows.Forms.DataGridView RightExplorer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CreateTXTButton;
        private System.Windows.Forms.Button CreateDirButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SwapButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.TextBox LeftPath;
        private System.Windows.Forms.TextBox RightPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftExplorerNameCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftExplorerDateModifiedCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftExplorerTypeCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftExplorerSizeCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

