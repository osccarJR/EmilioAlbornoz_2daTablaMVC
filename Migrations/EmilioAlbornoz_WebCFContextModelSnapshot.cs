﻿// <auto-generated />
using System;
using EmilioAlbornoz_WebCF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmilioAlbornoz_WebCF.Migrations
{
    [DbContext(typeof(EmilioAlbornoz_WebCFContext))]
    partial class EmilioAlbornoz_WebCFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmilioAlbornoz_WebCF.Models.Burger", b =>
                {
                    b.Property<int>("BurgerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BurgerID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithCheese")
                        .HasColumnType("bit");

                    b.HasKey("BurgerID");

                    b.ToTable("Burger");
                });

            modelBuilder.Entity("EmilioAlbornoz_WebCF.Models.Promo", b =>
                {
                    b.Property<int>("PromoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromoID"));

                    b.Property<DateTime>("BurgerID")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BurgerID1")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PromoID");

                    b.HasIndex("BurgerID1");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("EmilioAlbornoz_WebCF.Models.Promo", b =>
                {
                    b.HasOne("EmilioAlbornoz_WebCF.Models.Burger", "Burger")
                        .WithMany("Promo")
                        .HasForeignKey("BurgerID1");

                    b.Navigation("Burger");
                });

            modelBuilder.Entity("EmilioAlbornoz_WebCF.Models.Burger", b =>
                {
                    b.Navigation("Promo");
                });
#pragma warning restore 612, 618
        }
    }
}
