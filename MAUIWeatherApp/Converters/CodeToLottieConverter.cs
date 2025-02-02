using SkiaSharp.Extended.UI.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIWeatherApp.Converters
{
    public class CodeToLottieConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var code = (int?)value;
            var lottieImageResource = new SKFileLottieImageSource();
            switch (code)
            {
                case 0: lottieImageResource.File = "SunyAnimation.json"; return lottieImageResource;
                case 1:
                case 2:
                case 3:
                    lottieImageResource.File = "PartlyCloud.json";
                    return lottieImageResource;
                case 45:
                case 48: lottieImageResource.File = "Fogy.json"; return lottieImageResource;
                case 51:
                case 53:
                case 55:
                case 56:
                case 57:
                case 61:
                case 63:
                case 65:
                case 66:
                case 67:
                case 80:
                case 81:
                case 82:
                    lottieImageResource.File = "RainyDay.json";
                    return lottieImageResource;
                case 71:
                case 73:
                case 75:
                case 77:
                case 85:
                case 86:
                    lottieImageResource.File = "Snow.json";
                    return lottieImageResource;
                case 95:
                case 96:
                case 99:
                    lottieImageResource.File = "Storm.json";
                    return lottieImageResource; ;
                default:
                    lottieImageResource.File = "SunyAnimation.json";
                    return lottieImageResource;
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
