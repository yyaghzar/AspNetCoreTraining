﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTraining.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Credits = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstMidName = table.Column<string>(nullable: true),
                    EnrollmentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Enrollment_Course_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "ID", "Credits", "Title" },
                values: new object[,]
                {
                    { 1050, 3, "Chemistry" },
                    { 4022, 3, "Microeconomics" },
                    { 4041, 3, "Macroeconomics" },
                    { 1045, 4, "Calculus" },
                    { 3141, 4, "Trigonometry" },
                    { 2021, 3, "Composition" },
                    { 2042, 4, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carson", "Alexander" },
                    { 2, new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meredith", "Alonso" },
                    { 3, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arturo", "Anand" },
                    { 4, new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gytis", "Barzdukas" },
                    { 5, new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yan", "Li" },
                    { 6, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peggy", "Justice" },
                    { 7, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Norman" },
                    { 8, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nino", "Olivetto" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "ID", "CourseID", "Grade", "StudentID" },
                values: new object[,]
                {
                    { 1, 1050, 0, 1 },
                    { 2, 4022, 2, 1 },
                    { 3, 4041, 1, 1 },
                    { 4, 1045, 1, 2 },
                    { 5, 3141, 4, 2 },
                    { 6, 2021, 4, 2 },
                    { 7, 1050, null, 3 },
                    { 8, 1050, null, 4 },
                    { 9, 4022, 4, 4 },
                    { 10, 4041, 2, 5 },
                    { 11, 1045, null, 6 },
                    { 12, 3141, 0, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseID",
                table: "Enrollment",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentID",
                table: "Enrollment",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
