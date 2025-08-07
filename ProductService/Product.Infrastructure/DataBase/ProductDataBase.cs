using Microsoft.EntityFrameworkCore;
using Product.Domain.Models;
using Product.Domain.Modelsl;

namespace Product.Infrastructure.DataBase
{
    public class ProductDataBase : DbContext 
    {
        public ProductDataBase(DbContextOptions<ProductDataBase> options)
            :base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductModel>()
                .Property(p => p.PriceType)
                .HasConversion<string>()
                .HasMaxLength(50);
        }
    }
}
