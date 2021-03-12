using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee_WebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "JobTitle", "LastName", "Salary" },
                values: new object[,]
                {
                    { 101, "James", "Director of Operations", "Smith", 94000m },
                    { 102, "John", "General Manager", "Brown", 65000m },
                    { 103, "Patricia", "Assistant Manager", "Miller", 50000m },
                    { 104, "Susan", "Software Developer", "Davis", 57000m },
                    { 105, "William", "Developer Team Lead", "Jones", 88000m },
                    { 106, "Sarah", "Assistant Manager", "Taylor", 70000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
