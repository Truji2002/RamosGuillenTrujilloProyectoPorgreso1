using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RamosGuillenTrujilloProyectoPorgreso1.Migrations
{
    public partial class Cambio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Reserva_IdCliente",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Conductor_Ruta_IdConductor",
                table: "Conductor");

            migrationBuilder.DropForeignKey(
                name: "FK_Conductor_Transporte_IdConductor",
                table: "Conductor");

            migrationBuilder.DropColumn(
                name: "IdRuta",
                table: "Conductor");

            migrationBuilder.DropColumn(
                name: "IdTransporte",
                table: "Conductor");

            migrationBuilder.DropColumn(
                name: "idReserva",
                table: "Cliente");

            migrationBuilder.AlterColumn<int>(
                name: "IdConductor",
                table: "Conductor",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "IdCliente",
                table: "Cliente",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdConductor",
                table: "Conductor",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdRuta",
                table: "Conductor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTransporte",
                table: "Conductor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IdCliente",
                table: "Cliente",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "idReserva",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Reserva_IdCliente",
                table: "Cliente",
                column: "IdCliente",
                principalTable: "Reserva",
                principalColumn: "IdReserva",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conductor_Ruta_IdConductor",
                table: "Conductor",
                column: "IdConductor",
                principalTable: "Ruta",
                principalColumn: "IdRuta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conductor_Transporte_IdConductor",
                table: "Conductor",
                column: "IdConductor",
                principalTable: "Transporte",
                principalColumn: "IdTransporte",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
