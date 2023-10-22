using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemocaodoIddoEndereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loja_Endereco_EnderecoId",
                table: "Loja");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Loja_EnderecoId",
                table: "Loja");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId1",
                table: "Reserva",
                type: "INT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Loja",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Loja",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Loja",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Loja",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Loja",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Loja",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Loja");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Loja");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Loja");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Loja");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Loja");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Loja",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bairro = table.Column<string>(type: "Varchar(50)", nullable: false),
                    CEP = table.Column<string>(type: "Varchar(8)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LojaId = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "INT", nullable: false),
                    Rua = table.Column<string>(type: "Varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loja_EnderecoId",
                table: "Loja",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loja_Endereco_EnderecoId",
                table: "Loja",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
