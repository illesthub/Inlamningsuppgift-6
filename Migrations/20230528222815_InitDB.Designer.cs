﻿// <auto-generated />
using System;
using Inlamningsuppgift_6.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inlamningsuppgift_6.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230528222815_InitDB")]
    partial class InitDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "new"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "featured"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "popular"
                        });
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.ContactFormEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.ProductCategoryEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LinkUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LinkUrl = "/images/placeholders/applewatchseries270x295.jpg",
                            Price = "$30",
                            Title = "Apple watch series"
                        },
                        new
                        {
                            Id = 2,
                            LinkUrl = "/images/placeholders/tablelamp270x295.jpg",
                            Price = "$20",
                            Title = "Table lamp"
                        },
                        new
                        {
                            Id = 3,
                            LinkUrl = "/images/placeholders/laptopthinkpad270x295.jpg",
                            Price = "$120",
                            Title = "Laptop thinkpad lenovo"
                        },
                        new
                        {
                            Id = 4,
                            LinkUrl = "/images/placeholders/fujifilmcamera270x295.jpg",
                            Price = "$200",
                            Title = "Camera Fujifilm"
                        },
                        new
                        {
                            Id = 5,
                            LinkUrl = "/images/placeholders/makeupmirror270x295.jpg",
                            Price = "$15",
                            Title = "Make-up mirror"
                        },
                        new
                        {
                            Id = 6,
                            LinkUrl = "/images/placeholders/memorycardlexar270x295.jpg",
                            Price = "$50",
                            Title = "Memorycard 128GB Lexar"
                        },
                        new
                        {
                            Id = 7,
                            LinkUrl = "/images/placeholders/sunglassesunisex270x295.jpg",
                            Price = "$25",
                            Title = "Sunglasses unisex"
                        },
                        new
                        {
                            Id = 8,
                            LinkUrl = "/images/placeholders/bodylotionaloevera270x295.jpg",
                            Price = "$20",
                            Title = "Bodylotion aloe vera"
                        },
                        new
                        {
                            Id = 9,
                            LinkUrl = "/images/placeholders/soapandbrush270x295.jpg",
                            Price = "$10",
                            Title = "Soap and brush"
                        },
                        new
                        {
                            Id = 10,
                            LinkUrl = "/images/placeholders/kettlebell4kg270x295.jpg",
                            Price = "$30",
                            Title = "Kettlebell 4kg"
                        },
                        new
                        {
                            Id = 11,
                            LinkUrl = "/images/placeholders/dumbbells270x295.jpg",
                            Price = "$45",
                            Title = "Dumbbells 10kg"
                        },
                        new
                        {
                            Id = 12,
                            LinkUrl = "/images/placeholders/whitedress270x295.jpg",
                            Price = "$80",
                            Title = "White dress"
                        },
                        new
                        {
                            Id = 13,
                            LinkUrl = "/images/placeholders/yellowboots270x295.jpg",
                            Price = "$50",
                            Title = "Yellow boots"
                        },
                        new
                        {
                            Id = 14,
                            LinkUrl = "/images/placeholders/leatherbag270x295.jpg",
                            Price = "$65",
                            Title = "Leather bag"
                        },
                        new
                        {
                            Id = 15,
                            LinkUrl = "/images/placeholders/orangeshirt270x295.jpg",
                            Price = "$20",
                            Title = "Orange shirt"
                        },
                        new
                        {
                            Id = 16,
                            LinkUrl = "/images/placeholders/hat270x295.jpg",
                            Price = "$25",
                            Title = "Hat timeless"
                        },
                        new
                        {
                            Id = 17,
                            LinkUrl = "/images/placeholders/sunglasses270x295.jpg",
                            Price = "$60",
                            Title = "Sunglasses retro"
                        },
                        new
                        {
                            Id = 18,
                            LinkUrl = "/images/placeholders/earbuds270x295.jpg",
                            Price = "$120",
                            Title = "Earbuds with red case"
                        },
                        new
                        {
                            Id = 19,
                            LinkUrl = "/images/placeholders/dreheadphones270x295.jpg",
                            Price = "$95",
                            Title = "Headphones by Dre"
                        });
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.UserAddressEntity", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("UserAdresses");
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c59eef42-0d80-437c-a387-dfd0685f11e2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6a4a7b30-a849-4c64-a03d-0ad65fb25b28",
                            Email = "admin@bmerketo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@BMERKETO.COM",
                            NormalizedUserName = "ADMIN@BMERKETO.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPDWu2mcHv3vFIPGx33wZJ/lcyKQxzwjCYnIvHHwjbStcd1Ab5u8qxna5xVdmtYAEA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "43ecbb39-1db8-4c34-9d3b-a7eb01875121",
                            TwoFactorEnabled = false,
                            UserName = "admin@bmerketo.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c59eef42-0d80-437c-a387-dfd0685f11e2",
                            ConcurrencyStamp = "d8c88bf8-c099-4b96-8a2e-ccaff2963ce4",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5e1ad513-cac9-46ef-92e8-fb55b53f7387",
                            ConcurrencyStamp = "af43a2f7-bbf9-4a91-bd3e-b383ad0550fe",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "c59eef42-0d80-437c-a387-dfd0685f11e2",
                            RoleId = "c59eef42-0d80-437c-a387-dfd0685f11e2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.ProductCategoryEntity", b =>
                {
                    b.HasOne("Inlamningsuppgift_6.Models.Entities.CategoryEntity", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inlamningsuppgift_6.Models.Entities.ProductEntity", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.UserAddressEntity", b =>
                {
                    b.HasOne("Inlamningsuppgift_6.Models.Entities.AddressEntity", "Address")
                        .WithMany("Users")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inlamningsuppgift_6.Models.Entities.UserEntity", "User")
                        .WithMany("Users")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Inlamningsuppgift_6.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Inlamningsuppgift_6.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inlamningsuppgift_6.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Inlamningsuppgift_6.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.AddressEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.CategoryEntity", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.ProductEntity", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Inlamningsuppgift_6.Models.Entities.UserEntity", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}