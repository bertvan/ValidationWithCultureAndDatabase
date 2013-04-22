using MyHardCodedResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ValidationWithCultureAndDatabase.Properties;
using ValidationWithCultureAndDatabase.ValidationAttributes;

namespace ValidationWithCultureAndDatabase.Models
{
    public class MyTestModel
    {
        [Required]
        public string Property1 { get; set; }

        [Required(ErrorMessage = "This is a custom validation message, this field is required")]
        public string Property2 { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Required")]
        public string Property3 { get; set; }

        [CustomRequired("samplepage.samplelabel")]
        public string Property4 { get; set; }

        public string CurrentCulture { get; set; }
    }
}