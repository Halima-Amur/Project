using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class Database1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepID",
                table: "employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employee_DepartmentId",
                table: "employee",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_department_DepartmentId",
                table: "employee",
                column: "DepartmentId",
                principalTable: "department",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_department_DepartmentId",
                table: "employee");

            migrationBuilder.DropIndex(
                name: "IX_employee_DepartmentId",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "DepID",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "employee");
        }
    }
}
