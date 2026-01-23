using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeProjectDemoNight.Migrations
{
    /// <inheritdoc />
    public partial class mig_change_socialmedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialMedia",
                table: "Abouts",
                newName: "SocialMedia3");

            migrationBuilder.AddColumn<string>(
                name: "SocialMedia1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SocialMedia2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialMedia1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SocialMedia2",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "SocialMedia3",
                table: "Abouts",
                newName: "SocialMedia");
        }
    }
}
