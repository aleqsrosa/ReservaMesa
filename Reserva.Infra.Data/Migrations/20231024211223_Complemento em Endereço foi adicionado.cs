using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class ComplementoemEndereçofoiadicionado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Cliente_ClienteId1",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_ClienteId1",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Reserva");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Loja",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Loja");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId1",
                table: "Reserva",
                type: "INT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ClienteId1",
                table: "Reserva",
                column: "ClienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Cliente_ClienteId1",
                table: "Reserva",
                column: "ClienteId1",
                principalTable: "Cliente",
                principalColumn: "Id");
        }
    }
}
