﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoraMauricio_ExameProgreso1.Data;

#nullable disable

namespace MoraMauricio_ExameProgreso1.Migrations
{
    [DbContext(typeof(MoraMauricio_ExameProgreso1Context))]
    [Migration("20241029132724_Migracion2")]
    partial class Migracion2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MoraMauricio_ExameProgreso1.Models.Celular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<int>("MMoraId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio")
                        .HasMaxLength(100)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MMoraId")
                        .IsUnique();

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("MoraMauricio_ExameProgreso1.Models.MMora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("Edad")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario")
                        .HasMaxLength(150)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("MMora");
                });

            modelBuilder.Entity("MoraMauricio_ExameProgreso1.Models.Celular", b =>
                {
                    b.HasOne("MoraMauricio_ExameProgreso1.Models.MMora", "EArmas")
                        .WithOne("Celular")
                        .HasForeignKey("MoraMauricio_ExameProgreso1.Models.Celular", "MMoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EArmas");
                });

            modelBuilder.Entity("MoraMauricio_ExameProgreso1.Models.MMora", b =>
                {
                    b.Navigation("Celular")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
