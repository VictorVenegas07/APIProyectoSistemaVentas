﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVenta.DAL.DBContext;

#nullable disable

namespace SistemaVenta.DAL.Migrations
{
    [DbContext(typeof(BdventaContext))]
    partial class BdventaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SistemaVenta.Model.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("EsActivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria_Venta_bd", (string)null);
                });

            modelBuilder.Entity("SistemaVenta.Model.DetallesVenta", b =>
                {
                    b.Property<int>("IdDetalleVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("IdProductoNavigationIdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("IdVenta")
                        .HasColumnType("int");

                    b.Property<int?>("IdVentaNavigationIdVenta")
                        .HasColumnType("int");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("IdDetalleVenta");

                    b.HasIndex("IdProductoNavigationIdProducto");

                    b.HasIndex("IdVentaNavigationIdVenta");

                    b.ToTable("DetallesVenta");
                });

            modelBuilder.Entity("SistemaVenta.Model.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Icono")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("IdMenu");

                    b.ToTable("Menu_Venta", (string)null);
                });

            modelBuilder.Entity("SistemaVenta.Model.MenuRol", b =>
                {
                    b.Property<int>("IdMenuRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("IdMenu")
                        .HasColumnType("int");

                    b.Property<int?>("IdMenuNavigationIdMenu")
                        .HasColumnType("int");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int");

                    b.Property<int?>("IdRolNavigationIdRol")
                        .HasColumnType("int");

                    b.HasKey("IdMenuRol");

                    b.HasIndex("IdMenuNavigationIdMenu");

                    b.HasIndex("IdRolNavigationIdRol");

                    b.ToTable("MenuRol_Venta", (string)null);
                });

            modelBuilder.Entity("SistemaVenta.Model.NumeroDocumento", b =>
                {
                    b.Property<int>("IdNumeroDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UltimoNumero")
                        .HasColumnType("int");

                    b.HasKey("IdNumeroDocumento");

                    b.ToTable("NumeroDocumento_Venta", (string)null);
                });

            modelBuilder.Entity("SistemaVenta.Model.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("EsActivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int?>("IdCategoriaNavigationIdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.HasIndex("IdCategoriaNavigationIdCategoria");

                    b.ToTable("Producto_Venta", (string)null);
                });

            modelBuilder.Entity("SistemaVenta.Model.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("IdRol");

                    b.ToTable("Rol_Venta", (string)null);
                });

            modelBuilder.Entity("SistemaVenta.Model.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Clave")
                        .HasColumnType("longtext");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext");

                    b.Property<bool?>("EsActivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int");

                    b.Property<int?>("IdRolNavigationIdRol")
                        .HasColumnType("int");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("longtext");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdRolNavigationIdRol");

                    b.ToTable("Usuario_Venta", (string)null);
                });

            modelBuilder.Entity("SistemaVenta.Model.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("longtext");

                    b.Property<string>("TipoPago")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("IdVenta");

                    b.ToTable("Venta_Venta", (string)null);
                });

            modelBuilder.Entity("SistemaVenta.Model.DetallesVenta", b =>
                {
                    b.HasOne("SistemaVenta.Model.Producto", "IdProductoNavigation")
                        .WithMany("DetallesVenta")
                        .HasForeignKey("IdProductoNavigationIdProducto");

                    b.HasOne("SistemaVenta.Model.Venta", "IdVentaNavigation")
                        .WithMany("DetallesVenta")
                        .HasForeignKey("IdVentaNavigationIdVenta");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdVentaNavigation");
                });

            modelBuilder.Entity("SistemaVenta.Model.MenuRol", b =>
                {
                    b.HasOne("SistemaVenta.Model.Menu", "IdMenuNavigation")
                        .WithMany("MenuRols")
                        .HasForeignKey("IdMenuNavigationIdMenu");

                    b.HasOne("SistemaVenta.Model.Rol", "IdRolNavigation")
                        .WithMany("MenuRols")
                        .HasForeignKey("IdRolNavigationIdRol");

                    b.Navigation("IdMenuNavigation");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("SistemaVenta.Model.Producto", b =>
                {
                    b.HasOne("SistemaVenta.Model.Categoria", "IdCategoriaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdCategoriaNavigationIdCategoria");

                    b.Navigation("IdCategoriaNavigation");
                });

            modelBuilder.Entity("SistemaVenta.Model.Usuario", b =>
                {
                    b.HasOne("SistemaVenta.Model.Rol", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRolNavigationIdRol");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("SistemaVenta.Model.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("SistemaVenta.Model.Menu", b =>
                {
                    b.Navigation("MenuRols");
                });

            modelBuilder.Entity("SistemaVenta.Model.Producto", b =>
                {
                    b.Navigation("DetallesVenta");
                });

            modelBuilder.Entity("SistemaVenta.Model.Rol", b =>
                {
                    b.Navigation("MenuRols");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SistemaVenta.Model.Venta", b =>
                {
                    b.Navigation("DetallesVenta");
                });
#pragma warning restore 612, 618
        }
    }
}