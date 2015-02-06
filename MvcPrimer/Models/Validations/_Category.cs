using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcPrimer.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category  { }

    public class CategoryMetaData
    {
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage="The {0} must be between {2} and {1} characters", MinimumLength=5)]
        public string Description { get; set; }
    }
}