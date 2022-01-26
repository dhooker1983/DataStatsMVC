using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataStatsMVC.Data.Migrations
{
    public partial class AddingNamePropertyToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");
        }
    }
}
