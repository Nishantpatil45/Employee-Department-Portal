using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpDeptPortal.Migrations
{
    public partial class AddUpdateEmpTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DeptId1",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DeptId1",
                table: "Employees",
                newName: "DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DeptId1",
                table: "Employees",
                newName: "IX_Employees_DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DeptId",
                table: "Employees",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DeptId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Employees",
                newName: "DeptId1");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DeptId",
                table: "Employees",
                newName: "IX_Employees_DeptId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DeptId1",
                table: "Employees",
                column: "DeptId1",
                principalTable: "Department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
