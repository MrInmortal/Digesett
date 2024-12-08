using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DIGESETTApp.Migrations
{
    /// <inheritdoc />
    public partial class AddLatLongToMultas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgenteId",
                table: "Multas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Latitud",
                table: "Multas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitud",
                table: "Multas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgenteId",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Multas");
        }
    }
}
