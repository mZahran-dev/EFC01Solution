﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC01.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToManyRelationInstructorDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DeptID",
                table: "Instructors",
                column: "DeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DeptID",
                table: "Instructors",
                column: "DeptID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DeptID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DeptID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DeptID",
                table: "Instructors");
        }
    }
}
