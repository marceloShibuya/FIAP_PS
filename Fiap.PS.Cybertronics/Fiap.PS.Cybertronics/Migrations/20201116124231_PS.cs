using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.PS.Cybertronics.Migrations
{
    public partial class PS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUTO_TB_CLIENTE_ClienteId",
                table: "TB_PRODUTO");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "TB_PRODUTO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUTO_TB_CLIENTE_ClienteId",
                table: "TB_PRODUTO",
                column: "ClienteId",
                principalTable: "TB_CLIENTE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUTO_TB_CLIENTE_ClienteId",
                table: "TB_PRODUTO");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "TB_PRODUTO",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUTO_TB_CLIENTE_ClienteId",
                table: "TB_PRODUTO",
                column: "ClienteId",
                principalTable: "TB_CLIENTE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
