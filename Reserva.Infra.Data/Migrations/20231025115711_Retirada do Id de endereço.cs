using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class RetiradadoIddeendereço : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Loja");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Loja",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
