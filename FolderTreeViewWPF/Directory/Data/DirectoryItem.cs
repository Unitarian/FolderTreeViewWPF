using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderTreeViewWPF
{
    public class DirectoryItem
    {
        public string FullPath { get; set; }

        public DirectoryItemType Type { get; set; }

        public string Name
        {
            get
            {
                return Type == DirectoryItemType.Drive ? FullPath : DirectoryStructure.GetFileFolderName(FullPath);
            }
        }


    }
}
