using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderTreeViewWPF
{
    public class DirectoryStructureViewModel : BaseViewModel
    {
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }

        public DirectoryStructureViewModel()
        {
            var drives = DirectoryStructure.GetLogicalDrives();
            Items = new ObservableCollection<DirectoryItemViewModel>(drives.Select(d => new DirectoryItemViewModel(d.FullPath, d.Type)));
        }
    }
}
