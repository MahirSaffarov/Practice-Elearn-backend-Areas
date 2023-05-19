using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearn.Migrations
{
    public partial class CreateSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Slider",
                table: "Slider");

            migrationBuilder.RenameTable(
                name: "Slider",
                newName: "Sliders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sliders",
                table: "Sliders",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Choose",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Choose",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Choose",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Choose",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Milestone",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Milestone",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Milestone",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Milestone",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "NewsAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 12, 11, 436, DateTimeKind.Local).AddTicks(5724));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sliders",
                table: "Sliders");

            migrationBuilder.RenameTable(
                name: "Sliders",
                newName: "Slider");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slider",
                table: "Slider",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "Choose",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Choose",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Choose",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Choose",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3542));

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

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Milestone",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Milestone",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Milestone",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Milestone",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "NewsAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3488));
        }
    }
}
