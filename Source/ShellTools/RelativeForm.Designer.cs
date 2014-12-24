namespace ShellTools
{
    partial class RelativeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelativeForm));
            this.startFolderTextBox = new System.Windows.Forms.TextBox();
            this.destinationPathTextBox = new System.Windows.Forms.TextBox();
            this.relativePathTextBox = new System.Windows.Forms.TextBox();
            this.startingFolderLabel = new System.Windows.Forms.Label();
            this.destinationPathLabel = new System.Windows.Forms.Label();
            this.relativePathLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.browsePathButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.swapButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // startFolderTextBox
            // 
            this.startFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider.SetIconAlignment(this.startFolderTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.startFolderTextBox.Location = new System.Drawing.Point(19, 31);
            this.startFolderTextBox.Name = "startFolderTextBox";
            this.startFolderTextBox.Size = new System.Drawing.Size(349, 20);
            this.startFolderTextBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.startFolderTextBox, "The starting folder must be a folder.  The folder does not need to be rooted.");
            this.startFolderTextBox.Leave += new System.EventHandler(this.startFolderTextBox_Leave);
            // 
            // destinationPathTextBox
            // 
            this.destinationPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationPathTextBox.Location = new System.Drawing.Point(19, 75);
            this.destinationPathTextBox.Name = "destinationPathTextBox";
            this.destinationPathTextBox.Size = new System.Drawing.Size(349, 20);
            this.destinationPathTextBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.destinationPathTextBox, "The path to make relative to.");
            this.destinationPathTextBox.Leave += new System.EventHandler(this.destinationPathTextBox_Leave);
            // 
            // relativePathTextBox
            // 
            this.relativePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.relativePathTextBox.Location = new System.Drawing.Point(19, 120);
            this.relativePathTextBox.Name = "relativePathTextBox";
            this.relativePathTextBox.ReadOnly = true;
            this.relativePathTextBox.Size = new System.Drawing.Size(381, 20);
            this.relativePathTextBox.TabIndex = 4;
            this.toolTip.SetToolTip(this.relativePathTextBox, "The relative path is automatically copied to the Clipboard when clicking OK.");
            // 
            // startingFolderLabel
            // 
            this.startingFolderLabel.AutoSize = true;
            this.startingFolderLabel.Location = new System.Drawing.Point(16, 14);
            this.startingFolderLabel.Name = "startingFolderLabel";
            this.startingFolderLabel.Size = new System.Drawing.Size(78, 13);
            this.startingFolderLabel.TabIndex = 3;
            this.startingFolderLabel.Text = "&Starting Folder:";
            // 
            // destinationPathLabel
            // 
            this.destinationPathLabel.AutoSize = true;
            this.destinationPathLabel.Location = new System.Drawing.Point(16, 58);
            this.destinationPathLabel.Name = "destinationPathLabel";
            this.destinationPathLabel.Size = new System.Drawing.Size(88, 13);
            this.destinationPathLabel.TabIndex = 4;
            this.destinationPathLabel.Text = "&Destination Path:";
            // 
            // relativePathLabel
            // 
            this.relativePathLabel.AutoSize = true;
            this.relativePathLabel.Location = new System.Drawing.Point(16, 103);
            this.relativePathLabel.Name = "relativePathLabel";
            this.relativePathLabel.Size = new System.Drawing.Size(74, 13);
            this.relativePathLabel.TabIndex = 5;
            this.relativePathLabel.Text = "&Relative Path:";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(242, 157);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(325, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // browseFolderButton
            // 
            this.browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFolderButton.Location = new System.Drawing.Point(376, 29);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(24, 22);
            this.browseFolderButton.TabIndex = 1;
            this.browseFolderButton.Text = "...";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
            // 
            // browsePathButton
            // 
            this.browsePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browsePathButton.Location = new System.Drawing.Point(376, 73);
            this.browsePathButton.Name = "browsePathButton";
            this.browsePathButton.Size = new System.Drawing.Size(24, 22);
            this.browsePathButton.TabIndex = 3;
            this.browsePathButton.Text = "...";
            this.browsePathButton.UseVisualStyleBackColor = true;
            this.browsePathButton.Click += new System.EventHandler(this.browsePathButton_Click);
            // 
            // swapButton
            // 
            this.swapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.swapButton.Location = new System.Drawing.Point(19, 157);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(75, 23);
            this.swapButton.TabIndex = 7;
            this.swapButton.Text = "S&wap";
            this.toolTip.SetToolTip(this.swapButton, "Swap Starting Folder with Destination Path.");
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files (*.*)|*.*";
            this.openFileDialog.Title = "Select Destination Path";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RelativeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 194);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.startingFolderLabel);
            this.Controls.Add(this.startFolderTextBox);
            this.Controls.Add(this.browseFolderButton);
            this.Controls.Add(this.destinationPathLabel);
            this.Controls.Add(this.destinationPathTextBox);
            this.Controls.Add(this.browsePathButton);
            this.Controls.Add(this.relativePathLabel);
            this.Controls.Add(this.relativePathTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(420, 220);
            this.Name = "RelativeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Relative Path";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startFolderTextBox;
        private System.Windows.Forms.TextBox destinationPathTextBox;
        private System.Windows.Forms.TextBox relativePathTextBox;
        private System.Windows.Forms.Label startingFolderLabel;
        private System.Windows.Forms.Label destinationPathLabel;
        private System.Windows.Forms.Label relativePathLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.Button browsePathButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button swapButton;
    }
}