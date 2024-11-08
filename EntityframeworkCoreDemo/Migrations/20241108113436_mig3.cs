using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityframeworkCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Branches_BranchesBranchId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Students",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "EnrollementDate",
                table: "Students",
                newName: "EnrollmentDate");

            migrationBuilder.RenameColumn(
                name: "BranchesBranchId",
                table: "Students",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_BranchesBranchId",
                table: "Students",
                newName: "IX_Students_BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Branches_BranchId",
                table: "Students",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Branches_BranchId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Students",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "EnrollmentDate",
                table: "Students",
                newName: "EnrollementDate");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Students",
                newName: "BranchesBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_BranchId",
                table: "Students",
                newName: "IX_Students_BranchesBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Branches_BranchesBranchId",
                table: "Students",
                column: "BranchesBranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");
        }
    }
}
