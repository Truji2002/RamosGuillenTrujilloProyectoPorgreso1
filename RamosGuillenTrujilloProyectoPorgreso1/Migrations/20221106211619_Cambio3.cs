﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RamosGuillenTrujilloProyectoPorgreso1.Migrations
{
    public partial class Cambio3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdCliente",
                table: "Reserva",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Cliente_IdCliente",
                table: "Reserva",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Cliente_IdCliente",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IdCliente",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Reserva");
        }
    }
}
