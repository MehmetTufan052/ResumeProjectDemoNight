using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeProjectDemoNight.Migrations
{
    /// <inheritdoc />
    public partial class mig1_add_spanclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SkillSpanClass",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillSpanClass",
                table: "Skills");
        }
    }
}
