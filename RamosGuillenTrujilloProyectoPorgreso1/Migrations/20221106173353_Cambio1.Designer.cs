﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RamosGuillenTrujilloProyectoPorgreso1.Data;

#nullable disable

namespace RamosGuillenTrujilloProyectoPorgreso1.Migrations
{
    [DbContext(typeof(RamosGuillenTrujilloProyectoPorgreso1Context))]
    [Migration("20221106173353_Cambio1")]
    partial class Cambio1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("idReserva")
                        .HasColumnType("int");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Conductor", b =>
                {
                    b.Property<int>("IdConductor")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaEmisionLicencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimientoLicencia")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdRuta")
                        .HasColumnType("int");

                    b.Property<int>("IdTransporte")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdConductor");

                    b.ToTable("Conductor");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReserva"), 1L, 1);

                    b.Property<int?>("CantPersonas")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPartida")
                        .HasColumnType("datetime2");

                    b.Property<string>("PuntoPartida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReserva");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Ruta", b =>
                {
                    b.Property<int>("IdRuta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRuta"), 1L, 1);

                    b.Property<DateTime>("FechaEmisionLicencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimientoLicencia")
                        .HasColumnType("datetime2");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("PuntoLlegada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRuta");

                    b.ToTable("Ruta");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Transporte", b =>
                {
                    b.Property<int>("IdTransporte")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTransporte"), 1L, 1);

                    b.Property<int?>("Capacidad")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTransporte");

                    b.ToTable("Transporte");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Cliente", b =>
                {
                    b.HasOne("RamosGuillenTrujilloProyectoPorgreso1.Models.Reserva", "Reserva")
                        .WithMany("Cliente")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Conductor", b =>
                {
                    b.HasOne("RamosGuillenTrujilloProyectoPorgreso1.Models.Ruta", "Ruta")
                        .WithMany("Conductor")
                        .HasForeignKey("IdConductor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RamosGuillenTrujilloProyectoPorgreso1.Models.Transporte", "Transporte")
                        .WithMany("Conductor")
                        .HasForeignKey("IdConductor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ruta");

                    b.Navigation("Transporte");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Reserva", b =>
                {
                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Ruta", b =>
                {
                    b.Navigation("Conductor");
                });

            modelBuilder.Entity("RamosGuillenTrujilloProyectoPorgreso1.Models.Transporte", b =>
                {
                    b.Navigation("Conductor");
                });
#pragma warning restore 612, 618
        }
    }
}
