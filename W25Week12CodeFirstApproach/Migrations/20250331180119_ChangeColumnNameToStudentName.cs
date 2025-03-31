using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W25Week12CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnNameToStudentName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "StudentName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Name");
        }
    }
}
