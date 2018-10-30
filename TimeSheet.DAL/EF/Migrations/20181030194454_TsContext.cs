using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TimeSheet.DAL.EF.Migrations
{
    public partial class TsContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee",
                schema: "Employee");

            migrationBuilder.EnsureSchema(
                name: "TimeSheet");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSheet",
                schema: "TimeSheet");

            migrationBuilder.EnsureSchema(
                name: "Employee");

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    address = table.Column<string>(maxLength: 100, nullable: false),
                    exempt = table.Column<bool>(nullable: false),
                    firstName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }
    }
}
