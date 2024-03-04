using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workaround.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "People",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                FirstName = table.Column<string>(nullable: true),
                LastName = table.Column<string>(nullable: true),
                NationalIdentity = table.Column<long>(nullable: false),
                DateOfBirthYear = table.Column<int>(nullable: false),
                HasMask = table.Column<bool>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_People", x => x.Id);
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
