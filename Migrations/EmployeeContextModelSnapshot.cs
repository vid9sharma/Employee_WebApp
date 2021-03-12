﻿// <auto-generated />
using Employee_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Employee_WebApp.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employee_WebApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 101,
                            FirstName = "James",
                            JobTitle = "Director of Operations",
                            LastName = "Smith",
                            Salary = 94000m
                        },
                        new
                        {
                            EmployeeID = 102,
                            FirstName = "John",
                            JobTitle = "General Manager",
                            LastName = "Brown",
                            Salary = 65000m
                        },
                        new
                        {
                            EmployeeID = 103,
                            FirstName = "Patricia",
                            JobTitle = "Assistant Manager",
                            LastName = "Miller",
                            Salary = 50000m
                        },
                        new
                        {
                            EmployeeID = 104,
                            FirstName = "Susan",
                            JobTitle = "Software Developer",
                            LastName = "Davis",
                            Salary = 57000m
                        },
                        new
                        {
                            EmployeeID = 105,
                            FirstName = "William",
                            JobTitle = "Developer Team Lead",
                            LastName = "Jones",
                            Salary = 88000m
                        },
                        new
                        {
                            EmployeeID = 106,
                            FirstName = "Sarah",
                            JobTitle = "Assistant Manager",
                            LastName = "Taylor",
                            Salary = 70000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
