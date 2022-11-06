using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RamosGuillenTrujilloProyectoPorgreso1.Migrations
{
    public partial class Cambio5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Cliente_IdCliente",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Ruta_IdRuta",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IdCliente",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IdRuta",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IdRuta",
                table: "Reserva");

            migrationBuilder.AddColumn<int>(
                name: "RutaIdRuta",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_RutaIdRuta",
                table: "Reserva",
                column: "RutaIdRuta");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Ruta_RutaIdRuta",
                table: "Reserva",
                column: "RutaIdRuta",
                principalTable: "Ruta",
                principalColumn: "IdRuta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Ruta_RutaIdRuta",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_RutaIdRuta",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "RutaIdRuta",
                table: "Reserva");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRuta",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdCliente",
                table: "Reserva",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdRuta",
                table: "Reserva",
                column: "IdRuta");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Cliente_IdCliente",
                table: "Reserva",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Ruta_IdRuta",
                table: "Reserva",
                column: "IdRuta",
                principalTable: "Ruta",
                principalColumn: "IdRuta",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
