using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FCR.Migrations
{
    /// <inheritdoc />
    public partial class AddTypeToScaleModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Options_OptionId",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_OptionId",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "OptionId",
                table: "Responses");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Scales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Responses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Scales");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Responses");

            migrationBuilder.AddColumn<Guid>(
                name: "OptionId",
                table: "Responses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Responses_OptionId",
                table: "Responses",
                column: "OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Options_OptionId",
                table: "Responses",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
