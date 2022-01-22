using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Costin_Adrian_Shop.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required, StringLength(1000, MinimumLength = 3)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Product Image")]
        public string ImageURL { get; set; }

        [Required, Range(0.01, 999999)]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
