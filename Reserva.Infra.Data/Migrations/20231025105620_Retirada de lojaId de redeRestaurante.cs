using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class RetiradadelojaIdderedeRestaurante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loja_RedeRestaurante_RedeRestauranteId",
                table: "Loja");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_RedeRestaurante_LojaId",
                table: "RedeRestaurante");

            migrationBuilder.DropColumn(
                name: "LojaId",
                table: "RedeRestaurante");

            migrationBuilder.AlterColumn<int>(
                name: "RedeRestauranteId",
                table: "Loja",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Loja_RedeRestaurante_RedeRestauranteId",
                table: "Loja",
                column: "RedeRestauranteId",
                principalTable: "RedeRestaurante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loja_RedeRestaurante_RedeRestauranteId",
                table: "Loja");

            migrationBuilder.AddColumn<int>(
                name: "LojaId",
                table: "RedeRestaurante",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RedeRestauranteId",
                table: "Loja",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_RedeRestaurante_LojaId",
                table: "RedeRestaurante",
                column: "LojaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loja_RedeRestaurante_RedeRestauranteId",
                table: "Loja",
                column: "RedeRestauranteId",
                principalTable: "RedeRestaurante",
                principalColumn: "LojaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
