using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Family.Manager.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(type: "character varying(255)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(10)", nullable: false),
                    CellPhoneNumber = table.Column<string>(type: "character varying(11)", nullable: false),
                    Religion = table.Column<string>(type: "character varying(80)", nullable: true),
                    ChurchInformation = table.Column<string>(type: "character varying(300)", nullable: true),
                    Observation = table.Column<string>(type: "text", nullable: true),
                    TotalFamilyMembers = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kid",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    KidReligionInformation_IsBaptized = table.Column<bool>(type: "boolean", nullable: true),
                    KidReligionInformation_DoingCatechesis = table.Column<bool>(type: "boolean", nullable: true),
                    KidReligionInformation_DoneCatechesis = table.Column<bool>(type: "boolean", nullable: true),
                    KidReligionInformation_DoingPerse = table.Column<bool>(type: "boolean", nullable: true),
                    KidReligionInformation_DonePerse = table.Column<bool>(type: "boolean", nullable: true),
                    KidReligionInformation_DoingConfirmationSacrament = table.Column<bool>(type: "boolean", nullable: true),
                    KidReligionInformation_DoneConfirmationSacrament = table.Column<bool>(type: "boolean", nullable: true),
                    Observation = table.Column<string>(type: "text", nullable: true),
                    FamilyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kid_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kinship",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(type: "character varying(80)", nullable: false),
                    PersonName = table.Column<string>(type: "character varying(255)", nullable: false),
                    FamilyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kinship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kinship_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kid_FamilyId",
                table: "Kid",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Kinship_FamilyId",
                table: "Kinship",
                column: "FamilyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kid");

            migrationBuilder.DropTable(
                name: "Kinship");

            migrationBuilder.DropTable(
                name: "Family");
        }
    }
}
