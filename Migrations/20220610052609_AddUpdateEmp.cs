using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpDeptPortal.Migrations
{
    public partial class AddUpdateEmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Employees",
                newName: "DeptId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DeptId1",
                table: "Employees",
                column: "DeptId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DeptId1",
                table: "Employees",
                column: "DeptId1",
                principalTable: "Department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DeptId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DeptId1",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DeptId1",
                table: "Employees",
                newName: "DeptId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId",
                principalTable: "Department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
