using Microsoft.EntityFrameworkCore.Migrations;

namespace DFLSecurityTurism_0._2.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descrição = table.Column<string>(nullable: true),
                    Imagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inquérito",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipodeestabelecimento = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Quantoscertificadosdesegurançatem = table.Column<int>(nullable: false),
                    Quaissão = table.Column<string>(nullable: true),
                    QueMecanismosdesegurançaoestabelecimentoutiliza = table.Column<string>(nullable: true),
                    Quantosequipamentosdesegurançaoestabelecimentoutiliza = table.Column<int>(nullable: false),
                    Quaissãoo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquérito", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descrição = table.Column<string>(nullable: true),
                    Imagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurante", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Inquérito");

            migrationBuilder.DropTable(
                name: "Restaurante");
        }
    }
}
