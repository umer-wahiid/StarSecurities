using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarSecurity.Migrations
{
    /// <inheritdoc />
    public partial class addLogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceLogo",
                table: "Services",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceLogo",
                table: "Services");
        }
    }
}
