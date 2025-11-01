using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FCR.Migrations
{
    /// <inheritdoc />
    public partial class AddClarificationToQuestionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Clarification",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clarification",
                table: "Questions");
        }
    }
}
