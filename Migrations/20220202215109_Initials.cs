using Microsoft.EntityFrameworkCore.Migrations;

namespace DaMovies.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieCategory",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategory", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "reponse",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_To = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reponse", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_reponse_MovieCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "MovieCategory",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "CategoryID", "Category" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "reponse",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 2, "Steve Jacobs", false, "Jacob Marley", "na", "PG-13", "The Blindside", 2012 });

            migrationBuilder.InsertData(
                table: "reponse",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 3, "Christopher Nolan", false, "Jacob Marley", "na", "PG-13", "The Dark Knight", 2012 });

            migrationBuilder.InsertData(
                table: "reponse",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 4, "Anne Fletcher", false, "na", "na", "PG-13", "The Proposal", 2009 });

            migrationBuilder.CreateIndex(
                name: "IX_reponse_CategoryID",
                table: "reponse",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reponse");

            migrationBuilder.DropTable(
                name: "MovieCategory");
        }
    }
}
