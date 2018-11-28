using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheet.DAL.EF.Migrations
{
    public partial class Six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hours",
                schema: "TimeSheet",
                table: "TimeSheet",
                newName: "weeklyHours");

            migrationBuilder.AddColumn<decimal>(
                name: "dailyHours",
                schema: "TimeSheet",
                table: "TimeSheet",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dailyHours",
                schema: "TimeSheet",
                table: "TimeSheet");

            migrationBuilder.RenameColumn(
                name: "weeklyHours",
                schema: "TimeSheet",
                table: "TimeSheet",
                newName: "hours");
        }
    }
}
