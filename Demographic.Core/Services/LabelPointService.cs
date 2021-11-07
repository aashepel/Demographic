using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.Core.Services
{
    public static class LabelPointService
    {
        public static string GetShortLabel(uint value)
        {
            int cntK = 0;
            double dvalue = value;
            while (dvalue >= 1000d)
            {
                dvalue = dvalue / 1000;
                cntK++;
            }
            return $"{dvalue} {new string('k', cntK)}";
        }

        public static string GetDividedNumberString(uint value)
        {
            var culture = new CultureInfo("ru-RU");
            return value.ToString("#,#", culture);
        }

        public static string GetDividedNumberString(UInt64 value)
        {
            var culture = new CultureInfo("ru-RU");
            return value.ToString("#,#", culture);
        }
    }
}
