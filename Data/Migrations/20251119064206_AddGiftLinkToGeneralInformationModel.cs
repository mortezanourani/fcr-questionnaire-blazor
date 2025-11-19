using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FCR.Migrations
{
    /// <inheritdoc />
    public partial class AddGiftLinkToGeneralInformationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GeneralInformation",
                keyColumn: "Id",
                keyValue: new Guid("8bbc07a9-d9f0-4d9d-ab3c-8ce05aad03da"));

            migrationBuilder.AddColumn<string>(
                name: "GiftLink",
                table: "GeneralInformation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "GeneralInformation",
                columns: new[] { "Id", "ApplicationTitle", "FirstPageDescription", "GiftLink", "LastPageDescription" },
                values: new object[] { new Guid("725d4736-58bb-4117-9c67-88956b8142a1"), "", "", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GeneralInformation",
                keyColumn: "Id",
                keyValue: new Guid("725d4736-58bb-4117-9c67-88956b8142a1"));

            migrationBuilder.DropColumn(
                name: "GiftLink",
                table: "GeneralInformation");

            migrationBuilder.InsertData(
                table: "GeneralInformation",
                columns: new[] { "Id", "ApplicationTitle", "FirstPageDescription", "LastPageDescription" },
                values: new object[] { new Guid("8bbc07a9-d9f0-4d9d-ab3c-8ce05aad03da"), "", "", "" });
        }
    }
}
