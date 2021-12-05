using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_8_Mishra_Yeati.Migrations
{
    public partial class FinalProjectData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "breakfastFood",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeOfEggsYouLike = table.Column<string>(nullable: true),
                    pancakeOrWaffle = table.Column<string>(nullable: true),
                    typeOfDrink = table.Column<string>(nullable: true),
                    favBreakfastPlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breakfastFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schoolColor = table.Column<string>(nullable: true),
                    memberCommonFavColor = table.Column<string>(nullable: true),
                    numberOfColorInSchoolLogo = table.Column<int>(nullable: false),
                    peopleInTheTeam = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hobbies",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    favSport = table.Column<string>(nullable: true),
                    freeTimeActivity = table.Column<string>(nullable: true),
                    favMovie = table.Column<string>(nullable: true),
                    favPlaceToTravel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "information",
                columns: table => new
                {
                    Id = table.Column<double>(nullable: false),
                    teamName = table.Column<string>(nullable: true),
                    birthDay = table.Column<string>(nullable: true),
                    collegeProgram = table.Column<string>(nullable: true),
                    collegeYear = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_information", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "memberCommonFavColor", "numberOfColorInSchoolLogo", "peopleInTheTeam", "schoolColor" },
                values: new object[] { 1, "Yellow", 6, 8, "Blue" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "memberCommonFavColor", "numberOfColorInSchoolLogo", "peopleInTheTeam", "schoolColor" },
                values: new object[] { 2, "Blue", 3, 2, "Red" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "breakfastFood");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "hobbies");

            migrationBuilder.DropTable(
                name: "information");
        }
    }
}
