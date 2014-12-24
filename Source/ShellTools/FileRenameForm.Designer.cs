namespace ShellTools
{
    partial class FileRenameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileRenameForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.previewButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.matchRegexTextBox = new System.Windows.Forms.RichTextBox();
            this.replaceTextBox = new System.Windows.Forms.RichTextBox();
            this.renameTabControl = new System.Windows.Forms.TabControl();
            this.matchTabPage = new System.Windows.Forms.TabPage();
            this.folderLabel = new System.Windows.Forms.Label();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.matchRegexLabel = new System.Windows.Forms.Label();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.resultTabPage = new System.Windows.Forms.TabPage();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.folderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renameButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.renameBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.renameStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeSubfoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.renameTabControl.SuspendLayout();
            this.matchTabPage.SuspendLayout();
            this.resultTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.renameStatusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // previewButton
            // 
            this.previewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previewButton.Location = new System.Drawing.Point(8, 277);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 1;
            this.previewButton.Text = "&Preview";
            this.toolTip.SetToolTip(this.previewButton, "Preview the file rename");
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // matchRegexTextBox
            // 
            this.matchRegexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.matchRegexTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.matchRegexTextBox, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.matchRegexTextBox.Location = new System.Drawing.Point(8, 71);
            this.matchRegexTextBox.Name = "matchRegexTextBox";
            this.matchRegexTextBox.Size = new System.Drawing.Size(376, 73);
            this.matchRegexTextBox.TabIndex = 4;
            this.matchRegexTextBox.Text = "";
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.replaceTextBox, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.replaceTextBox.Location = new System.Drawing.Point(8, 168);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(376, 39);
            this.replaceTextBox.TabIndex = 6;
            this.replaceTextBox.Text = "";
            // 
            // renameTabControl
            // 
            this.renameTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.renameTabControl.Controls.Add(this.matchTabPage);
            this.renameTabControl.Controls.Add(this.resultTabPage);
            this.renameTabControl.Location = new System.Drawing.Point(4, 27);
            this.renameTabControl.Name = "renameTabControl";
            this.renameTabControl.SelectedIndex = 0;
            this.renameTabControl.Size = new System.Drawing.Size(426, 244);
            this.renameTabControl.TabIndex = 0;
            // 
            // matchTabPage
            // 
            this.matchTabPage.Controls.Add(this.folderLabel);
            this.matchTabPage.Controls.Add(this.folderTextBox);
            this.matchTabPage.Controls.Add(this.browseFolderButton);
            this.matchTabPage.Controls.Add(this.matchRegexLabel);
            this.matchTabPage.Controls.Add(this.matchRegexTextBox);
            this.matchTabPage.Controls.Add(this.replaceLabel);
            this.matchTabPage.Controls.Add(this.replaceTextBox);
            this.matchTabPage.Location = new System.Drawing.Point(4, 22);
            this.matchTabPage.Name = "matchTabPage";
            this.matchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.matchTabPage.Size = new System.Drawing.Size(418, 218);
            this.matchTabPage.TabIndex = 0;
            this.matchTabPage.Text = "Match";
            this.matchTabPage.UseVisualStyleBackColor = true;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(7, 13);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(39, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "&Folder:";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTextBox.Location = new System.Drawing.Point(8, 30);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(376, 20);
            this.folderTextBox.TabIndex = 1;
            // 
            // browseFolderButton
            // 
            this.browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFolderButton.Location = new System.Drawing.Point(388, 28);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(24, 22);
            this.browseFolderButton.TabIndex = 2;
            this.browseFolderButton.Text = "...";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
            // 
            // matchRegexLabel
            // 
            this.matchRegexLabel.AutoSize = true;
            this.matchRegexLabel.Location = new System.Drawing.Point(7, 54);
            this.matchRegexLabel.Name = "matchRegexLabel";
            this.matchRegexLabel.Size = new System.Drawing.Size(134, 13);
            this.matchRegexLabel.TabIndex = 3;
            this.matchRegexLabel.Text = "&Match Regular Expression:";
            // 
            // replaceLabel
            // 
            this.replaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(7, 151);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(87, 13);
            this.replaceLabel.TabIndex = 5;
            this.replaceLabel.Text = "&Replace Pattern:";
            // 
            // resultTabPage
            // 
            this.resultTabPage.Controls.Add(this.resultDataGridView);
            this.resultTabPage.Location = new System.Drawing.Point(4, 22);
            this.resultTabPage.Name = "resultTabPage";
            this.resultTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultTabPage.Size = new System.Drawing.Size(418, 218);
            this.resultTabPage.TabIndex = 1;
            this.resultTabPage.Text = "Results";
            this.resultTabPage.UseVisualStyleBackColor = true;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToDeleteRows = false;
            this.resultDataGridView.AllowUserToResizeRows = false;
            this.resultDataGridView.AutoGenerateColumns = false;
            this.resultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.originalNameDataGridViewTextBoxColumn,
            this.newNameDataGridViewTextBoxColumn,
            this.folderDataGridViewTextBoxColumn});
            this.resultDataGridView.DataSource = this.resultBindingSource;
            this.resultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDataGridView.Location = new System.Drawing.Point(3, 3);
            this.resultDataGridView.MultiSelect = false;
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.Size = new System.Drawing.Size(412, 212);
            this.resultDataGridView.TabIndex = 0;
            // 
            // folderDataGridViewTextBoxColumn
            // 
            this.folderDataGridViewTextBoxColumn.DataPropertyName = "Folder";
            this.folderDataGridViewTextBoxColumn.HeaderText = "Folder";
            this.folderDataGridViewTextBoxColumn.Name = "folderDataGridViewTextBoxColumn";
            this.folderDataGridViewTextBoxColumn.ReadOnly = true;
            this.folderDataGridViewTextBoxColumn.Width = 61;
            // 
            // renameButton
            // 
            this.renameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.renameButton.Location = new System.Drawing.Point(270, 277);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 23);
            this.renameButton.TabIndex = 2;
            this.renameButton.Text = "Re&name";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(351, 277);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // renameBackgroundWorker
            // 
            this.renameBackgroundWorker.WorkerReportsProgress = true;
            this.renameBackgroundWorker.WorkerSupportsCancellation = true;
            this.renameBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.renameBackgroundWorker_DoWork);
            this.renameBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.renameBackgroundWorker_RunWorkerCompleted);
            this.renameBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.renameBackgroundWorker_ProgressChanged);
            // 
            // renameStatusStrip
            // 
            this.renameStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.renameStatusStrip.Location = new System.Drawing.Point(0, 313);
            this.renameStatusStrip.Name = "renameStatusStrip";
            this.renameStatusStrip.Size = new System.Drawing.Size(434, 22);
            this.renameStatusStrip.TabIndex = 4;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(317, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Ready";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(434, 24);
            this.mainMenuStrip.TabIndex = 5;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ignoreCaseToolStripMenuItem,
            this.includeSubfoldersToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // ignoreCaseToolStripMenuItem
            // 
            this.ignoreCaseToolStripMenuItem.Checked = true;
            this.ignoreCaseToolStripMenuItem.CheckOnClick = true;
            this.ignoreCaseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreCaseToolStripMenuItem.Name = "ignoreCaseToolStripMenuItem";
            this.ignoreCaseToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ignoreCaseToolStripMenuItem.Text = "Ignore &Case";
            // 
            // includeSubfoldersToolStripMenuItem
            // 
            this.includeSubfoldersToolStripMenuItem.CheckOnClick = true;
            this.includeSubfoldersToolStripMenuItem.Name = "includeSubfoldersToolStripMenuItem";
            this.includeSubfoldersToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.includeSubfoldersToolStripMenuItem.Text = "Include &Subfolders";
            // 
            // originalNameDataGridViewTextBoxColumn
            // 
            this.originalNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.originalNameDataGridViewTextBoxColumn.DataPropertyName = "OriginalName";
            this.originalNameDataGridViewTextBoxColumn.HeaderText = "OriginalName";
            this.originalNameDataGridViewTextBoxColumn.Name = "originalNameDataGridViewTextBoxColumn";
            this.originalNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.originalNameDataGridViewTextBoxColumn.Width = 95;
            // 
            // newNameDataGridViewTextBoxColumn
            // 
            this.newNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.newNameDataGridViewTextBoxColumn.DataPropertyName = "NewName";
            this.newNameDataGridViewTextBoxColumn.HeaderText = "NewName";
            this.newNameDataGridViewTextBoxColumn.Name = "newNameDataGridViewTextBoxColumn";
            this.newNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.newNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.AllowNew = false;
            this.resultBindingSource.DataSource = typeof(ShellTools.FileRenameResult);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Xml Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.saveFileDialog.SupportMultiDottedExtensions = true;
            this.saveFileDialog.Title = "Save Rename Settings";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Xml Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "Open File Rename Settings";
            // 
            // FileRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 335);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.renameTabControl);
            this.Controls.Add(this.renameStatusStrip);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "FileRenameForm";
            this.Text = "Bulk File Rename";
            this.Load += new System.EventHandler(this.FileRenameForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileRenameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.renameTabControl.ResumeLayout(false);
            this.matchTabPage.ResumeLayout(false);
            this.matchTabPage.PerformLayout();
            this.resultTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.renameStatusStrip.ResumeLayout(false);
            this.renameStatusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl renameTabControl;
        private System.Windows.Forms.TabPage matchTabPage;
        private System.Windows.Forms.Label matchRegexLabel;
        private System.Windows.Forms.RichTextBox matchRegexTextBox;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.TabPage resultTabPage;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.RichTextBox replaceTextBox;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private System.ComponentModel.BackgroundWorker renameBackgroundWorker;
        private System.Windows.Forms.StatusStrip renameStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem ignoreCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem includeSubfoldersToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}