using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rafaelaloncofoggiatto.Migrations
{
    /// <inheritdoc />
    public partial class gcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "funcId",
                table: "Folhas",
                newName: "funcionarioIdid");

            migrationBuilder.CreateIndex(
                name: "IX_Folhas_funcionarioIdid",
                table: "Folhas",
                column: "funcionarioIdid");

            migrationBuilder.AddForeignKey(
                name: "FK_Folhas_Funcionarios_funcionarioIdid",
                table: "Folhas",
                column: "funcionarioIdid",
                principalTable: "Funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folhas_Funcionarios_funcionarioIdid",
                table: "Folhas");

            migrationBuilder.DropIndex(
                name: "IX_Folhas_funcionarioIdid",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "funcionarioIdid",
                table: "Folhas",
                newName: "funcId");
        }
    }
}
