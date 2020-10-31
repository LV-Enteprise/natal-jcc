using Microsoft.EntityFrameworkCore.Migrations;

namespace Family.Manager.Infrastructure.Migrations
{
    public partial class AddDescriptionToFamilyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Family",
                type: "character varying(255)",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Family");
        }
    }
}
