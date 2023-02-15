using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteAppAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubNotes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubNotes_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "ID", "Date", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2401), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Spor" },
                    { 2, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2411), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Online" },
                    { 3, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2412), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Sinema" },
                    { 4, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2413), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Müzik" },
                    { 5, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2414), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Cuma" },
                    { 6, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2414), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Perşembe" },
                    { 7, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2415), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Çarşamba" },
                    { 8, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2416), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Salı" },
                    { 9, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2417), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", false, "Pazartesi" }
                });

            migrationBuilder.InsertData(
                table: "SubNotes",
                columns: new[] { "ID", "Date", "Description", "IsDeleted", "NoteId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2570), "There are many variations of passages of Lorem Ipsum", false, 1 },
                    { 2, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2571), "There are many variations of passages of Lorem Ipsum", false, 1 },
                    { 3, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2573), "There are many variations of passages of Lorem Ipsum", false, 2 },
                    { 4, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2573), "There are many variations of passages of Lorem Ipsum", false, 2 },
                    { 5, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2574), "There are many variations of passages of Lorem Ipsum", false, 3 },
                    { 6, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2575), "There are many variations of passages of Lorem Ipsum", false, 3 },
                    { 7, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2576), "There are many variations of passages of Lorem Ipsum", false, 4 },
                    { 8, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2625), "There are many variations of passages of Lorem Ipsum", false, 4 },
                    { 9, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2627), "There are many variations of passages of Lorem Ipsum", false, 5 },
                    { 10, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2628), "There are many variations of passages of Lorem Ipsum", false, 5 },
                    { 11, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2629), "There are many variations of passages of Lorem Ipsum", false, 6 },
                    { 12, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2629), "There are many variations of passages of Lorem Ipsum", false, 6 },
                    { 13, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2630), "There are many variations of passages of Lorem Ipsum", false, 7 },
                    { 14, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2631), "There are many variations of passages of Lorem Ipsum", false, 7 },
                    { 15, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2632), "There are many variations of passages of Lorem Ipsum", false, 8 },
                    { 16, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2633), "There are many variations of passages of Lorem Ipsum", false, 8 },
                    { 17, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2634), "There are many variations of passages of Lorem Ipsum", false, 9 },
                    { 18, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2635), "There are many variations of passages of Lorem Ipsum", false, 9 },
                    { 19, new DateTime(2023, 2, 15, 23, 41, 6, 470, DateTimeKind.Local).AddTicks(2636), "There are many variations of passages of Lorem Ipsum", false, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubNotes_NoteId",
                table: "SubNotes",
                column: "NoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubNotes");

            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
