using Microsoft.EntityFrameworkCore.Migrations;

namespace Family.Manager.Infrastructure.Migrations
{
    public partial class UpdateFkRestrictToCascadeFromTableKidReligion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KidReligionInformation_Kid_Id",
                table: "KidReligionInformation");

            migrationBuilder.AddForeignKey(
                name: "FK_KidReligionInformation_Kid_Id",
                table: "KidReligionInformation",
                column: "Id",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KidReligionInformation_Kid_Id",
                table: "KidReligionInformation");

            migrationBuilder.AddForeignKey(
                name: "FK_KidReligionInformation_Kid_Id",
                table: "KidReligionInformation",
                column: "Id",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
