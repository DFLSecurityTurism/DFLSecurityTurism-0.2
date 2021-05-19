using Microsoft.EntityFrameworkCore.Migrations;

namespace DFLSecurityTurism_0._2.Data.Migrations
{
    public partial class dados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quaissãoo",
                table: "Inquérito");

            migrationBuilder.RenameColumn(
                name: "Tipodeestabelecimento",
                table: "Inquérito",
                newName: "TipoDeEstabelecimento");

            migrationBuilder.RenameColumn(
                name: "QueMecanismosdesegurançaoestabelecimentoutiliza",
                table: "Inquérito",
                newName: "QueMecanismosDeSegurançaOEstabelecimentoUtiliza");

            migrationBuilder.RenameColumn(
                name: "Quantosequipamentosdesegurançaoestabelecimentoutiliza",
                table: "Inquérito",
                newName: "QuantosEquipamentosDeSegurançaOEstabelecimentoUtiliza");

            migrationBuilder.RenameColumn(
                name: "Quantoscertificadosdesegurançatem",
                table: "Inquérito",
                newName: "QuantosCertificadosDeSegurançaTem");

            migrationBuilder.RenameColumn(
                name: "Quaissão",
                table: "Inquérito",
                newName: "QuaisSão");

            migrationBuilder.AlterColumn<string>(
                name: "TipoDeEstabelecimento",
                table: "Inquérito",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QueMecanismosDeSegurançaOEstabelecimentoUtiliza",
                table: "Inquérito",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QuaisSão",
                table: "Inquérito",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Inquérito",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Inquérito",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuaisSãoOsEquipamentosDeSegurançaQueTem",
                table: "Inquérito",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Inquérito");

            migrationBuilder.DropColumn(
                name: "QuaisSãoOsEquipamentosDeSegurançaQueTem",
                table: "Inquérito");

            migrationBuilder.RenameColumn(
                name: "TipoDeEstabelecimento",
                table: "Inquérito",
                newName: "Tipodeestabelecimento");

            migrationBuilder.RenameColumn(
                name: "QueMecanismosDeSegurançaOEstabelecimentoUtiliza",
                table: "Inquérito",
                newName: "QueMecanismosdesegurançaoestabelecimentoutiliza");

            migrationBuilder.RenameColumn(
                name: "QuantosEquipamentosDeSegurançaOEstabelecimentoUtiliza",
                table: "Inquérito",
                newName: "Quantosequipamentosdesegurançaoestabelecimentoutiliza");

            migrationBuilder.RenameColumn(
                name: "QuantosCertificadosDeSegurançaTem",
                table: "Inquérito",
                newName: "Quantoscertificadosdesegurançatem");

            migrationBuilder.RenameColumn(
                name: "QuaisSão",
                table: "Inquérito",
                newName: "Quaissão");

            migrationBuilder.AlterColumn<string>(
                name: "Tipodeestabelecimento",
                table: "Inquérito",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "QueMecanismosdesegurançaoestabelecimentoutiliza",
                table: "Inquérito",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Quaissão",
                table: "Inquérito",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Inquérito",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Quaissãoo",
                table: "Inquérito",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
