using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TimeSheet.DAL.EF.Migrations
{
    public partial class Five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
