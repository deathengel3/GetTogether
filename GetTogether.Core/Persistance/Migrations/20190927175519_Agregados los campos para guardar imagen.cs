using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetTogether.Core.Persistance.Migrations
{
    public partial class Agregadosloscamposparaguardarimagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 864, DateTimeKind.Local).AddTicks(9115),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 642, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 865, DateTimeKind.Local).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 642, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcionModificacion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 864, DateTimeKind.Local).AddTicks(951),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 641, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 863, DateTimeKind.Local).AddTicks(9821),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 641, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "OpcionesComida",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugarModificacion",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 859, DateTimeKind.Local).AddTicks(4744),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 636, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugar",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 848, DateTimeKind.Local).AddTicks(3795),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 627, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Lugares",
                type: "VARCHAR(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "OpcionesComida");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Lugares");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 642, DateTimeKind.Local).AddTicks(7845),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 864, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 642, DateTimeKind.Local).AddTicks(9156),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 865, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcionModificacion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 641, DateTimeKind.Local).AddTicks(8100),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 864, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 641, DateTimeKind.Local).AddTicks(6915),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 863, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugarModificacion",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 636, DateTimeKind.Local).AddTicks(8067),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 859, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugar",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 627, DateTimeKind.Local).AddTicks(5051),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 848, DateTimeKind.Local).AddTicks(3795));
        }
    }
}
