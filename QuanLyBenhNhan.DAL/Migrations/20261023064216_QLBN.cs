using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBenhNhan.DAL.Migrations
{
    /// <inheritdoc />
    public partial class QLBN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TinhTrangs",
                columns: table => new
                {
                    MaTT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTT = table.Column<string>(type: "nvarchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhTrangs", x => x.MaTT);
                });

            migrationBuilder.CreateTable(
                name: "BenhNhans",
                columns: table => new
                {
                    MaBN = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    TenBN = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    MaTT = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BNTXG = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    TinhTrangMaTT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhNhans", x => x.MaBN);
                    table.ForeignKey(
                        name: "FK_BenhNhans_TinhTrangs_TinhTrangMaTT",
                        column: x => x.TinhTrangMaTT,
                        principalTable: "TinhTrangs",
                        principalColumn: "MaTT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenhNhans_TinhTrangMaTT",
                table: "BenhNhans",
                column: "TinhTrangMaTT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenhNhans");

            migrationBuilder.DropTable(
                name: "TinhTrangs");
        }
    }
}
