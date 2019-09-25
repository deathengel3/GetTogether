using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetTogether.Core.Persistance.Migrations
{
    public partial class RolParaEmpleadoCreado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 642, DateTimeKind.Local).AddTicks(7845),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 197, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 642, DateTimeKind.Local).AddTicks(9156),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 197, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcionModificacion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 641, DateTimeKind.Local).AddTicks(8100),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 197, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 641, DateTimeKind.Local).AddTicks(6915),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 197, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugarModificacion",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 636, DateTimeKind.Local).AddTicks(8067),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 192, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugar",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 627, DateTimeKind.Local).AddTicks(5051),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 183, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "Empleados",
                type: "INT",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rol",
                table: "Empleados");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 197, DateTimeKind.Local).AddTicks(7337),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 642, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Votaciones",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 197, DateTimeKind.Local).AddTicks(8035),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 642, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcionModificacion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 197, DateTimeKind.Local).AddTicks(1432),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 641, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOpcion",
                table: "OpcionesComida",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 197, DateTimeKind.Local).AddTicks(636),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 641, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugarModificacion",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 192, DateTimeKind.Local).AddTicks(8696),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 636, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLugar",
                table: "Lugares",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 12, 18, 0, 1, 183, DateTimeKind.Local).AddTicks(303),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2019, 9, 17, 17, 36, 44, 627, DateTimeKind.Local).AddTicks(5051));
        }
    }
}
