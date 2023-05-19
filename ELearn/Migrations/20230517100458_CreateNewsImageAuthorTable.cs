using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearn.Migrations
{
    public partial class CreateNewsImageAuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Choose",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choose", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Milestone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsAuthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsAuthorId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_NewsAuthors_NewsAuthorId",
                        column: x => x.NewsAuthorId,
                        principalTable: "NewsAuthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsImages_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.InsertData(
                table: "Choose",
                columns: new[] { "Id", "CreatedDate", "Description", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3538), "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam.", false, "Mauris vehicula nisi congue ?" },
                    { 2, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3540), "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam.", false, "Mauris vehicula nisi congue ?" },
                    { 3, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3541), "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam.", false, "Mauris vehicula nisi congue ?" },
                    { 4, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3542), "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam.", false, "Mauris vehicula nisi congue ?" }
                });

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CreatedDate", "Description", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3563), "Location: Online Platform", false, "New Marketing Course Release" },
                    { 2, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3565), "Location: Online Platform", false, "Students Art Workshop" },
                    { 3, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3566), "Location: Online Platform", false, "Launch Party for a new Platform" },
                    { 4, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3568), "Location: Online Platform", false, "New Marketing Course" },
                    { 5, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3569), "Location: Online Platform", false, "New Marketing Course" }
                });

            migrationBuilder.InsertData(
                table: "Milestone",
                columns: new[] { "Id", "Count", "CreatedDate", "Logo", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1548, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3515), "milestone_1.svg", false, "online Course" },
                    { 2, 7286, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3517), "milestone_2.svg", false, "Students" },
                    { 3, 257, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3519), "milestone_3.svg", false, "Teachers" },
                    { 4, 39, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3520), "milestone_4.svg", false, "Countries" }
                });

            migrationBuilder.InsertData(
                table: "NewsAuthors",
                columns: new[] { "Id", "CreatedDate", "FullName", "SoftDeleted" },
                values: new object[] { 1, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3586), "Willam Smith", false });

            migrationBuilder.InsertData(
                table: "Slider",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "Logo", "SoftDeleted", "Title" },
                values: new object[] { 1, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3488), "Maecenas rutrum viverra sapien sed fermentum. Morbi tempor odio eget lacus tempus pulvinar. Praesent vel nisl fermentum, gravida augue ut, fermentum ipsum.", "index.jpg", "logo.png", false, "Complete Online Courses" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreatedDate", "NewsAuthorId", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3601), 1, false, "Why Choose online education?" },
                    { 2, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3603), 1, false, "Books, Kindle or tablet?" },
                    { 3, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3605), 1, false, "Why Choose online education?" },
                    { 4, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3606), 1, false, "Books, Kindle or tablet?" }
                });

            migrationBuilder.InsertData(
                table: "NewsImages",
                columns: new[] { "Id", "CreatedDate", "Image", "NewsId", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3623), "news_1.jpg", 1, false },
                    { 2, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3625), "news_2.jpg", 2, false },
                    { 3, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3626), "news_3.jpg", 3, false },
                    { 4, new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3627), "news_4.jpg", 4, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_NewsAuthorId",
                table: "News",
                column: "NewsAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsImages_NewsId",
                table: "NewsImages",
                column: "NewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choose");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Milestone");

            migrationBuilder.DropTable(
                name: "NewsImages");

            migrationBuilder.DropTable(
                name: "Slider");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "NewsAuthors");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 11, 22, 50, 440, DateTimeKind.Local).AddTicks(2030));
        }
    }
}
