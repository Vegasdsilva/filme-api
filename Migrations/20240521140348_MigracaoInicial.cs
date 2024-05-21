using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moviegerenciator.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_FILMES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Diretor = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    AnoLancamento = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Classificacao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Genero = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FILMES", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_FILMES");
        }
    }
}
