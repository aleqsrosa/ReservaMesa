using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicaoDoCampoTurno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Horario",
                table: "Reserva",
                newName: "Data");

            migrationBuilder.AddColumn<int>(
                name: "Turno",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Turno",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Reserva",
                newName: "Horario");
        }
    }
}
