using eCommerceKO.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace eCommerceKO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                                                    new Category { CategoryID = 1, CategoryName = "Giyim" },
                                                    new Category { CategoryID = 2, CategoryName = "Bilgisayar" },
                                                    new Category { CategoryID = 3, CategoryName = "Gıda" },
                                                    new Category { CategoryID = 4, CategoryName = "Telefon" },
                                                    new Category { CategoryID = 5, CategoryName = "Kırtasiye" }
                                                    );
            modelBuilder.Entity<Discount>().HasData(
                                                    new Discount { DiscountID = 1, DiscountAmounth = 0 },
                                                    new Discount { DiscountID = 2, DiscountAmounth = 25 },
                                                    new Discount { DiscountID = 3, DiscountAmounth = 40 },
                                                    new Discount { DiscountID = 4, DiscountAmounth = 50 },
                                                    new Discount { DiscountID = 5, DiscountAmounth = 75 }
                                                    );
            modelBuilder.Entity<ProductColor>().HasData(
                                                    new ProductColor { ProductColorID = 1, ProductColorName = "Kırmızı"},
                                                    new ProductColor { ProductColorID = 2, ProductColorName = "Sarı"},
                                                    new ProductColor { ProductColorID = 3, ProductColorName = "Siyah"},
                                                    new ProductColor { ProductColorID = 4, ProductColorName = "Beyaz"},
                                                    new ProductColor { ProductColorID = 5, ProductColorName = "Yeşil"}
                                                    );
            modelBuilder.Entity<ProductSize>().HasData(
                                                    new ProductSize { ProductSizeID = 1, ProductSizeName = "XS" },
                                                    new ProductSize { ProductSizeID = 2, ProductSizeName = "S" },
                                                    new ProductSize { ProductSizeID = 3, ProductSizeName = "M" },
                                                    new ProductSize { ProductSizeID = 4, ProductSizeName = "L" },
                                                    new ProductSize { ProductSizeID = 5, ProductSizeName = "XL" }
                                                    );
            modelBuilder.Entity<Product>().HasData(
                                                    new Product { ProductID = 1, ProductName = "Test Product 1", ProductDescription="test description1", ProductBarcode = "123123123", ProductPrice = 100, ProductPic = null, ProductColorID = 1, ProductSizeID = 1, DiscountID = 1, CategoryID = 1 },
                                                    new Product { ProductID = 2, ProductName = "Test Product 2", ProductDescription="test description2", ProductBarcode = "131543123", ProductPrice = 200, ProductPic = null, ProductColorID = 2, ProductSizeID = 2, DiscountID = 2, CategoryID = 2 },
                                                    new Product { ProductID = 3, ProductName = "Test Product 3", ProductDescription="test description3", ProductBarcode = "128790123", ProductPrice = 300, ProductPic = null, ProductColorID = 3, ProductSizeID = 3, DiscountID = 3, CategoryID = 3 }
                                                    );

        }
    }
}