using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC01.Migrations
{
    /// <inheritdoc />
    public partial class DropUneccesryColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dept_ID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Top_Id",
                table: "Courses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dept_ID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Top_Id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
