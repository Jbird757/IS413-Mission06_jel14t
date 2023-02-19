using Microsoft.EntityFrameworkCore.Migrations;

namespace IS413_Mission06_jel14t.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true),
                    categoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_responses_Categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, 1, "John McTiernan", true, null, null, "R", "Die Hard", 1988 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, 1, "Roland Emmerich", false, null, null, "PG-13", "Independence Day", 1996 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, 2, "John Hughes", true, "Dave", "What an interesting movie", "R", "Planes, Trains and Automobiles", 1987 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_categoryID",
                table: "responses",
                column: "categoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
