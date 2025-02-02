using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIWeatherApp.Converters
{
    public class CodeToWeatherConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var code = (int?)value;
            switch (code)
            {
                case 0: return "Açık hava";
                case 1:
                case 2:
                case 3: return "Açık, parçalı bulutlu ve kapalı";
                case 45:
                case 48: return "Sis ve yoğunlaşmış kırağı sisi";
                case 51:
                case 53:
                case 55: return "Çiseleme: Hafif, orta ve yoğun şiddet";
                case 56:
                case 57: return "Donan çiseleme: Hafif ve yoğun şiddet";
                case 61:
                case 63:
                case 65: return "Yağmur: Hafif, orta ve yoğun şiddet";
                case 66:
                case 67: return "Donan yağmur: Hafif ve yoğun şiddet";
                case 71:
                case 73:
                case 75: return "Kar yağışı: Hafif, orta ve yoğun şiddet";
                case 77: return "Kar taneleri";
                case 80:
                case 81:
                case 82: return "Sağanak yağmur: Hafif, orta ve şiddetli";
                case 85:
                case 86: return "Kar sağanağı: Hafif ve yoğun";
                case 95: return "Gökgürültülü fırtına: Hafif veya orta şiddet";
                case 96:
                case 99: return "Gökgürültülü fırtına: Hafif ve yoğun dolu yağışı ile";
                default: return "Bilinmeyen hava durumu kodu";
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
