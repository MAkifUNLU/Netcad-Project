using Microsoft.EntityFrameworkCore;
using App.Data.Entity;
using System.Collections.Generic;

namespace App.Data.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
