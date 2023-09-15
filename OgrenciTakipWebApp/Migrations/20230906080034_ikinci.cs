using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciTakipWebApp.Migrations
{
    /// <inheritdoc />
    public partial class ikinci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Students",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Students",
                newName: "email");
        }
    }
}
