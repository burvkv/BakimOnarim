using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bakimonarim.dataaccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_Varlik",
                columns: table => new
                {
                    VarlikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VarlikKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VarlikAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrupID = table.Column<int>(type: "int", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KM = table.Column<int>(type: "int", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaseNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotorNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuskiNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yil = table.Column<int>(type: "int", nullable: false),
                    Saat = table.Column<int>(type: "int", nullable: false),
                    LastikEbat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastikSayi = table.Column<int>(type: "int", nullable: false),
                    Sube = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuzenleyenKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_Varlik", x => x.VarlikID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_VGrup",
                columns: table => new
                {
                    GrupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracSinifID = table.Column<int>(type: "int", nullable: false),
                    GrupMarka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastikTip = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_VGrup", x => x.GrupID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_Varlik");

            migrationBuilder.DropTable(
                name: "TBL_VGrup");
        }
    }
}
