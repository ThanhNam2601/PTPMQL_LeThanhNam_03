using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeThanhNam_03.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_NhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "TEXT", nullable: false),
                    TenNhanvien = table.Column<string>(type: "TEXT", nullable: false),
                    MaPhongBan = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
