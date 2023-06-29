using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiThiNVH.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_NVHCau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NVHCau3",
                columns: table => new
                {
                    Ten = table.Column<string>(type: "TEXT", nullable: false),
                    Lop = table.Column<string>(type: "TEXT", nullable: true),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVHCau3", x => x.Ten);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NVHCau3");
        }
    }
}
