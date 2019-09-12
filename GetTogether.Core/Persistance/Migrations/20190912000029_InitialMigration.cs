using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetTogether.Core.Persistance.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroEmpleado = table.Column<int>(type: "INT", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "Lugares",
                columns: table => new
                {
                    IdLugar = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreLugar = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    DireccionLugar = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    FechaLugar = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2019, 9, 11, 19, 0, 29, 110, DateTimeKind.Local).AddTicks(724))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lugares", x => x.IdLugar);
                });

            migrationBuilder.CreateTable(
                name: "OpcionesComida",
                columns: table => new
                {
                    IdOpcion = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    Descripcion = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    Costo = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    LugarId = table.Column<int>(nullable: false),
                    FechaOpcion = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2019, 9, 11, 19, 0, 29, 123, DateTimeKind.Local).AddTicks(4168))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionesComida", x => x.IdOpcion);
                    table.ForeignKey(
                        name: "FK_OpcionesComida_Lugares_LugarId",
                        column: x => x.LugarId,
                        principalTable: "Lugares",
                        principalColumn: "IdLugar",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votaciones",
                columns: table => new
                {
                    IdVotacion = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpleadoId = table.Column<int>(nullable: false),
                    OpcionComidaId = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2019, 9, 11, 19, 0, 29, 124, DateTimeKind.Local).AddTicks(121)),
                    FechaModificacion = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2019, 9, 11, 19, 0, 29, 124, DateTimeKind.Local).AddTicks(842)),
                    RegistroActivo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votaciones", x => x.IdVotacion);
                    table.ForeignKey(
                        name: "FK_Votaciones_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votaciones_OpcionesComida_OpcionComidaId",
                        column: x => x.OpcionComidaId,
                        principalTable: "OpcionesComida",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OpcionesComida_LugarId",
                table: "OpcionesComida",
                column: "LugarId");

            migrationBuilder.CreateIndex(
                name: "IX_Votaciones_EmpleadoId",
                table: "Votaciones",
                column: "EmpleadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votaciones_OpcionComidaId",
                table: "Votaciones",
                column: "OpcionComidaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votaciones");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "OpcionesComida");

            migrationBuilder.DropTable(
                name: "Lugares");
        }
    }
}
