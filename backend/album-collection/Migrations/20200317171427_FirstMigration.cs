using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongTitle = table.Column<string>(nullable: true),
                    Links = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    RecordLabel = table.Column<string>(nullable: true),
                    SongsSongId = table.Column<int>(nullable: true)
                  //  SongTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Songs_SongsSongId",
                        column: x => x.SongsSongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Hometown = table.Column<string>(nullable: true),
                    AlbumId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                    table.ForeignKey(
                        name: "FK_Artists_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "AlbumId", "Hometown", "Image", "Name" },
                values: new object[] { 1, null, "London, UK", "mumfordsons.jpg", "Mumford & Sons", null });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "AlbumId", "Hometown", "Image", "Name" },
                values: new object[] { 2, null, "Milan, Italy", "lacunacoil.jpg", "Lacuna Coil", null });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_SongsSongId",
                table: "Albums",
                column: "SongsSongId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_AlbumId",
                table: "Artists",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
