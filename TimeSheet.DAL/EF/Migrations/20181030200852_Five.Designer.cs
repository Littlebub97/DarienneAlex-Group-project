using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TimeSheet.DAL.EF;

namespace TimeSheet.DAL.EF.Migrations
{
    [DbContext(typeof(TimeSheetContext))]
    [Migration("20181030200852_Five")]
    partial class Five
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimeSheet.Models.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Department","TimeSheet");
                });

            modelBuilder.Entity("TimeSheet.Models.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100);

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("exempt");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("pay");

                    b.HasKey("Id");

                    b.ToTable("Employee","TimeSheet");
                });

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
