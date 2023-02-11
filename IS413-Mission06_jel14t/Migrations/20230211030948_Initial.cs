using Microsoft.EntityFrameworkCore.Migrations;

namespace IS413_Mission06_jel14t.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.EntryID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action/Adventure", "John McTiernan", true, null, null, "R", "Die Hard", 1988 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action/Adventure", "Roland Emmerich", false, null, null, "PG-13", "Independence Day", 1996 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Comedy", "John Hughes", true, "Dave", "What an interesting movie", "R", "Planes, Trains and Automobiles", 1987 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
