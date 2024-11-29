using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AQAutosMVC.Migrations
{
    /// <inheritdoc />
    public partial class CambiosBdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AQAuto",
                columns: table => new
                {
                    AQAutoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AQMarca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AQAnio = table.Column<int>(type: "int", nullable: false),
                    AQCombustible = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AQUsado = table.Column<bool>(type: "bit", nullable: false),
                    AQPrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AqEmaildistribuidor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AQFechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AQAuto", x => x.AQAutoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AQAuto");
        }
    }
}
