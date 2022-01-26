using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataStatsMVC.Data.Migrations
{
    public partial class ChangesToCallModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finish",
                table: "Calls");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Calls");

            migrationBuilder.AddColumn<int>(
                name: "AHT",
                table: "Calls",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "InService",
                table: "Calls",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Offered",
                table: "Calls",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TalkTime",
                table: "Calls",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WrapTime",
                table: "Calls",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AHT",
                table: "Calls");

            migrationBuilder.DropColumn(
                name: "InService",
                table: "Calls");

            migrationBuilder.DropColumn(
                name: "Offered",
                table: "Calls");

            migrationBuilder.DropColumn(
                name: "TalkTime",
                table: "Calls");

            migrationBuilder.DropColumn(
                name: "WrapTime",
                table: "Calls");

            migrationBuilder.AddColumn<DateTime>(
                name: "Finish",
                table: "Calls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Calls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
