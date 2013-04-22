using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidationWithCultureAndDatabase.Services
{
    public static class LabelService
    {
        public static string GetLabel(string code, System.Globalization.CultureInfo culture)
        {
            // should load value from DB based on code & culture
            return "a label for " + code + " in " + culture.Name;
        }
    }
}