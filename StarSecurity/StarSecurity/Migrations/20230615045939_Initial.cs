using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarSecurity.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENumber = table.Column<int>(type: "int", nullable: false),
                    EQualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ECode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EDepartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ERole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EGrade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EClients = table.Column<int>(type: "int", nullable: false),
                    EAchievements = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    CPassword = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}
