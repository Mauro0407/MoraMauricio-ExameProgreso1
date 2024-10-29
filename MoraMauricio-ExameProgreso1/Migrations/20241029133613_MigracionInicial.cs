using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoraMauricio_ExameProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Año",
                table: "Celular",
                newName: "Anio");

            migrationBuilder.AlterColumn<double>(
                name: "Salario",
                table: "MMora",
                type: "float",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "Celular",
                type: "float",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Anio",
                table: "Celular",
                newName: "Año");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salario",
                table: "MMora",
                type: "decimal(18,2)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Celular",
                type: "decimal(18,2)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 100);
        }
    }
}
