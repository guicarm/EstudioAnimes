using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudioAnimes.Migrations
{
    /// <inheritdoc />
    public partial class CreateAnimadores_Animes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "98874_Animadores",
                columns: table => new
                {
                    AnimadoresId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EstiloAnimacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    AnosExperiencia = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_98874_Animadores", x => x.AnimadoresId);
                });

            migrationBuilder.CreateTable(
                name: "98874_Animes",
                columns: table => new
                {
                    AnimesId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Titulo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    QuantidadeEp = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DataLancamento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_98874_Animes", x => x.AnimesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "98874_Animadores");

            migrationBuilder.DropTable(
                name: "98874_Animes");
        }
    }
}
