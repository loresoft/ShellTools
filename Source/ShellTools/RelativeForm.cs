using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ShellTools.Utility;

namespace ShellTools
{
    public partial class RelativeForm : Form
    {
        public RelativeForm()
        {
            InitializeComponent();
        }

        public RelativeForm(string startPath) : this()
        {
            destinationPathTextBox.Text = startPath;
        }
        
        private void startFolderTextBox_Leave(object sender, EventArgs e)
        {
            CalculateRelativePath();
        }

        private void destinationPathTextBox_Leave(object sender, EventArgs e)
        {
            CalculateRelativePath();
        }

        private void browseFolderButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(startFolderTextBox.Text))
                folderBrowserDialog.SelectedPath = startFolderTextBox.Text;
            else if (!string.IsNullOrEmpty(destinationPathTextBox.Text))
                folderBrowserDialog.SelectedPath = Path.GetDirectoryName(destinationPathTextBox.Text);
            else
                folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;

            folderBrowserDialog.Description = "Select the starting folder for the relative path.";
            DialogResult result = folderBrowserDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            startFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            CalculateRelativePath();
        }

        private void browsePathButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(destinationPathTextBox.Text))
                openFileDialog.FileName = destinationPathTextBox.Text;
            else if (!string.IsNullOrEmpty(startFolderTextBox.Text))
                openFileDialog.InitialDirectory = startFolderTextBox.Text;
            else
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            DialogResult result = openFileDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            destinationPathTextBox.Text = openFileDialog.FileName;
            CalculateRelativePath();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CalculateRelativePath();
            if (!string.IsNullOrEmpty(relativePathTextBox.Text))
                Clipboard.SetText(relativePathTextBox.Text);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void CalculateRelativePath()
        {
            if (string.IsNullOrEmpty(startFolderTextBox.Text)
                || string.IsNullOrEmpty(destinationPathTextBox.Text))
            {
                relativePathTextBox.Text = string.Empty;
                return;
            }

            string path = PathHelper.RelativePathTo(
                startFolderTextBox.Text, destinationPathTextBox.Text);

            relativePathTextBox.Text = path;
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            string path = destinationPathTextBox.Text;
            destinationPathTextBox.Text = startFolderTextBox.Text;
            startFolderTextBox.Text = path;
            CalculateRelativePath();
        }
    }
}