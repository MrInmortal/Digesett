using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DIGESETTApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMontoToMultas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Monto",
                table: "Multas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Multas");
        }
    }
}
