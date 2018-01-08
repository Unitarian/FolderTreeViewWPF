using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace FolderTreeViewWPF
{
    public class DirectoryItemViewModel : BaseViewModel
    {
        public string FullPath { get; set; }

        public DirectoryItemType Type { get; set; }

        public string Name { get { return Type == DirectoryItemType.Drive ? FullPath : DirectoryStructure.GetFileFolderName(FullPath); } }

        public ObservableCollection<DirectoryItemViewModel> Children { get; set; }

        public bool CanExpand { get { return Type != DirectoryItemType.File; } }

        public bool IsExpanded
        {
            get
            {
                return Children?.Count(f => f != null) > 0;
            }

            set
            {
                if (value)
                {
                    Expand();
                }
                else
                {
                    ClearChildren();
                }
            }
        }

        public ICommand ExpandCommand { get; set; }

        private void Expand()
        {
            if (Type == DirectoryItemType.File)
                return;

            Children = new ObservableCollection<DirectoryItemViewModel> (DirectoryStructure.GetDirectoryContent(FullPath).Select(c => new DirectoryItemViewModel (c.FullPath, c.Type)));
        }

        private void ClearChildren()
        {
            Children = new ObservableCollection<DirectoryItemViewModel>();

            if (Type != DirectoryItemType.File)
            {
                Children.Add(null);
            }
        }

        public DirectoryItemViewModel(string fullPath, DirectoryItemType type)
        {
            ExpandCommand = new RelayCommand(Expand);
            FullPath = fullPath;
            Type = type;

            ClearChildren();
        }
    }
}