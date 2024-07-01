﻿// <auto-generated />
using DataBaseAndClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataBaseAndClasses.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240701124548_newMig")]
    partial class newMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataBaseAndClasses.Insan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Insanlar");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Insan");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DataBaseAndClasses.Kitab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Janr")
                        .HasColumnType("int");

                    b.Property<double>("Qiymet")
                        .HasColumnType("float");

                    b.Property<int>("SehifeSayi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kitablar");
                });

            modelBuilder.Entity("DataBaseAndClasses.Muellim", b =>
                {
                    b.HasBaseType("DataBaseAndClasses.Insan");

                    b.Property<int>("Maas")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Muellim");
                });
#pragma warning restore 612, 618
        }
    }
}
