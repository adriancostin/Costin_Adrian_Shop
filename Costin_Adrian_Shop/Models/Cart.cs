using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Costin_Adrian_Shop.Models
{
    public class Cart
    {
        public int ID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        [Required, Range(1,1000)]
        public int Qty { get; set; }
    }
}
