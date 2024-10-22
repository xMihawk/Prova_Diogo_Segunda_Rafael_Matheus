using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rafaelaloncofoggiatto.Migrations
{
    /// <inheritdoc />
    public partial class tcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Funcionarios",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Funcionarios",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Funcionarios",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "funcionarioId",
                table: "Folhas",
                newName: "funcId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Funcionarios",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Funcionarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Funcionarios",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "funcId",
                table: "Folhas",
                newName: "funcionarioId");
        }
    }
}
