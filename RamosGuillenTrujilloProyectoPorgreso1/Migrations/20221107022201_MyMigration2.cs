using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RamosGuillenTrujilloProyectoPorgreso1.Migrations
{
    public partial class MyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Conductor");

            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "Conductor");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Conductor");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Conductor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Conductor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "Conductor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Conductor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Conductor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
