using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2hand.Model
{
    public class Book2handContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Publisher> Publisheres { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
