using Microsoft.EntityFrameworkCore.Migrations;

namespace FarukEmlak.Migrations
{
    public partial class farukemlak02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kiraliks_musteris_musteri1MusteriID",
                table: "kiraliks");

            migrationBuilder.DropForeignKey(
                name: "FK_satiliks_musteris_musteri2MusteriID",
                table: "satiliks");

            migrationBuilder.DropIndex(
                name: "IX_satiliks_musteri2MusteriID",
                table: "satiliks");

            migrationBuilder.DropIndex(
                name: "IX_kiraliks_musteri1MusteriID",
                table: "kiraliks");

            migrationBuilder.DropColumn(
                name: "musteri2MusteriID",
                table: "satiliks");

            migrationBuilder.DropColumn(
                name: "musteri1MusteriID",
                table: "kiraliks");

            migrationBuilder.AddColumn<int>(
                name: "MusteriID",
                table: "satiliks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusteriID",
                table: "kiraliks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_satiliks_MusteriID",
                table: "satiliks",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_kiraliks_MusteriID",
                table: "kiraliks",
                column: "MusteriID");

            migrationBuilder.AddForeignKey(
                name: "FK_kiraliks_musteris_MusteriID",
                table: "kiraliks",
                column: "MusteriID",
                principalTable: "musteris",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_satiliks_musteris_MusteriID",
                table: "satiliks",
                column: "MusteriID",
                principalTable: "musteris",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kiraliks_musteris_MusteriID",
                table: "kiraliks");

            migrationBuilder.DropForeignKey(
                name: "FK_satiliks_musteris_MusteriID",
                table: "satiliks");

            migrationBuilder.DropIndex(
                name: "IX_satiliks_MusteriID",
                table: "satiliks");

            migrationBuilder.DropIndex(
                name: "IX_kiraliks_MusteriID",
                table: "kiraliks");

            migrationBuilder.DropColumn(
                name: "MusteriID",
                table: "satiliks");

            migrationBuilder.DropColumn(
                name: "MusteriID",
                table: "kiraliks");

            migrationBuilder.AddColumn<int>(
                name: "musteri2MusteriID",
                table: "satiliks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "musteri1MusteriID",
                table: "kiraliks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_satiliks_musteri2MusteriID",
                table: "satiliks",
                column: "musteri2MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_kiraliks_musteri1MusteriID",
                table: "kiraliks",
                column: "musteri1MusteriID");

            migrationBuilder.AddForeignKey(
                name: "FK_kiraliks_musteris_musteri1MusteriID",
                table: "kiraliks",
                column: "musteri1MusteriID",
                principalTable: "musteris",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_satiliks_musteris_musteri2MusteriID",
                table: "satiliks",
                column: "musteri2MusteriID",
                principalTable: "musteris",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
