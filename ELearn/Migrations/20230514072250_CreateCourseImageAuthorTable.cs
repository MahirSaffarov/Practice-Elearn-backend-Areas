using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearn.Migrations
{
    public partial class CreateCourseImageAuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseImages_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted" },
                values: new object[] { 1, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(1796), "Mark Smith", false });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted" },
                values: new object[] { 2, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(1816), "James S. Morrison", false });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted" },
                values: new object[] { 3, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(1817), "Julia Williams", false });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "Price", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2017), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" },
                    { 2, 3, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2021), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" },
                    { 3, 2, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2023), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" },
                    { 4, 3, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2024), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" },
                    { 5, 2, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2025), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" },
                    { 6, 1, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2026), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" },
                    { 7, 3, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2028), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" },
                    { 8, 2, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2029), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" },
                    { 9, 1, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2030), "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.", 35m, false, "Online Literature Course" }
                });

            migrationBuilder.InsertData(
                table: "CourseImages",
                columns: new[] { "Id", "CourseId", "CreatedDate", "Image", "IsMain", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2054), "course_1.jpg", true, false },
                    { 2, 2, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2056), "course_2.jpg", true, false },
                    { 3, 3, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2057), "course_3.jpg", true, false },
                    { 4, 4, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2059), "course_4.jpg", true, false },
                    { 5, 5, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2060), "course_5.jpg", true, false },
                    { 6, 6, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2061), "course_6.jpg", true, false },
                    { 7, 7, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2062), "course_7.jpg", true, false },
                    { 8, 8, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2063), "course_8.jpg", true, false },
                    { 9, 9, new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2064), "course_9.jpg", true, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseImages_CourseId",
                table: "CourseImages",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AuthorId",
                table: "Courses",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseImages");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
