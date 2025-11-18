using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FCR.Migrations
{
    /// <inheritdoc />
    public partial class AddGeneralInformationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstPageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastPageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInformation", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GeneralInformation",
                columns: new[] { "Id", "ApplicationTitle", "FirstPageDescription", "LastPageDescription" },
                values: new object[] { new Guid("8bbc07a9-d9f0-4d9d-ab3c-8ce05aad03da"), "", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralInformation");
        }
    }
}
