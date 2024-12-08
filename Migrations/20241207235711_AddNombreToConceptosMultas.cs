using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DIGESETTApp.Migrations
{
    /// <inheritdoc />
    public partial class AddNombreToConceptosMultas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CedulaCiudadano",
                table: "Multas");

            migrationBuilder.RenameColumn(
                name: "NombreCiudadano",
                table: "Multas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Multas",
                newName: "ConceptoId");

            migrationBuilder.RenameColumn(
                name: "Concepto",
                table: "Multas",
                newName: "Cedula");

            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Multas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "BLOB");

            migrationBuilder.AddColumn<bool>(
                name: "Activa",
                table: "Multas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "ConceptosMultas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Multas_ConceptoId",
                table: "Multas",
                column: "ConceptoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Multas_ConceptosMultas_ConceptoId",
                table: "Multas",
                column: "ConceptoId",
                principalTable: "ConceptosMultas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multas_ConceptosMultas_ConceptoId",
                table: "Multas");

            migrationBuilder.DropIndex(
                name: "IX_Multas_ConceptoId",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "Activa",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "ConceptosMultas");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Multas",
                newName: "NombreCiudadano");

            migrationBuilder.RenameColumn(
                name: "ConceptoId",
                table: "Multas",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "Cedula",
                table: "Multas",
                newName: "Concepto");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "Multas",
                type: "BLOB",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "CedulaCiudadano",
                table: "Multas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
