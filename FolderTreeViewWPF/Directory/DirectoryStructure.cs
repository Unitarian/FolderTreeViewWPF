using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderTreeViewWPF
{
    public static class DirectoryStructure
    {
        public static List<DirectoryItem> GetLogicalDrives()
        {
            return Directory.GetLogicalDrives().Select(d => new DirectoryItem() { FullPath = d, Type = DirectoryItemType.Drive }).ToList();
        }

        public static List<DirectoryItem> GetDirectoryContent(string fullPath)
        {
            var items = new List<DirectoryItem>();

            #region Get Directories
            
            try
            {
                var dirs = Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                    items.AddRange(dirs.Select(d => new DirectoryItem { FullPath = d, Type = DirectoryItemType.Folder }));
            }
            catch { }
            
            #endregion

            #region Get Files
            try
            {
                var files = Directory.GetFiles(fullPath);
                if (files.Length > 0)
                {
                    items.AddRange(files.Select(f => new DirectoryItem { FullPath = f, Type = DirectoryItemType.File}));
                }
            }
            catch { }

            #endregion

            return items;
        }

        public static string GetFileFolderName(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }

            var normalizedPath = path.Replace('/', '\\');

            var lastIndex = normalizedPath.LastIndexOf('\\');

            if (lastIndex <= 0)
                return path;

            return path.Substring(lastIndex + 1);

        }
    }
}
