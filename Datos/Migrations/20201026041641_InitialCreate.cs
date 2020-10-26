using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(type: "varchar(13)", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(20)", nullable: true),
                    Apellidos = table.Column<string>(type: "varchar(20)", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(11)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Apoyos",
                columns: table => new
                {
                    CodigoAyuda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departamento = table.Column<string>(type: "varchar(11)", nullable: true),
                    Ciudad = table.Column<string>(type: "varchar(20)", nullable: true),
                    ValorApoyo = table.Column<double>(type: "float", nullable: false),
                    Modalidad = table.Column<string>(type: "varchar(20)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    PersonaIdentificacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apoyos", x => x.CodigoAyuda);
                    table.ForeignKey(
                        name: "FK_Apoyos_Personas_PersonaIdentificacion",
                        column: x => x.PersonaIdentificacion,
                        principalTable: "Personas",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apoyos_PersonaIdentificacion",
                table: "Apoyos",
                column: "PersonaIdentificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apoyos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
