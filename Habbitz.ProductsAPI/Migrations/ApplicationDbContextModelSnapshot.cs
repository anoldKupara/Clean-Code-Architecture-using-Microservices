﻿// <auto-generated />
using Habbitz.ProductsAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Habbitz.ProductsAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Habbitz.ProductsAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Appetizer",
                            Description = "A product made of flour and meat or potatoes",
                            ImageUrl = "https://drive.google.com/file/d/1lBr9BJIXaoc-aICwwhFjI4hu3gO4R_W4/view?usp=sharing",
                            Name = "Samosa",
                            Price = 5.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Appetizer",
                            Description = "To be added later",
                            ImageUrl = "https://drive.google.com/file/d/1PjE7OJWfOBQkAj-iwnF9hMD2sukfe8YV/view?usp=sharing",
                            Name = "Panner Tikka",
                            Price = 13.449999999999999
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Dessert",
                            Description = "To be added later",
                            ImageUrl = "https://drive.google.com/file/d/1H_jRrTvSAV-OXNe4NCMbYSlU87lMzAjd/view?usp=sharing",
                            Name = "Sweet Pie",
                            Price = 10.99
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryName = "Dessert",
                            Description = "To be added laterr",
                            ImageUrl = "https://drive.google.com/file/d/12UVuU89klgzU62yTyaE4NdKrflGM7uOn/view?usp=sharing",
                            Name = "Ice Cream",
                            Price = 2.6699999999999999
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryName = "Dessert",
                            Description = "A fancy dessert",
                            ImageUrl = "https://drive.google.com/file/d/12Z9dQ70racP7RMuVfZ51VP1mrCZlLsj9/view?usp=sharing",
                            Name = "Gelato",
                            Price = 8.1600000000000001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
