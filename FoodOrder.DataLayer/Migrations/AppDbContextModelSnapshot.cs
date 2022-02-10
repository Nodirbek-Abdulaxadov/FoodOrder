﻿// <auto-generated />
using System;
using FoodOrder.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FoodOrder.DataLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("FoodOrder.Models.Kategoriya", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nomi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Kategoriyalar");
                });

            modelBuilder.Entity("FoodOrder.Models.Mahsulot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Batafsil")
                        .HasColumnType("text");

                    b.Property<Guid>("KategoriyaId")
                        .HasColumnType("uuid");

                    b.Property<double>("Narxi")
                        .HasColumnType("double precision");

                    b.Property<string>("Nomi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Rasmi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("KategoriyaId");

                    b.HasIndex("UserId");

                    b.ToTable("Mahsulotlar");
                });

            modelBuilder.Entity("FoodOrder.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FISH")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Manzil")
                        .HasColumnType("text");

                    b.Property<string>("Nomer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodOrder.Models.Mahsulot", b =>
                {
                    b.HasOne("FoodOrder.Models.Kategoriya", null)
                        .WithMany("Mahsulotlar")
                        .HasForeignKey("KategoriyaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodOrder.Models.User", null)
                        .WithMany("Savatcha")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FoodOrder.Models.Kategoriya", b =>
                {
                    b.Navigation("Mahsulotlar");
                });

            modelBuilder.Entity("FoodOrder.Models.User", b =>
                {
                    b.Navigation("Savatcha");
                });
#pragma warning restore 612, 618
        }
    }
}
