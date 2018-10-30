using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TimeSheet.DAL.EF.Migrations
{
    public partial class Four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSheet",
                schema: "TimeSheet");

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "TimeSheet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(maxLength: 50, nullable: false),
                    Role = table.Column<string>(maxLength: 50, nullable: false),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "TimeSheet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: true),
                    EmployeeName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    address = table.Column<string>(maxLength: 100, nullable: false),
                    exempt = table.Column<bool>(nullable: false),
                    firstName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    pay = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department",
                schema: "TimeSheet");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "TimeSheet");

            migrationBuilder.CreateTable(
                name: "TimeSheet",
                schema: "TimeSheet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    hours = table.Column<decimal>(nullable: false),
                    payRate = table.Column<decimal>(nullable: false),
                    salesCommision = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheet", x => x.Id);
                });
        }
    }
}
