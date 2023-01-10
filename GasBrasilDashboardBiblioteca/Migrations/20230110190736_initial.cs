using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GasBrasilDashboardBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CADASTRO_BRUTO",
                columns: table => new
                {
                    IDCLIENTE = table.Column<int>(name: "ID_CLIENTE", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLASSECONSUMO = table.Column<string>(name: "CLASSE_CONSUMO", type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    MUNICIPIO = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CADASTRO_BRUTO", x => x.IDCLIENTE);
                });

            migrationBuilder.CreateTable(
                name: "TB_FATURAMENTO",
                columns: table => new
                {
                    IDCLIENTE = table.Column<int>(name: "ID_CLIENTE", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONSUMOM3 = table.Column<string>(name: "CONSUMO_M3", type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    DATAARQUIVO = table.Column<DateTime>(name: "DATA_ARQUIVO", type: "DATETIME", maxLength: 80, nullable: false),
                    DATAREFERENCIA = table.Column<DateTime>(name: "DATA_REFERENCIA", type: "DATETIME", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FATURAMENTO", x => x.IDCLIENTE);
                });

            migrationBuilder.CreateIndex(
                name: "ID_CLIENTE",
                table: "TB_CADASTRO_BRUTO",
                column: "ID_CLIENTE",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ID_CLIENTE",
                table: "TB_FATURAMENTO",
                column: "ID_CLIENTE",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CADASTRO_BRUTO");

            migrationBuilder.DropTable(
                name: "TB_FATURAMENTO");
        }
    }
}
