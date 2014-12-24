using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using ShellTools.Utility;
using System.Xml.Serialization;
using System.Xml;

namespace ShellTools
{
    public partial class FileRenameForm : Form
    {

        private BindingList<FileRenameResult> _renamedResult = new BindingList<FileRenameResult>();
        
        public FileRenameForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default["FileRenameSize"] != null)
                this.Size = Properties.Settings.Default.FileRenameSize;
            
        }

        public FileRenameForm(string startPath)
            : this()
        {
            folderTextBox.Text = startPath;
        }

        private void FileRenameForm_Load(object sender, EventArgs e)
        {
            resultBindingSource.DataSource = _renamedResult;
            
            matchRegexTextBox.Text = Properties.Settings.Default.RenameSearchPattern;
            replaceTextBox.Text = Properties.Settings.Default.RenameReplacePattern;
            
            if (string.IsNullOrEmpty(folderTextBox.Text))
                folderTextBox.Text = Properties.Settings.Default.SourceFolder;

            ignoreCaseToolStripMenuItem.Checked = Properties.Settings.Default.RenameIgnoreCase;
            includeSubfoldersToolStripMenuItem.Checked = Properties.Settings.Default.RenameIncludeSubfolders;
        }

        private void browseFolderButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(folderTextBox.Text))
                folderBrowserDialog.SelectedPath = folderTextBox.Text;
            
            folderBrowserDialog.Description = "Select the folder to rename file(s) in.";
            DialogResult result = folderBrowserDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            folderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            FileRenameArguments args = CreateArguments();
            args.IsPreview = false;
            RunRename(args);
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            FileRenameArguments args = CreateArguments();
            args.IsPreview = true;
            RunRename(args);
        }

        private FileRenameArguments CreateArguments()
        {
            FileRenameArguments args = new FileRenameArguments();
            args.ReplacePattern = replaceTextBox.Text;
            args.SearchPattern = matchRegexTextBox.Text;
            args.SourceFolder = folderTextBox.Text;
            args.IgnoreCase = ignoreCaseToolStripMenuItem.Checked;
            args.IncludeSubfolders = includeSubfoldersToolStripMenuItem.Checked;
            return args;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (renameBackgroundWorker.IsBusy)
                renameBackgroundWorker.CancelAsync();
            else
                this.Close();
        }

        private void RunRename(FileRenameArguments renameArguments)
        {
            renameButton.Enabled = false;
            previewButton.Enabled = false;
            _renamedResult.Clear();
            renameBackgroundWorker.RunWorkerAsync(renameArguments);
        }

        private void renameBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FileRenameArguments args = e.Argument as FileRenameArguments;
            if (args == null || string.IsNullOrEmpty(args.SourceFolder))
                return;

            DirectoryInfo sourceDirectory = new DirectoryInfo(args.SourceFolder);
            if (!sourceDirectory.Exists)
                return;

            SearchOption so = args.IncludeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            FileInfo[] files = sourceDirectory.GetFiles("*.*", so);
            if (files == null || files.Length == 0)
                return;

            RegexOptions ro = args.IgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None;

            Regex searchRegex = new Regex(args.SearchPattern, ro);
            int fileIndex = 0;
            foreach (FileInfo file in files)
            {
                if (e.Cancel)
                    break;

                fileIndex++;
                string renamedFile = searchRegex.Replace(file.Name, args.ReplacePattern);
                FileRenameResult fileResult = new FileRenameResult(file.Name, renamedFile, file.DirectoryName);
                
                int precent = (fileIndex * 100) / files.Length;
                renameBackgroundWorker.ReportProgress(precent, fileResult);

                if (file.Name.Equals(renamedFile))
                    continue;

                if (!args.IsPreview)
                    File.Move(file.FullName, Path.Combine(file.DirectoryName, renamedFile));
            }
        }

        private void renameBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar.Value = e.ProgressPercentage;
            FileRenameResult fileResult = e.UserState as FileRenameResult;
            if (fileResult == null)
                return;

            toolStripStatusLabel.Text = fileResult.OriginalName;

            if (!fileResult.OriginalName.Equals(fileResult.NewName))
            {
                fileResult.Folder = PathHelper.RelativePathTo(folderTextBox.Text, fileResult.Folder);
                _renamedResult.Add(fileResult);
            }
            
            renameTabControl.SelectTab("resultTabPage");

        }

        private void renameBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel.Text = "Complete";
            renameButton.Enabled = true;
            previewButton.Enabled = true;
        }

        private void FileRenameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.RenameSearchPattern = matchRegexTextBox.Text;
            Properties.Settings.Default.RenameReplacePattern = replaceTextBox.Text;
            Properties.Settings.Default.SourceFolder = folderTextBox.Text;
            Properties.Settings.Default.FileRenameSize = this.Size;
            Properties.Settings.Default.RenameIgnoreCase = ignoreCaseToolStripMenuItem.Checked;
            Properties.Settings.Default.RenameIncludeSubfolders = includeSubfoldersToolStripMenuItem.Checked;

            Properties.Settings.Default.Save();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBoxBase)
                ((TextBoxBase)this.ActiveControl).Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is RichTextBox)
                ((RichTextBox)this.ActiveControl).Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBoxBase)
                ((TextBoxBase)this.ActiveControl).Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBoxBase)
                ((TextBoxBase)this.ActiveControl).Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBoxBase)
                ((TextBoxBase)this.ActiveControl).Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBoxBase)
                ((TextBoxBase)this.ActiveControl).SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matchRegexTextBox.Text = string.Empty;
            replaceTextBox.Text = string.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            FileRenameArguments args;

            XmlSerializer serializer = new XmlSerializer(typeof(FileRenameArguments));
            using (XmlReader r = XmlReader.Create(openFileDialog.FileName))
            {
                args = serializer.Deserialize(r) as FileRenameArguments;
            }

            if (args == null)
                return;

            folderTextBox.Text = args.SourceFolder;
            matchRegexTextBox.Text = args.SearchPattern;
            replaceTextBox.Text = args.ReplacePattern;
            ignoreCaseToolStripMenuItem.Checked = args.IgnoreCase;
            includeSubfoldersToolStripMenuItem.Checked = args.IncludeSubfolders;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            FileRenameArguments args = CreateArguments();
            
            XmlWriterSettings s = new XmlWriterSettings();
            s.Indent = true;

            XmlSerializer serializer = new XmlSerializer(typeof(FileRenameArguments));
            using (XmlWriter w = XmlWriter.Create(saveFileDialog.FileName, s))
            {
                serializer.Serialize(w, args);
                w.Flush();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}