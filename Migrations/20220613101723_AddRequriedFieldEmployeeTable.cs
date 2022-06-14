using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpDeptPortal.Migrations
{
    public partial class AddRequriedFieldEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DeptId",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_DeptId",
                table: "Employees",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DeptId",
                table: "Employees",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
