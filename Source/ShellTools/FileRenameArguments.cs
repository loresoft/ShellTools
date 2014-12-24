using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ShellTools
{
    [XmlRoot("FileRename")]
    public class FileRenameArguments
    {
        public string SourceFolder;
        public string SearchPattern;
        public string ReplacePattern;
        [XmlIgnore]
        public bool IsPreview;
        public bool IgnoreCase;
        public bool IncludeSubfolders;
    }
}
