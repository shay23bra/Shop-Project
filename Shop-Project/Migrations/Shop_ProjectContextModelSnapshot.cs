﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop_Project.Data;

namespace Shop_Project.Migrations
{
    [DbContext(typeof(Shop_ProjectContext))]
    partial class Shop_ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccessoryConsole", b =>
                {
                    b.Property<int>("accessoriesId")
                        .HasColumnType("int");

                    b.Property<int>("consolesId")
                        .HasColumnType("int");

                    b.HasKey("accessoriesId", "consolesId");

                    b.HasIndex("consolesId");

                    b.ToTable("AccessoryConsole");
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("gamesId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "gamesId");

                    b.HasIndex("gamesId");

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("Shop_Project.Models.Accessory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<string>("trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("Accessory");
                });

            modelBuilder.Entity("Shop_Project.Models.Console", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConsoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<string>("trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("Console");
                });

            modelBuilder.Entity("Shop_Project.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConsoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<string>("trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsoleId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Shop_Project.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Shop_Project.Models.GenreImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId")
                        .IsUnique();

                    b.ToTable("GenreImage");
                });

            modelBuilder.Entity("Shop_Project.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Shop_Project.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AccessoryConsole", b =>
                {
                    b.HasOne("Shop_Project.Models.Accessory", null)
                        .WithMany()
                        .HasForeignKey("accessoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop_Project.Models.Console", null)
                        .WithMany()
                        .HasForeignKey("consolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.HasOne("Shop_Project.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop_Project.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("gamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop_Project.Models.Accessory", b =>
                {
                    b.HasOne("Shop_Project.Models.ShoppingCart", null)
                        .WithMany("accessoriesInCart")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("Shop_Project.Models.Console", b =>
                {
                    b.HasOne("Shop_Project.Models.ShoppingCart", null)
                        .WithMany("consolesInCart")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("Shop_Project.Models.Game", b =>
                {
                    b.HasOne("Shop_Project.Models.Console", null)
                        .WithMany("games")
                        .HasForeignKey("ConsoleId");

                    b.HasOne("Shop_Project.Models.ShoppingCart", null)
                        .WithMany("gamesInCart")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("Shop_Project.Models.GenreImage", b =>
                {
                    b.HasOne("Shop_Project.Models.Genre", "Genre")
                        .WithOne("GenreImage")
                        .HasForeignKey("Shop_Project.Models.GenreImage", "GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Shop_Project.Models.Console", b =>
                {
                    b.Navigation("games");
                });

            modelBuilder.Entity("Shop_Project.Models.Genre", b =>
                {
                    b.Navigation("GenreImage");
                });

            modelBuilder.Entity("Shop_Project.Models.ShoppingCart", b =>
                {
                    b.Navigation("accessoriesInCart");

                    b.Navigation("consolesInCart");

                    b.Navigation("gamesInCart");
                });
#pragma warning restore 612, 618
        }
    }
}
