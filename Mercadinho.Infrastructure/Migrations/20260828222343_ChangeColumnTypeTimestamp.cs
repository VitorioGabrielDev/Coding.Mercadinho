using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mercadinho.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnTypeTimestamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "Products",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DELETED_AT",
                table: "Products",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_AT",
                table: "Products",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "Employees",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DELETED_AT",
                table: "Employees",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_AT",
                table: "Employees",
                type: "TIMESTAMP WITH TIME ZONE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "Products",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DELETED_AT",
                table: "Products",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_AT",
                table: "Products",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "Employees",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DELETED_AT",
                table: "Employees",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_AT",
                table: "Employees",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP WITH TIME ZONE");
        }
    }
}
