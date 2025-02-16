﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AQAutosMVC.Migrations
{
    [DbContext(typeof(AQAutosContext))]
    [Migration("20241127225346_CambiosBdd")]
    partial class CambiosBdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AQAutosMVC.Models.AQAuto", b =>
                {
                    b.Property<int>("AQAutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AQAutoID"));

                    b.Property<int>("AQAnio")
                        .HasColumnType("int");

                    b.Property<string>("AQCombustible")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("AQFechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("AQMarca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("AQPrecio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("AQUsado")
                        .HasColumnType("bit");

                    b.Property<string>("AqEmaildistribuidor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AQAutoID");

                    b.ToTable("AQAuto");
                });
#pragma warning restore 612, 618
        }
    }
}
