﻿// <auto-generated />
using COmpStore.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace COmpStore.Schema.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COmpStore.Schema.Entities.CategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("COmpStore.Schema.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("MadeIn");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PublisherId");

                    b.Property<Guid?>("PublisherId1");

                    b.Property<int>("SubCategoryId");

                    b.Property<Guid?>("SubCategoryId1");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId1");

                    b.HasIndex("SubCategoryId1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("COmpStore.Schema.Entities.PublisherEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("COmpStore.Schema.Entities.SubCategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<Guid?>("CategoryId1");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId1");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("COmpStore.Schema.Entities.ProductEntity", b =>
                {
                    b.HasOne("COmpStore.Schema.Entities.PublisherEntity", "Publisher")
                        .WithMany("Products")
                        .HasForeignKey("PublisherId1");

                    b.HasOne("COmpStore.Schema.Entities.SubCategoryEntity", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId1");
                });

            modelBuilder.Entity("COmpStore.Schema.Entities.SubCategoryEntity", b =>
                {
                    b.HasOne("COmpStore.Schema.Entities.CategoryEntity", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId1");
                });
#pragma warning restore 612, 618
        }
    }
}
