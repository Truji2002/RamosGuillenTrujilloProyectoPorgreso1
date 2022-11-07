using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RamosGuillenTrujilloProyectoPorgreso1.Migrations
{
    public partial class MyMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ruta",
                columns: table => new
                {
                    IdRuta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEmisionLicencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimientoLicencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuntoLlegada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta", x => x.IdRuta);
                });

            migrationBuilder.CreateTable(
                name: "Transporte",
                columns: table => new
                {
                    IdTransporte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transporte", x => x.IdTransporte);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ruta");

            migrationBuilder.DropTable(
                name: "Transporte");
        }
    }
}
