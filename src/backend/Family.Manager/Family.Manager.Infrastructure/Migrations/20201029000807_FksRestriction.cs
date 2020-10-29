using Microsoft.EntityFrameworkCore.Migrations;

namespace Family.Manager.Infrastructure.Migrations
{
    public partial class FksRestriction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Family_FamilyId",
                table: "Kid");

            migrationBuilder.DropForeignKey(
                name: "FK_KidReligionInformation_Kid_Id",
                table: "KidReligionInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_Kinship_Family_FamilyId",
                table: "Kinship");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Family_FamilyId",
                table: "Kid",
                column: "FamilyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KidReligionInformation_Kid_Id",
                table: "KidReligionInformation",
                column: "Id",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kinship_Family_FamilyId",
                table: "Kinship",
                column: "FamilyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Family_FamilyId",
                table: "Kid");

            migrationBuilder.DropForeignKey(
                name: "FK_KidReligionInformation_Kid_Id",
                table: "KidReligionInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_Kinship_Family_FamilyId",
                table: "Kinship");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Family_FamilyId",
                table: "Kid",
                column: "FamilyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KidReligionInformation_Kid_Id",
                table: "KidReligionInformation",
                column: "Id",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kinship_Family_FamilyId",
                table: "Kinship",
                column: "FamilyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
