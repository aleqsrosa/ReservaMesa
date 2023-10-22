using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaçãodonomedecapacidadeparaqtdReservasemReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacidade",
                table: "Reserva",
                newName: "QTDReserva");

            migrationBuilder.AddColumn<int>(
                name: "CapacidadeTotal",
                table: "Loja",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapacidadeTotal",
                table: "Loja");

            migrationBuilder.RenameColumn(
                name: "QTDReserva",
                table: "Reserva",
                newName: "Capacidade");
        }
    }
}
