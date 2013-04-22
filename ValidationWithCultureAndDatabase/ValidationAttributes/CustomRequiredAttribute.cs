using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ValidationWithCultureAndDatabase.Services;

namespace ValidationWithCultureAndDatabase.ValidationAttributes
{
    public class CustomRequiredAttribute : RequiredAttribute
    {
        public CustomRequiredAttribute(string translationCode)
        {
            var currentCulture = RequestInfoService.GetCurrentCulture();
            this.ErrorMessage = LabelService.GetLabel(translationCode, currentCulture);
        }
    }
}