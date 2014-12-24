using System;
using System.Collections.Generic;
using System.Text;

namespace ShellTools
{
    public class FileRenameResult
    {
        public FileRenameResult()
        { }

        public FileRenameResult(string originalName, string newName, string folder)
        { 
            _originalName = originalName;
            _newName = newName;
            _folder = folder;
        }

        private string _originalName;

        public string OriginalName
        {
            get { return _originalName; }
            set { _originalName = value; }
        }

        private string _newName;

        public string NewName
        {
            get { return _newName; }
            set { _newName = value; }
        }

        private string _folder;

        public string Folder
        {
            get { return _folder; }
            set { _folder = value; }
        }

    }
}
