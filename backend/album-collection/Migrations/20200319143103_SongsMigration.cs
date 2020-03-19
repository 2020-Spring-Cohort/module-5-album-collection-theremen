using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class SongsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Songs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "Duration", "Links", "SongTitle" },
                values: new object[,]
                {
                    { 1, 1, "3:30", "link.html", "Sigh No More" },
                    { 26, 3, "4:34", "link.html", "To Live Is to Hide" },
                    { 27, 3, "4:36", "link.html", "Purify" },
                    { 28, 3, "3:53", "link.html", "Senzafine" },
                    { 29, 3, "5:54", "link.html", "When a Dead Man Walks" },
                    { 30, 3, "4:58", "link.html", "1:19" },
                    { 31, 3, "5:23", "link.html", "Cold Heritage" },
                    { 32, 3, "5:29", "link.html", "Distant Sun" },
                    { 33, 3, "5:20", "link.html", "A Current Obsession" },
                    { 34, 3, "4:40", "link.html", "Wave of Anguish" },
                    { 25, 3, "4:59", "link.html", "Heir of a Dying Day" },
                    { 35, 4, "4:00", "link.html", "Swamped" },
                    { 37, 4, "3:50", "link.html", "Daylight Dancer" },
                    { 38, 4, "4:12", "link.html", "Humane" },
                    { 39, 4, "3:31", "link.html", "Self Deception" },
                    { 40, 4, "1:56", "link.html", "Aeon" },
                    { 41, 4, "4:15", "link.html", "Tight Rope" },
                    { 42, 4, "4:09", "link.html", "The Ghost Woman and the Hunter" },
                    { 43, 4, "3:37", "link.html", "Unspoken" },
                    { 44, 4, "3:59", "link.html", "Entwined" },
                    { 45, 4, "4:32", "link.html", "The Prophet Said" },
                    { 36, 4, "4:46", "link.html", "Heaven's a Lie" },
                    { 46, 4, "3:56", "link.html", "Angel's Punishment" },
                    { 24, 2, "4:09", "link.html", "Not With Haste" },
                    { 22, 2, "4:16", "link.html", "Broken Crown" },
                    { 2, 1, "3:37", "link.html", "The Cave" },
                    { 3, 1, "3:39", "link.html", "Winter Winds" },
                    { 4, 1, "4:23", "link.html", "Roll Away Your Stone" },
                    { 5, 1, "4:14", "link.html", "White Blank Page" },
                    { 6, 1, "4:18", "link.html", "I Gave You All" },
                    { 7, 1, "4:05", "link.html", "Little Lion Man" },
                    { 8, 1, "2:54", "link.html", "Timshel" },
                    { 9, 1, "4:50", "link.html", "Thistle & Weeds" },
                    { 10, 1, "4:13", "link.html", "Awake My Soul" },
                    { 23, 2, "4:52", "link.html", "Below My Feet" },
                    { 11, 1, "4:40", "link.html", "Dust Bowl Dance" },
                    { 13, 2, "3:29", "link.html", "Babel" },
                    { 14, 2, "3:16", "link.html", "Whispers in the Dark" },
                    { 15, 2, "4:37", "link.html", "I Will Wait" },
                    { 16, 2, "4:13", "link.html", "Holland Road" },
                    { 17, 2, "5:40", "link.html", "Ghosts That We Knew" },
                    { 18, 2, "5:15", "link.html", "Lover of the Light" },
                    { 19, 2, "5:21", "link.html", "Lovers' Eyes" },
                    { 20, 2, "2:05", "link.html", "Reminder" },
                    { 21, 2, "5:08", "link.html", "Hopeless Wanderer" },
                    { 12, 1, "4:11", "link.html", "After the Storm" },
                    { 47, 4, "5:01", "link.html", "Comalies" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 47);

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Songs");
        }
    }
}
