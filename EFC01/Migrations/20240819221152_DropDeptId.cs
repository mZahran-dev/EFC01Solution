using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC01.Migrations
{
    /// <inheritdoc />
    public partial class DropDeptId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dep_Id",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dep_Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
