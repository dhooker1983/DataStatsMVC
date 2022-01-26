using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataStatsMVC.Data.Migrations
{
    public partial class EndDateCurrentlyEmpAddedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CurrentlyEmployed",
                table: "Employees",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Employees",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentlyEmployed",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Employees");
        }
    }
}
