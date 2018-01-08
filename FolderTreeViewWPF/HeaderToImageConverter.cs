using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace FolderTreeViewWPF
{
    [ValueConversion(typeof(DirectoryItemType),typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = (DirectoryItemType)value;
         
            var image = "Images/file.png";

            if (type == DirectoryItemType.Drive)
            {
                image = "Images/drive.png";
            }
            else if (type == DirectoryItemType.Folder)
            {
                image = "Images/folder-closed.png";
            }

            return new BitmapImage(new Uri($"pack://application:,,,/{image}"));

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
