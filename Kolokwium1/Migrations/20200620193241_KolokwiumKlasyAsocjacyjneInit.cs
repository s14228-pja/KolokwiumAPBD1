using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium1.Migrations
{
    public partial class KolokwiumKlasyAsocjacyjneInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MaxAge",
                table: "Team",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Champoionship",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Champiosnship_Team",
                columns: table => new
                {
                    IdTeam = table.Column<int>(nullable: false),
                    IdChampiosnship = table.Column<int>(nullable: false),
                    Score = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champiosnship_Team", x => new { x.IdChampiosnship, x.IdTeam });
                    table.ForeignKey(
                        name: "FK_Champiosnship_Team_Champoionship_IdChampiosnship",
                        column: x => x.IdChampiosnship,
                        principalTable: "Champoionship",
                        principalColumn: "IdChampoionship",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Champiosnship_Team_Team_IdTeam",
                        column: x => x.IdTeam,
                        principalTable: "Team",
                        principalColumn: "IdTeam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player_Team",
                columns: table => new
                {
                    IdTeam = table.Column<int>(nullable: false),
                    IdPlayer = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(maxLength: 300, nullable: false),
                    NumOnShirt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player_Team", x => new { x.IdPlayer, x.IdTeam });
                    table.ForeignKey(
                        name: "FK_Player_Team_Player_IdPlayer",
                        column: x => x.IdPlayer,
                        principalTable: "Player",
                        principalColumn: "IdPlayer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Player_Team_Team_IdTeam",
                        column: x => x.IdTeam,
                        principalTable: "Team",
                        principalColumn: "IdTeam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Champiosnship_Team_IdTeam",
                table: "Champiosnship_Team",
                column: "IdTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Team_IdTeam",
                table: "Player_Team",
                column: "IdTeam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Champiosnship_Team");

            migrationBuilder.DropTable(
                name: "Player_Team");

            migrationBuilder.AlterColumn<int>(
                name: "MaxAge",
                table: "Team",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Champoionship",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
