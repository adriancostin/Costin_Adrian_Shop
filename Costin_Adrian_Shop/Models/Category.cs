using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Costin_Adrian_Shop.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required, StringLength(150, MinimumLength = 3)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
