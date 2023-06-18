using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarSecurity.Migrations
{
    /// <inheritdoc />
    public partial class addTestimonials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TProfession = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TImage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employee");
        }
    }
}
