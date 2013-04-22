using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationWithCultureAndDatabase.Services;

namespace ValidationWithCultureAndDatabase.ValidationAttributes
{
    public class DbTranslationRequiredAttribute : ValidationAttribute
    {
        public DbTranslationRequiredAttribute(string translationCode)
            : base(() => GetErrorMessage(translationCode))
        {
            this.TranslationCode = translationCode;
        }

        public string TranslationCode { get; set; }

        private static string GetErrorMessage(string translationCode)
        {
            var culture = RequestInfoService.GetCurrentCulture();
            var errorMessage = LabelService.GetLabel(translationCode, culture);

            return errorMessage; ;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRequiredRule(this.TranslationCode);
        }

        public override bool IsValid(object value)
        {
            return new RequiredAttribute().IsValid(value);
        }
    }

    public class DbTranslationRequiredAttributeAdapter : DataAnnotationsModelValidator<DbTranslationRequiredAttribute>
    {
        public DbTranslationRequiredAttributeAdapter(ModelMetadata metadata, ControllerContext context, DbTranslationRequiredAttribute attribute)
            : base(metadata, context, attribute)
        {
        }
    }
}