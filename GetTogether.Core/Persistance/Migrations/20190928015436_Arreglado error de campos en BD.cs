using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetTogether.Core.Persistance.Migrations
{
    public partial class ArregladoerrordecamposenBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 828, DateTimeKind.Local).AddTicks(9268),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 864, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 829, DateTimeKind.Local).AddTicks(252),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 865, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.AlterColumn<string>(
                name: "Imagen",
                table: "OpcionesComida",
                type: "VARCHAR(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcionModificacion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 828, DateTimeKind.Local).AddTicks(1121),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 864, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 827, DateTimeKind.Local).AddTicks(9914),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 863, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugarModificacion",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 823, DateTimeKind.Local).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 859, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugar",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 806, DateTimeKind.Local).AddTicks(7226),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 848, DateTimeKind.Local).AddTicks(3795));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 864, DateTimeKind.Local).AddTicks(9115),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 828, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 865, DateTimeKind.Local).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 829, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.AlterColumn<string>(
                name: "Imagen",
                table: "OpcionesComida",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcionModificacion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 864, DateTimeKind.Local).AddTicks(951),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 828, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 863, DateTimeKind.Local).AddTicks(9821),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 827, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugarModificacion",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 859, DateTimeKind.Local).AddTicks(4744),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 823, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugar",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 12, 55, 18, 848, DateTimeKind.Local).AddTicks(3795),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 27, 20, 54, 35, 806, DateTimeKind.Local).AddTicks(7226));
        }
    }
}
