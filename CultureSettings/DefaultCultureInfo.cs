using System.Threading;
using System.Globalization;

namespace CultureSettings
{
    class DefaultCultureInfo
    {
        public static void SetCulture(string culture)
        {
            CultureInfo cultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}