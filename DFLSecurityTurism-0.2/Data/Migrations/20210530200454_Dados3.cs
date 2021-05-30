using Microsoft.EntityFrameworkCore.Migrations;

namespace DFLSecurityTurism_0._2.Data.Migrations
{
    public partial class Dados3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrição",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "Descrição",
                table: "Hotel");

            migrationBuilder.AddColumn<string>(
                name: "Descrição1",
                table: "Restaurante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição2",
                table: "Restaurante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição3",
                table: "Restaurante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição4",
                table: "Restaurante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição1",
                table: "Hotel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição2",
                table: "Hotel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição3",
                table: "Hotel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição4",
                table: "Hotel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrição1",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "Descrição2",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "Descrição3",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "Descrição4",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "Descrição1",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "Descrição2",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "Descrição3",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "Descrição4",
                table: "Hotel");

            migrationBuilder.AddColumn<string>(
                name: "Descrição",
                table: "Restaurante",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descrição",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
