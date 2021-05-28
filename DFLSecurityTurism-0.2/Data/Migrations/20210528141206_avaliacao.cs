using Microsoft.EntityFrameworkCore.Migrations;

namespace DFLSecurityTurism_0._2.Data.Migrations
{
    public partial class avaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvaliacaoHotel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hotel = table.Column<string>(nullable: false),
                    Classifique = table.Column<string>(nullable: false),
                    Equipamentos = table.Column<string>(nullable: false),
                    Período = table.Column<string>(nullable: false),
                    Procedimentos = table.Column<string>(nullable: false),
                    Recomendação = table.Column<string>(nullable: false),
                    Comentário = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoHotel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacaoRestaurante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Restaurante = table.Column<string>(nullable: false),
                    Classifique = table.Column<string>(nullable: false),
                    Equipamentos = table.Column<string>(nullable: false),
                    Período = table.Column<string>(nullable: false),
                    Procedimentos = table.Column<string>(nullable: false),
                    Recomendação = table.Column<string>(nullable: false),
                    Comentário = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoRestaurante", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaliacaoHotel");

            migrationBuilder.DropTable(
                name: "AvaliacaoRestaurante");
        }
    }
}
