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
            this.LeftDrive = new System.Windows.Forms.ComboBox();
            this.RightDrive = new System.Windows.Forms.ComboBox();
            this.action = new System.Windows.Forms.ComboBox();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.LeftPath = new System.Windows.Forms.ComboBox();
            this.LeftExit = new System.Windows.Forms.Button();
            this.RightPath = new System.Windows.Forms.ComboBox();
            this.RightExit = new System.Windows.Forms.Button();
            this.CreateName = new System.Windows.Forms.TextBox();
            this.FileOrFolder = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.LeftExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightExplorer)).BeginInit();
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
            // action
            // 
            this.action.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.action.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.action.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.action.FormattingEnabled = true;
            this.action.Items.AddRange(new object[] {
            "COPY",
            "MOVE",
            "CREATE",
            "DELETE"});
            this.action.Location = new System.Drawing.Point(422, 129);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(72, 21);
            this.action.TabIndex = 4;
            this.action.SelectedIndexChanged += new System.EventHandler(this.action_SelectedIndexChanged);
            // 
            // button_left
            // 
            this.button_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_left.Location = new System.Drawing.Point(422, 177);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 23);
            this.button_left.TabIndex = 5;
            this.button_left.Text = "<===";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.Action);
            // 
            // button_right
            // 
            this.button_right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_right.Location = new System.Drawing.Point(422, 227);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 23);
            this.button_right.TabIndex = 6;
            this.button_right.Text = "===>";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.Action);
            // 
            // LeftPath
            // 
            this.LeftPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LeftPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LeftPath.FormattingEnabled = true;
            this.LeftPath.Location = new System.Drawing.Point(34, 66);
            this.LeftPath.Name = "LeftPath";
            this.LeftPath.Size = new System.Drawing.Size(271, 21);
            this.LeftPath.TabIndex = 7;
            this.LeftPath.SelectedIndexChanged += new System.EventHandler(this.PathChanged);
            this.LeftPath.Click += new System.EventHandler(this.Up);
            this.LeftPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilePathKeyDown);
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
            // RightPath
            // 
            this.RightPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RightPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RightPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RightPath.FormattingEnabled = true;
            this.RightPath.Location = new System.Drawing.Point(642, 66);
            this.RightPath.Name = "RightPath";
            this.RightPath.Size = new System.Drawing.Size(271, 21);
            this.RightPath.TabIndex = 9;
            this.RightPath.SelectedIndexChanged += new System.EventHandler(this.PathChanged);
            this.RightPath.Click += new System.EventHandler(this.Up);
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
            // CreateName
            // 
            this.CreateName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateName.Enabled = false;
            this.CreateName.Location = new System.Drawing.Point(422, 298);
            this.CreateName.Name = "CreateName";
            this.CreateName.Size = new System.Drawing.Size(75, 20);
            this.CreateName.TabIndex = 11;
            this.CreateName.Text = "NewFolder";
            this.CreateName.Visible = false;
            // 
            // FileOrFolder
            // 
            this.FileOrFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileOrFolder.Enabled = false;
            this.FileOrFolder.FormattingEnabled = true;
            this.FileOrFolder.Items.AddRange(new object[] {
            "Folder",
            "File"});
            this.FileOrFolder.Location = new System.Drawing.Point(422, 266);
            this.FileOrFolder.Name = "FileOrFolder";
            this.FileOrFolder.Size = new System.Drawing.Size(75, 21);
            this.FileOrFolder.TabIndex = 12;
            this.FileOrFolder.Visible = false;
            this.FileOrFolder.SelectedIndexChanged += new System.EventHandler(this.FileOrFolder_SelectedIndexChanged);
            this.FileOrFolder.EnabledChanged += new System.EventHandler(this.FileOrFolder_EnabledChanged);
            // 
            // LeftExplorer
            // 
            this.LeftExplorer.AllowUserToAddRows = false;
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
            this.RightExplorer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RightExplorer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.RightExplorer.Location = new System.Drawing.Point(540, 93);
            this.RightExplorer.Name = "RightExplorer";
            this.RightExplorer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RightExplorer.Size = new System.Drawing.Size(373, 289);
            this.RightExplorer.TabIndex = 14;
            this.RightExplorer.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.RenameBegin);
            this.RightExplorer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.RenameEnd);
            this.RightExplorer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ExplorerOpen);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 464);
            this.Controls.Add(this.RightExplorer);
            this.Controls.Add(this.LeftExplorer);
            this.Controls.Add(this.FileOrFolder);
            this.Controls.Add(this.CreateName);
            this.Controls.Add(this.RightExit);
            this.Controls.Add(this.RightPath);
            this.Controls.Add(this.LeftExit);
            this.Controls.Add(this.LeftPath);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.action);
            this.Controls.Add(this.RightDrive);
            this.Controls.Add(this.LeftDrive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.WindowResized);
            ((System.ComponentModel.ISupportInitialize)(this.LeftExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightExplorer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LeftDrive;
        private System.Windows.Forms.ComboBox RightDrive;
        private System.Windows.Forms.ComboBox action;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.ComboBox LeftPath;
        private System.Windows.Forms.Button LeftExit;
        private System.Windows.Forms.ComboBox RightPath;
        private System.Windows.Forms.Button RightExit;
        private System.Windows.Forms.TextBox CreateName;
        private System.Windows.Forms.ComboBox FileOrFolder;
        private System.Windows.Forms.DataGridView LeftExplorer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftExplorerNameCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftExplorerDateModifiedCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftExplorerTypeCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftExplorerSizeCollum;
        private System.Windows.Forms.DataGridView RightExplorer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

