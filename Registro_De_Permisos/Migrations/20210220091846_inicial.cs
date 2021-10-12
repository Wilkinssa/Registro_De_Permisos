using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registro_De_Permisos.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    permisoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.permisoId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    rolesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    fechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    esActivo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.rolesId);
                });

            migrationBuilder.CreateTable(
                name: "RolesDetalle",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rolid = table.Column<int>(type: "INTEGER", nullable: false),
                    PermisoId = table.Column<int>(type: "INTEGER", nullable: false),
                    esAsignado = table.Column<bool>(type: "INTEGER", nullable: false),
                    rolesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesDetalle", x => x.id);
                    table.ForeignKey(
                        name: "FK_RolesDetalle_Roles_rolesId",
                        column: x => x.rolesId,
                        principalTable: "Roles",
                        principalColumn: "rolesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    Alias = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    RolId = table.Column<int>(type: "INTEGER", nullable: false),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false),
                    RolesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "rolesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "permisoId", "descripcion" },
                values: new object[] { 1, "Descuenta" });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "permisoId", "descripcion" },
                values: new object[] { 2, "Vende" });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "permisoId", "descripcion" },
                values: new object[] { 3, "Cobra" });

            migrationBuilder.CreateIndex(
                name: "IX_RolesDetalle_rolesId",
                table: "RolesDetalle",
                column: "rolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolesId",
                table: "Usuarios",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "RolesDetalle");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
