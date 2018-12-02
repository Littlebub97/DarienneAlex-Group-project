using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheet.DAL.EF.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                schema: "TimeSheet",
                table: "TimeSheet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                schema: "TimeSheet",
                table: "TimeSheet",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "approved",
                schema: "TimeSheet",
                table: "TimeSheet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheet_EmployeeId",
                schema: "TimeSheet",
                table: "TimeSheet",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheet_Employee_EmployeeId",
                schema: "TimeSheet",
                table: "TimeSheet",
                column: "EmployeeId",
                principalSchema: "TimeSheet",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSheet_Employee_EmployeeId",
                schema: "TimeSheet",
                table: "TimeSheet");

            migrationBuilder.DropIndex(
                name: "IX_TimeSheet_EmployeeId",
                schema: "TimeSheet",
                table: "TimeSheet");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                schema: "TimeSheet",
                table: "TimeSheet");

            migrationBuilder.DropColumn(
                name: "Reason",
                schema: "TimeSheet",
                table: "TimeSheet");

            migrationBuilder.DropColumn(
                name: "approved",
                schema: "TimeSheet",
                table: "TimeSheet");
        }
    }
}
