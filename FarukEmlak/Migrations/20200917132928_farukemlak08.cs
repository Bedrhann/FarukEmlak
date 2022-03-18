using Microsoft.EntityFrameworkCore.Migrations;

namespace FarukEmlak.Migrations
{
    public partial class farukemlak08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kiraliks_musteris_MusteriID",
                table: "kiraliks");

            migrationBuilder.DropForeignKey(
                name: "FK_satiliks_musteris_MusteriID",
                table: "satiliks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_satiliks",
                table: "satiliks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_musteris",
                table: "musteris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kiraliks",
                table: "kiraliks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admins",
                table: "admins");

            migrationBuilder.RenameTable(
                name: "satiliks",
                newName: "Satiliks");

            migrationBuilder.RenameTable(
                name: "musteris",
                newName: "Musteris");

            migrationBuilder.RenameTable(
                name: "kiraliks",
                newName: "Kiraliks");

            migrationBuilder.RenameTable(
                name: "admins",
                newName: "Admins");

            migrationBuilder.RenameIndex(
                name: "IX_satiliks_MusteriID",
                table: "Satiliks",
                newName: "IX_Satiliks_MusteriID");

            migrationBuilder.RenameIndex(
                name: "IX_kiraliks_MusteriID",
                table: "Kiraliks",
                newName: "IX_Kiraliks_MusteriID");

            migrationBuilder.AlterColumn<int>(
                name: "MusteriID",
                table: "Satiliks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MusteriID",
                table: "Kiraliks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Satiliks",
                table: "Satiliks",
                column: "SatilikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musteris",
                table: "Musteris",
                column: "MusteriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kiraliks",
                table: "Kiraliks",
                column: "KiralikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kiraliks_Musteris_MusteriID",
                table: "Kiraliks",
                column: "MusteriID",
                principalTable: "Musteris",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Satiliks_Musteris_MusteriID",
                table: "Satiliks",
                column: "MusteriID",
                principalTable: "Musteris",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kiraliks_Musteris_MusteriID",
                table: "Kiraliks");

            migrationBuilder.DropForeignKey(
                name: "FK_Satiliks_Musteris_MusteriID",
                table: "Satiliks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Satiliks",
                table: "Satiliks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musteris",
                table: "Musteris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kiraliks",
                table: "Kiraliks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.RenameTable(
                name: "Satiliks",
                newName: "satiliks");

            migrationBuilder.RenameTable(
                name: "Musteris",
                newName: "musteris");

            migrationBuilder.RenameTable(
                name: "Kiraliks",
                newName: "kiraliks");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "admins");

            migrationBuilder.RenameIndex(
                name: "IX_Satiliks_MusteriID",
                table: "satiliks",
                newName: "IX_satiliks_MusteriID");

            migrationBuilder.RenameIndex(
                name: "IX_Kiraliks_MusteriID",
                table: "kiraliks",
                newName: "IX_kiraliks_MusteriID");

            migrationBuilder.AlterColumn<int>(
                name: "MusteriID",
                table: "satiliks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MusteriID",
                table: "kiraliks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_satiliks",
                table: "satiliks",
                column: "SatilikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_musteris",
                table: "musteris",
                column: "MusteriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kiraliks",
                table: "kiraliks",
                column: "KiralikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admins",
                table: "admins",
                column: "AdminID");

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
    }
}
