using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHealth.Infrastructure.Migrations
{
    public partial class updatepersonpet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Owner",
                table: "PersonHasPet",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "PersonHasPet");
        }
    }
}
