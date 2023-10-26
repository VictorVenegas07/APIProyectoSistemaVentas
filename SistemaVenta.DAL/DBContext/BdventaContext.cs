using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.Model;

namespace SistemaVenta.DAL.DBContext;

public partial class BdventaContext : DbContext
{
    public BdventaContext(DbContextOptions<BdventaContext> options) : base(options)
    {
    }
    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<DetallesVenta> DetallesVenta { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuRol> MenuRols { get; set; }

    public virtual DbSet<NumeroDocumento> NumeroDocumentos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.ToTable("Categoria_Venta_bd");

            entity.HasKey(e => e.IdCategoria);
        });

        modelBuilder.Entity<DetallesVenta>(entity =>
        {
            entity.HasKey(e => e.IdDetalleVenta);
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("Menu_Venta");
            entity.HasKey(e => e.IdMenu);
        });

        modelBuilder.Entity<MenuRol>(entity =>
        {
            entity.ToTable("MenuRol_Venta");
            entity.HasKey(e => e.IdMenuRol);
        });

        modelBuilder.Entity<NumeroDocumento>(entity =>
        {
            entity.ToTable("NumeroDocumento_Venta");
            entity.HasKey(e => e.IdNumeroDocumento);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Producto_Venta");
            entity.HasKey(e => e.IdProducto);
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.ToTable("Rol_Venta");
            entity.HasKey(e => e.IdRol);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario_Venta");
            entity.HasKey(e => e.IdUsuario);
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.ToTable("Venta_Venta");
            entity.HasKey(e => e.IdVenta);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
