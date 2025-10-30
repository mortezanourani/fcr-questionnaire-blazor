using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FCR.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFcrQuestionnaireModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_LikertOptions_OptionId",
                table: "Responses");

            migrationBuilder.DropTable(
                name: "LikertOptions");

            migrationBuilder.AddColumn<Guid>(
                name: "ScaleId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Questionnaires",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Scales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Scales_ScaleId",
                        column: x => x.ScaleId,
                        principalTable: "Scales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ScaleId",
                table: "Questions",
                column: "ScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_ScaleId",
                table: "Options",
                column: "ScaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Scales_ScaleId",
                table: "Questions",
                column: "ScaleId",
                principalTable: "Scales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Options_OptionId",
                table: "Responses",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Scales_ScaleId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Options_OptionId",
                table: "Responses");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Scales");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ScaleId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ScaleId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Questionnaires");

            migrationBuilder.CreateTable(
                name: "LikertOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reverse = table.Column<bool>(type: "bit", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikertOptions", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_LikertOptions_OptionId",
                table: "Responses",
                column: "OptionId",
                principalTable: "LikertOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
