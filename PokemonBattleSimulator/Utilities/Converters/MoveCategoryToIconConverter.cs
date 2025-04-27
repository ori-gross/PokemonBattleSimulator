using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using PokemonBattleSimulator.Models.Enums;
using System.Windows.Media.Imaging;

namespace PokemonBattleSimulator.Utilities.Converters
{
    public class MoveCategoryToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MoveCategory type)
            {
                string path = $"pack://application:,,,/Resources/UI/Graphics/Icons/Categories/{type}.png";
                return new BitmapImage(new Uri(path));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotImplementedException();
    }
}
