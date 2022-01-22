using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Costin_Adrian_Shop.Data;
using Costin_Adrian_Shop.Models;

namespace Costin_Adrian_Shop.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Costin_Adrian_Shop.Data.Costin_Adrian_ShopContext _context;

        public DetailsModel(Costin_Adrian_Shop.Data.Costin_Adrian_ShopContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(p => p.Category).FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
