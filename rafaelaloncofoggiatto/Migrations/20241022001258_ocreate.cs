using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rafaelaloncofoggiatto.Migrations
{
    /// <inheritdoc />
    public partial class ocreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folhas_Funcionarios_funcionarioIdid",
                table: "Folhas");

            migrationBuilder.DropIndex(
                name: "IX_Folhas_funcionarioIdid",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "funcionarioIdid",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Funcionarios",
                newName: "funcionarioId");

            migrationBuilder.AddColumn<int>(
                name: "funcionarioId",
                table: "Folhas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Folhas_funcionarioId",
                table: "Folhas",
                column: "funcionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Folhas_Funcionarios_funcionarioId",
                table: "Folhas",
                column: "funcionarioId",
                principalTable: "Funcionarios",
                principalColumn: "funcionarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folhas_Funcionarios_funcionarioId",
                table: "Folhas");

            migrationBuilder.DropIndex(
                name: "IX_Folhas_funcionarioId",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "funcionarioId",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "funcionarioId",
                table: "Funcionarios",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "funcionarioIdid",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
    }
}
