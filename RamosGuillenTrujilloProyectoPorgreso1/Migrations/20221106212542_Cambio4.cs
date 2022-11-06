using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RamosGuillenTrujilloProyectoPorgreso1.Migrations
{
    public partial class Cambio4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdConductor",
                table: "Transporte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdConductor",
                table: "Ruta",
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
                name: "IX_Transporte_IdConductor",
                table: "Transporte",
                column: "IdConductor");

            migrationBuilder.CreateIndex(
                name: "IX_Ruta_IdConductor",
                table: "Ruta",
                column: "IdConductor");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdRuta",
                table: "Reserva",
                column: "IdRuta");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Ruta_IdRuta",
                table: "Reserva",
                column: "IdRuta",
                principalTable: "Ruta",
                principalColumn: "IdRuta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ruta_Conductor_IdConductor",
                table: "Ruta",
                column: "IdConductor",
                principalTable: "Conductor",
                principalColumn: "IdConductor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transporte_Conductor_IdConductor",
                table: "Transporte",
                column: "IdConductor",
                principalTable: "Conductor",
                principalColumn: "IdConductor",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Ruta_IdRuta",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Ruta_Conductor_IdConductor",
                table: "Ruta");

            migrationBuilder.DropForeignKey(
                name: "FK_Transporte_Conductor_IdConductor",
                table: "Transporte");

            migrationBuilder.DropIndex(
                name: "IX_Transporte_IdConductor",
                table: "Transporte");

            migrationBuilder.DropIndex(
                name: "IX_Ruta_IdConductor",
                table: "Ruta");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IdRuta",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IdConductor",
                table: "Transporte");

            migrationBuilder.DropColumn(
                name: "IdConductor",
                table: "Ruta");

            migrationBuilder.DropColumn(
                name: "IdRuta",
                table: "Reserva");
        }
    }
}
