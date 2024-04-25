using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudioAnimes.Migrations
{
    /// <inheritdoc />
    public partial class CreateDiretores_Estudios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "98874_Diretores",
                columns: table => new
                {
                    DiretoresId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Especializacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ProjetosConcluidos = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_98874_Diretores", x => x.DiretoresId);
                });

            migrationBuilder.CreateTable(
                name: "98874_Estudios",
                columns: table => new
                {
                    EstudiosId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeEstudio = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Pais = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataFundação = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_98874_Estudios", x => x.EstudiosId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "98874_Diretores");

            migrationBuilder.DropTable(
                name: "98874_Estudios");
        }
    }
}
