using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Costin_Adrian_Shop.Data;
using Costin_Adrian_Shop.Models;

namespace Costin_Adrian_Shop.Pages.Carts
{
    public class IndexModel : PageModel
    {
        private readonly Costin_Adrian_Shop.Data.Costin_Adrian_ShopContext _context;

        public IndexModel(Costin_Adrian_Shop.Data.Costin_Adrian_ShopContext context)
        {
            _context = context;
        }

        public IList<Cart> Cart { get;set; }

        public async Task OnGetAsync()
        {
            Cart = await _context.Cart
                .Include(c => c.Product).ToListAsync();
        }
    }
}
