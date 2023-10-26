using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVenta.DAL.Migrations
{
    /// <inheritdoc />
    public partial class firtsmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria_Venta_bd",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EsActivo = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria_Venta_bd", x => x.IdCategoria);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Menu_Venta",
                columns: table => new
                {
                    IdMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Icono = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu_Venta", x => x.IdMenu);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NumeroDocumento_Venta",
                columns: table => new
                {
                    IdNumeroDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UltimoNumero = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumeroDocumento_Venta", x => x.IdNumeroDocumento);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol_Venta",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol_Venta", x => x.IdRol);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Venta_Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroDocumento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPago = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta_Venta", x => x.IdVenta);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Producto_Venta",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCategoria = table.Column<int>(type: "int", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    EsActivo = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdCategoriaNavigationIdCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto_Venta", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Producto_Venta_Categoria_Venta_bd_IdCategoriaNavigationIdCat~",
                        column: x => x.IdCategoriaNavigationIdCategoria,
                        principalTable: "Categoria_Venta_bd",
                        principalColumn: "IdCategoria");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MenuRol_Venta",
                columns: table => new
                {
                    IdMenuRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMenu = table.Column<int>(type: "int", nullable: true),
                    IdRol = table.Column<int>(type: "int", nullable: true),
                    IdMenuNavigationIdMenu = table.Column<int>(type: "int", nullable: true),
                    IdRolNavigationIdRol = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRol_Venta", x => x.IdMenuRol);
                    table.ForeignKey(
                        name: "FK_MenuRol_Venta_Menu_Venta_IdMenuNavigationIdMenu",
                        column: x => x.IdMenuNavigationIdMenu,
                        principalTable: "Menu_Venta",
                        principalColumn: "IdMenu");
                    table.ForeignKey(
                        name: "FK_MenuRol_Venta_Rol_Venta_IdRolNavigationIdRol",
                        column: x => x.IdRolNavigationIdRol,
                        principalTable: "Rol_Venta",
                        principalColumn: "IdRol");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario_Venta",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCompleto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdRol = table.Column<int>(type: "int", nullable: true),
                    Clave = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EsActivo = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdRolNavigationIdRol = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario_Venta", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Venta_Rol_Venta_IdRolNavigationIdRol",
                        column: x => x.IdRolNavigationIdRol,
                        principalTable: "Rol_Venta",
                        principalColumn: "IdRol");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetallesVenta",
                columns: table => new
                {
                    IdDetalleVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdVenta = table.Column<int>(type: "int", nullable: true),
                    IdProducto = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    IdProductoNavigationIdProducto = table.Column<int>(type: "int", nullable: true),
                    IdVentaNavigationIdVenta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesVenta", x => x.IdDetalleVenta);
                    table.ForeignKey(
                        name: "FK_DetallesVenta_Producto_Venta_IdProductoNavigationIdProducto",
                        column: x => x.IdProductoNavigationIdProducto,
                        principalTable: "Producto_Venta",
                        principalColumn: "IdProducto");
                    table.ForeignKey(
                        name: "FK_DetallesVenta_Venta_Venta_IdVentaNavigationIdVenta",
                        column: x => x.IdVentaNavigationIdVenta,
                        principalTable: "Venta_Venta",
                        principalColumn: "IdVenta");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesVenta_IdProductoNavigationIdProducto",
                table: "DetallesVenta",
                column: "IdProductoNavigationIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesVenta_IdVentaNavigationIdVenta",
                table: "DetallesVenta",
                column: "IdVentaNavigationIdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRol_Venta_IdMenuNavigationIdMenu",
                table: "MenuRol_Venta",
                column: "IdMenuNavigationIdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRol_Venta_IdRolNavigationIdRol",
                table: "MenuRol_Venta",
                column: "IdRolNavigationIdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Venta_IdCategoriaNavigationIdCategoria",
                table: "Producto_Venta",
                column: "IdCategoriaNavigationIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Venta_IdRolNavigationIdRol",
                table: "Usuario_Venta",
                column: "IdRolNavigationIdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesVenta");

            migrationBuilder.DropTable(
                name: "MenuRol_Venta");

            migrationBuilder.DropTable(
                name: "NumeroDocumento_Venta");

            migrationBuilder.DropTable(
                name: "Usuario_Venta");

            migrationBuilder.DropTable(
                name: "Producto_Venta");

            migrationBuilder.DropTable(
                name: "Venta_Venta");

            migrationBuilder.DropTable(
                name: "Menu_Venta");

            migrationBuilder.DropTable(
                name: "Rol_Venta");

            migrationBuilder.DropTable(
                name: "Categoria_Venta_bd");
        }
    }
}
