using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Family.Manager.Infrastructure.Migrations
{
    public partial class KidReligionInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KidReligionInformation_DoingCatechesis",
                table: "Kid");

            migrationBuilder.DropColumn(
                name: "KidReligionInformation_DoingConfirmationSacrament",
                table: "Kid");

            migrationBuilder.DropColumn(
                name: "KidReligionInformation_DoingPerse",
                table: "Kid");

            migrationBuilder.DropColumn(
                name: "KidReligionInformation_DoneCatechesis",
                table: "Kid");

            migrationBuilder.DropColumn(
                name: "KidReligionInformation_DoneConfirmationSacrament",
                table: "Kid");

            migrationBuilder.DropColumn(
                name: "KidReligionInformation_DonePerse",
                table: "Kid");

            migrationBuilder.DropColumn(
                name: "KidReligionInformation_IsBaptized",
                table: "Kid");

            migrationBuilder.CreateTable(
                name: "KidReligionInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsBaptized = table.Column<bool>(type: "boolean", nullable: false),
                    DoingCatechesis = table.Column<bool>(type: "boolean", nullable: false),
                    DoneCatechesis = table.Column<bool>(type: "boolean", nullable: false),
                    DoingPerse = table.Column<bool>(type: "boolean", nullable: false),
                    DonePerse = table.Column<bool>(type: "boolean", nullable: false),
                    DoingConfirmationSacrament = table.Column<bool>(type: "boolean", nullable: false),
                    DoneConfirmationSacrament = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KidReligionInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KidReligionInformation_Kid_Id",
                        column: x => x.Id,
                        principalTable: "Kid",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KidReligionInformation");

            migrationBuilder.AddColumn<bool>(
                name: "KidReligionInformation_DoingCatechesis",
                table: "Kid",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KidReligionInformation_DoingConfirmationSacrament",
                table: "Kid",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KidReligionInformation_DoingPerse",
                table: "Kid",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KidReligionInformation_DoneCatechesis",
                table: "Kid",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KidReligionInformation_DoneConfirmationSacrament",
                table: "Kid",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KidReligionInformation_DonePerse",
                table: "Kid",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KidReligionInformation_IsBaptized",
                table: "Kid",
                type: "boolean",
                nullable: true);
        }
    }
}
