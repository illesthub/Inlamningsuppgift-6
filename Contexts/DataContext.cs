using Inlamningsuppgift_6.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inlamningsuppgift_6.Contexts
{
    public class DataContext : IdentityDbContext<UserEntity>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<UserAddressEntity> UserAdresses { get; set; }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductCategoryEntity> ProductCategories { get; set; }

        public DbSet<ContactFormEntity> ContactForms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "c59eef42-0d80-437c-a387-dfd0685f11e2",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole
                {
                    Id = "5e1ad513-cac9-46ef-92e8-fb55b53f7387",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                });

            var passwordHasher = new PasswordHasher<UserEntity>();
            var adminEntity = new UserEntity
            {
                Id = "c59eef42-0d80-437c-a387-dfd0685f11e2",
                UserName = "admin@bmerketo.com",
                NormalizedUserName = "ADMIN@BMERKETO.COM",
                Email = "admin@bmerketo.com",
                NormalizedEmail = "ADMIN@BMERKETO.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };
            adminEntity.PasswordHash = passwordHasher.HashPassword(adminEntity, "Password123");
            builder.Entity<UserEntity>().HasData(adminEntity);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = adminEntity.Id,
                RoleId = "c59eef42-0d80-437c-a387-dfd0685f11e2"
            });

            builder.Entity<CategoryEntity>().HasData( 
                new CategoryEntity { Id = 1, CategoryName = "new"},
                new CategoryEntity { Id = 2, CategoryName = "featured"},
                new CategoryEntity { Id = 3, CategoryName = "popular"}
                );

            builder.Entity<ProductEntity>().HasData(
                new ProductEntity { Id = 1, Title = "Apple watch series", Price = "$30", LinkUrl = "/images/placeholders/applewatchseries270x295.jpg"},
                new ProductEntity { Id = 2, Title = "Table lamp", Price = "$20", LinkUrl = "/images/placeholders/tablelamp270x295.jpg" },
                new ProductEntity { Id = 3, Title = "Laptop thinkpad lenovo", Price = "$120", LinkUrl = "/images/placeholders/laptopthinkpad270x295.jpg" },
                new ProductEntity { Id = 4, Title = "Camera Fujifilm", Price = "$200", LinkUrl = "/images/placeholders/fujifilmcamera270x295.jpg" },
                new ProductEntity { Id = 5, Title = "Make-up mirror", Price = "$15", LinkUrl = "/images/placeholders/makeupmirror270x295.jpg" },
                new ProductEntity { Id = 6, Title = "Memorycard 128GB Lexar", Price = "$50", LinkUrl = "/images/placeholders/memorycardlexar270x295.jpg" },
                new ProductEntity { Id = 7, Title = "Sunglasses unisex", Price = "$25", LinkUrl = "/images/placeholders/sunglassesunisex270x295.jpg" },
                new ProductEntity { Id = 8, Title = "Bodylotion aloe vera", Price = "$20", LinkUrl = "/images/placeholders/bodylotionaloevera270x295.jpg" },
                new ProductEntity { Id = 9, Title = "Soap and brush", Price = "$10", LinkUrl = "/images/placeholders/soapandbrush270x295.jpg" },
                new ProductEntity { Id = 10, Title = "Kettlebell 4kg", Price = "$30", LinkUrl = "/images/placeholders/kettlebell4kg270x295.jpg" },
                new ProductEntity { Id = 11, Title = "Dumbbells 10kg", Price = "$45", LinkUrl = "/images/placeholders/dumbbells270x295.jpg" },
                new ProductEntity { Id = 12, Title = "White dress", Price = "$80", LinkUrl = "/images/placeholders/whitedress270x295.jpg" },
                new ProductEntity { Id = 13, Title = "Yellow boots", Price = "$50", LinkUrl = "/images/placeholders/yellowboots270x295.jpg" },
                new ProductEntity { Id = 14, Title = "Leather bag", Price = "$65", LinkUrl = "/images/placeholders/leatherbag270x295.jpg" },
                new ProductEntity { Id = 15, Title = "Orange shirt", Price = "$20", LinkUrl = "/images/placeholders/orangeshirt270x295.jpg" },
                new ProductEntity { Id = 16, Title = "Hat timeless", Price = "$25", LinkUrl = "/images/placeholders/hat270x295.jpg" },
                new ProductEntity { Id = 17, Title = "Sunglasses retro", Price = "$60", LinkUrl = "/images/placeholders/sunglasses270x295.jpg" },
                new ProductEntity { Id = 18, Title = "Earbuds with red case", Price = "$120", LinkUrl = "/images/placeholders/earbuds270x295.jpg" },
                new ProductEntity { Id = 19, Title = "Headphones by Dre", Price = "$95", LinkUrl = "/images/placeholders/dreheadphones270x295.jpg" }
                );

            builder.Entity<ProductCategoryEntity>().HasData(
                new ProductCategoryEntity { ProductId = 1, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 1, CategoryId = 3 },
                new ProductCategoryEntity { ProductId = 2, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 3, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 3, CategoryId = 3 },
                new ProductCategoryEntity { ProductId = 4, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 4, CategoryId = 3 },
                new ProductCategoryEntity { ProductId = 5, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 5, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 6, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 6, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 7, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 8, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 8, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 9, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 10, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 11, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 12, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 12, CategoryId = 3 },
                new ProductCategoryEntity { ProductId = 13, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 13, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 14, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 14, CategoryId = 3 },
                new ProductCategoryEntity { ProductId = 15, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 15, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 16, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 16, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 17, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 17, CategoryId = 3 },
                new ProductCategoryEntity { ProductId = 18, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 18, CategoryId = 3 },
                new ProductCategoryEntity { ProductId = 19, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 19, CategoryId = 3 }
                );
        }
    }


}
