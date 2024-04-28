using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94662212-6024-468e-9952-f8731d35cba8", "AQAAAAIAAYagAAAAEOGf6Vnno+yhK8Cuk24ftTqYdn/vu0Zas1rtkAqMUuY6cQa9JBCGtWtMKP/azJdtzQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5c02fd7-f423-470b-b364-38edded91fc6", "AQAAAAIAAYagAAAAEBcoMMDsJABUSsCwp/yo76OA76VfmPxNdSM9EnHSjO17KItgk/DkKob3PDRe9MnfBg==" });
        }
    }
}
