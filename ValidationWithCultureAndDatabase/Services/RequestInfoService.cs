using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace ValidationWithCultureAndDatabase.Services
{
    public static class RequestInfoService
    {
        public static System.Globalization.CultureInfo GetCurrentCulture()
        {
            return Thread.CurrentThread.CurrentCulture;
        }
    }
}