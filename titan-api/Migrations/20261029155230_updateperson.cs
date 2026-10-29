using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace titan_api.Migrations
{
    /// <inheritdoc />
    public partial class updateperson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Persons");
        }
    }
}
