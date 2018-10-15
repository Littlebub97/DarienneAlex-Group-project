using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheet.DAL.EF.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                schema: "TimeSheet",
                table: "Employees");

            migrationBuilder.EnsureSchema(
                name: "Employee");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "TimeSheet",
                newName: "Employee",
                newSchema: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                schema: "Employee",
                table: "Employee",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                schema: "Employee",
                table: "Employee",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                schema: "Employee",
                table: "Employee",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "address",
                schema: "Employee",
                table: "Employee",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "exempt",
                schema: "Employee",
                table: "Employee",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                schema: "Employee",
                table: "Employee",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                schema: "Employee",
                table: "Employee",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                schema: "Employee",
                table: "Employee",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                schema: "Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                schema: "Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Password",
                schema: "Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "address",
                schema: "Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "exempt",
                schema: "Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "firstName",
                schema: "Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "lastName",
                schema: "Employee",
                table: "Employee");

            migrationBuilder.EnsureSchema(
                name: "TimeSheet");

            migrationBuilder.RenameTable(
                name: "Employee",
                schema: "Employee",
                newName: "Employees",
                newSchema: "TimeSheet");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                schema: "TimeSheet",
                table: "Employees",
                newName: "EmployeeName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                schema: "TimeSheet",
                table: "Employees",
                column: "Id");
        }
    }
}
