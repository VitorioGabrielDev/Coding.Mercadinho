using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mercadinho.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TimestampNullables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "Products",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DELETED_AT",
                table: "Products",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "Employees",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DELETED_AT",
                table: "Employees",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "Products",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DELETED_AT",
                table: "Products",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "Employees",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DELETED_AT",
                table: "Employees",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE",
                oldNullable: true);
        }
    }
}
