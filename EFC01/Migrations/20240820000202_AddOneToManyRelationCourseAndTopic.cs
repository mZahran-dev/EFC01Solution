using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC01.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToManyRelationCourseAndTopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CourseID",
                table: "Topics",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Courses_CourseID",
                table: "Topics",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Courses_CourseID",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_CourseID",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Topics");
        }
    }
}
