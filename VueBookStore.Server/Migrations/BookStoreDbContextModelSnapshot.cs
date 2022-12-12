﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VueBookStore.Server.EF;

#nullable disable

namespace VueBookStore.Server.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    partial class BookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorCardBookCard", b =>
                {
                    b.Property<Guid>("AuthorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BooksId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorCardBookCard");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Author.Models.AuthorCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronimic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Manufacturer.Models.ManufacturerCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Order.Models.OrderCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronimic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Product.Models.ProductCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CoverImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ManufacturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("NewPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OldPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rating")
                        .HasPrecision(3, 2)
                        .HasColumnType("decimal(3,2)");

                    b.Property<DateTime>("ReceiptDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCard");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProductCard");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Shop.Models.CartLine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("OrderCardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderCardId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Product.Models.BookCard", b =>
                {
                    b.HasBaseType("VueBookStore.Server.Areas.Product.Models.ProductCard");

                    b.Property<int>("BookTypes")
                        .HasColumnType("int");

                    b.Property<int>("Genres")
                        .HasColumnType("int");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("ProductCard");

                    b.HasDiscriminator().HasValue("BookCard");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Product.Models.StationeryCard", b =>
                {
                    b.HasBaseType("VueBookStore.Server.Areas.Product.Models.ProductCard");

                    b.Property<int>("StationeryType")
                        .HasColumnType("int");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("ProductCard");

                    b.HasDiscriminator().HasValue("StationeryCard");
                });

            modelBuilder.Entity("AuthorCardBookCard", b =>
                {
                    b.HasOne("VueBookStore.Server.Areas.Author.Models.AuthorCard", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VueBookStore.Server.Areas.Product.Models.BookCard", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Shop.Models.CartLine", b =>
                {
                    b.HasOne("VueBookStore.Server.Areas.Order.Models.OrderCard", null)
                        .WithMany("CartLines")
                        .HasForeignKey("OrderCardId");

                    b.HasOne("VueBookStore.Server.Areas.Product.Models.ProductCard", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Product.Models.BookCard", b =>
                {
                    b.HasOne("VueBookStore.Server.Areas.Manufacturer.Models.ManufacturerCard", "Manufacturer")
                        .WithMany("Books")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Product.Models.StationeryCard", b =>
                {
                    b.HasOne("VueBookStore.Server.Areas.Manufacturer.Models.ManufacturerCard", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Manufacturer.Models.ManufacturerCard", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("VueBookStore.Server.Areas.Order.Models.OrderCard", b =>
                {
                    b.Navigation("CartLines");
                });
#pragma warning restore 612, 618
        }
    }
}
