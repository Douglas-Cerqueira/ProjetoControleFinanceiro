using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoControleFinanceiro.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoRelacaoCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacoes_Categorias_CategoriasModelIdCategoria",
                table: "Transacoes");

            migrationBuilder.DropIndex(
                name: "IX_Transacoes_CategoriasModelIdCategoria",
                table: "Transacoes");

            migrationBuilder.DropColumn(
                name: "CategoriasModelIdCategoria",
                table: "Transacoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriasModelIdCategoria",
                table: "Transacoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_CategoriasModelIdCategoria",
                table: "Transacoes",
                column: "CategoriasModelIdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacoes_Categorias_CategoriasModelIdCategoria",
                table: "Transacoes",
                column: "CategoriasModelIdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria");
        }
    }
}
