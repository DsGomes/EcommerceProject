using EcommerceProject.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) { 
                optionsBuilder.UseSqlServer(GetConnectionString());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetConnectionString()
        {
            string strConnection = "Data Source=DESKTOP-R65USTD\\SQLEXPRESS;Initial Catalog=ECOMMERCE_PROJECT;Integrated Security=True";
            return strConnection;
        }
    }
}
