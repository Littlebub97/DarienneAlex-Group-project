using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TimeSheet.DAL.EF;

namespace TimeSheet.DAL.EF.Migrations
{
    [DbContext(typeof(TimeSheetContext))]
    [Migration("20181030194454_TsContext")]
    partial class TsContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimeSheet.Models.Entities.Timesheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("date");

                    b.Property<decimal>("hours");

                    b.Property<decimal>("payRate");

                    b.Property<decimal>("salesCommision");

                    b.HasKey("Id");

                    b.ToTable("TimeSheet","TimeSheet");
                });
        }
    }
}
