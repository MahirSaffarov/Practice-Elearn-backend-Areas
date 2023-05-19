using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearn.Migrations
{
    public partial class CreateMilestoneEventChooseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Milestone",
                table: "Milestone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Choose",
                table: "Choose");

            migrationBuilder.RenameTable(
                name: "Milestone",
                newName: "Milestones");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "Choose",
                newName: "Chooses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Milestones",
                table: "Milestones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chooses",
                table: "Chooses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Chooses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Chooses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Chooses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Chooses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "CourseImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "NewsAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "NewsImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 14, 15, 22, 117, DateTimeKind.Local).AddTicks(2864));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Milestones",
                table: "Milestones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chooses",
                table: "Chooses");

            migrationBuilder.RenameTable(
                name: "Milestones",
                newName: "Milestone");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "Chooses",
                newName: "Choose");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Milestone",
                table: "Milestone",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Choose",
                table: "Choose",
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
    }
}
