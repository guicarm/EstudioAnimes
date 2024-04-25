using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudioAnimes.Migrations
{
    /// <inheritdoc />
    public partial class CreateFuncionarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "98874_Funcionario",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Cargo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Salario = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    Idade = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_98874_Funcionario", x => x.FuncionarioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "98874_Funcionario");
        }
    }
}
