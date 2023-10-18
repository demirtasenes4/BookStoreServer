﻿// <auto-generated />
using System;
using BookStoreServer.WebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreServer.WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStoreServer.WebApi.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookStoreServer.WebApi.Models.BookCategory", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("BookStoreServer.WebApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Science-Fiction"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "History"
                        },
                        new
                        {
                            Id = 4,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Literature"
                        },
                        new
                        {
                            Id = 5,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Kids"
                        },
                        new
                        {
                            Id = 6,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Psychology"
                        },
                        new
                        {
                            Id = 7,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Technology"
                        },
                        new
                        {
                            Id = 8,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Philosophy"
                        },
                        new
                        {
                            Id = 9,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Science"
                        },
                        new
                        {
                            Id = 10,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Art"
                        },
                        new
                        {
                            Id = 11,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 12,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Travel"
                        },
                        new
                        {
                            Id = 13,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Magazine"
                        },
                        new
                        {
                            Id = 14,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Humour"
                        },
                        new
                        {
                            Id = 15,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Self-Improvement"
                        },
                        new
                        {
                            Id = 16,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "World-Cuisines"
                        },
                        new
                        {
                            Id = 17,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Hobby"
                        },
                        new
                        {
                            Id = 18,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Reference"
                        },
                        new
                        {
                            Id = 19,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Education"
                        },
                        new
                        {
                            Id = 20,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Games"
                        });
                });

            modelBuilder.Entity("BookStoreServer.WebApi.Models.Book", b =>
                {
                    b.OwnsOne("BookStoreServer.WebApi.ValueObjects.Money", "Price", b1 =>
                        {
                            b1.Property<int>("BookId")
                                .HasColumnType("int");

                            b1.Property<string>("Currency")
                                .IsRequired()
                                .HasMaxLength(5)
                                .HasColumnType("nvarchar(5)");

                            b1.Property<decimal>("Value")
                                .HasColumnType("money");

                            b1.HasKey("BookId");

                            b1.ToTable("Books");

                            b1.WithOwner()
                                .HasForeignKey("BookId");
                        });

                    b.Navigation("Price")
                        .IsRequired();
                });

            modelBuilder.Entity("BookStoreServer.WebApi.Models.BookCategory", b =>
                {
                    b.HasOne("BookStoreServer.WebApi.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStoreServer.WebApi.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
