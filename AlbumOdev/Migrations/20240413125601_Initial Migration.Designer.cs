﻿// <auto-generated />
using AlbumOdev.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlbumOdev.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240413125601_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlbumOdev.Models.MAlbum", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumID"));

                    b.Property<string>("AlbumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AlbumFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AlbumNo")
                        .HasColumnType("int");

                    b.Property<string>("AlbumTur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanatciBilgi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Yerli")
                        .HasColumnType("bit");

                    b.HasKey("AlbumID");

                    b.ToTable("Album");
                });
#pragma warning restore 612, 618
        }
    }
}