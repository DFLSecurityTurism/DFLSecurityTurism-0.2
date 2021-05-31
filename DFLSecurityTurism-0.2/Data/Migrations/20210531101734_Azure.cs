using Microsoft.EntityFrameworkCore.Migrations;

namespace DFLSecurityTurism_0._2.Data.Migrations
{
    public partial class Azure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descrição5",
                table: "Restaurante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição5",
                table: "Hotel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrição5",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "Descrição5",
                table: "Hotel");
        }
    }
}
