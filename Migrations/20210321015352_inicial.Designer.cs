﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Registro.DAL;

namespace Proyecto_Registro.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210321015352_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Proyecto_Registro.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DetallePermiso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PermisosId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("vecesAcignada")
                        .HasColumnType("INTEGER");

                    b.HasKey("PermisoId");

                    b.HasIndex("PermisosId");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisoId = 1,
                            DetallePermiso = "Descuento",
                            vecesAcignada = false
                        },
                        new
                        {
                            PermisoId = 2,
                            DetallePermiso = "Venta",
                            vecesAcignada = false
                        },
                        new
                        {
                            PermisoId = 3,
                            DetallePermiso = "Cobrar",
                            vecesAcignada = false
                        });
                });

            modelBuilder.Entity("Proyecto_Registro.Entidades.Roles", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("esActivo")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Proyecto_Registro.Entidades.RolesDetalles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("esAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RolID");

                    b.ToTable("RolesDetalles");
                });

            modelBuilder.Entity("Proyecto_Registro.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Proyecto_Registro.Entidades.Permisos", b =>
                {
                    b.HasOne("Proyecto_Registro.Entidades.Permisos", "permisos")
                        .WithMany()
                        .HasForeignKey("PermisosId");

                    b.Navigation("permisos");
                });

            modelBuilder.Entity("Proyecto_Registro.Entidades.RolesDetalles", b =>
                {
                    b.HasOne("Proyecto_Registro.Entidades.Roles", null)
                        .WithMany("Detalles")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_Registro.Entidades.Roles", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}