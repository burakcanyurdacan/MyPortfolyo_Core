using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolyo_Core.Migrations
{
    public partial class mig_addExperienceTableStartEndDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Experiences");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Experiences",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Experiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Experiences");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
