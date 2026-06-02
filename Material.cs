using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;
using System.IO;

using System.Windows.Media.Imaging;
namespace IS_GTS.Converters
{
    public class FavoriteImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isFavorite = value is bool fav && fav;
            string fileName = isFavorite ? "star_on.png" : "star_off.png";

            // Ищем файл в 4-х местах:
            string[] searchPaths =
            {
            // 1. Рядом с .exe
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName),
            
            // 2. В корне проекта (для отладки)
            Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName,
                        "Resources", fileName),
            
            // 3. В текущей папке
            Path.Combine(Environment.CurrentDirectory, "Resources", fileName),
            
            // 4. В папке с программой на уровень выше
            Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName,
                        "Resources", fileName)
        };

            foreach (var path in searchPaths)
            {
                if (File.Exists(path))
                {
                    try
                    {
                        var bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.UriSource = new Uri(path, UriKind.Absolute);
                        bitmap.CacheOption = BitmapCacheOption.OnLoad;
                        bitmap.EndInit();
                        return bitmap;
                    }
                    catch { }
                }
            }

            return null; // Если не нашли - пусто
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
