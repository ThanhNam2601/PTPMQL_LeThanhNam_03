using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeThanhNam_03.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_PhongBan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    MaPhongBan = table.Column<string>(type: "TEXT", nullable: false),
                    TenPhongBan = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPhongBan);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhongBan");
        }
    }
}
