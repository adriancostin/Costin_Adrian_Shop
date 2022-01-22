using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Costin_Adrian_Shop.Models;

namespace Costin_Adrian_Shop.Data
{
    public class Costin_Adrian_ShopContext : DbContext
    {
        public Costin_Adrian_ShopContext (DbContextOptions<Costin_Adrian_ShopContext> options)
            : base(options)
        {
        }

        public DbSet<Costin_Adrian_Shop.Models.Cart> Cart { get; set; }

        public DbSet<Costin_Adrian_Shop.Models.Category> Category { get; set; }

        public DbSet<Costin_Adrian_Shop.Models.Product> Product { get; set; }
    }
}
