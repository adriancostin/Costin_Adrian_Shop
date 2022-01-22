using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Costin_Adrian_Shop.Data;
using Costin_Adrian_Shop.Models;

namespace Costin_Adrian_Shop.Pages.Carts
{
    public class CreateModel : PageModel
    {
        private readonly Costin_Adrian_Shop.Data.Costin_Adrian_ShopContext _context;

        public CreateModel(Costin_Adrian_Shop.Data.Costin_Adrian_ShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ProductID"] = new SelectList(_context.Set<Product>(), "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Cart Cart { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cart.Add(Cart);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
