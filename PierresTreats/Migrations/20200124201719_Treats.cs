using Microsoft.EntityFrameworkCore.Migrations;

namespace PierresTreats.Migrations
{
    public partial class Treats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavor_AspNetUsers_UserId",
                table: "Flavor");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Flavor_FlavorId",
                table: "FlavorTreat");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlavorTreat",
                table: "FlavorTreat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavor",
                table: "Flavor");

            migrationBuilder.RenameTable(
                name: "FlavorTreat",
                newName: "FlavorTreats");

            migrationBuilder.RenameTable(
                name: "Flavor",
                newName: "Flavors");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreat_TreatId",
                table: "FlavorTreats",
                newName: "IX_FlavorTreats_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreat_FlavorId",
                table: "FlavorTreats",
                newName: "IX_FlavorTreats_FlavorId");

            migrationBuilder.RenameIndex(
                name: "IX_Flavor_UserId",
                table: "Flavors",
                newName: "IX_Flavors_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlavorTreats",
                table: "FlavorTreats",
                column: "FlavorTreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Flavors_FlavorId",
                table: "FlavorTreats",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Treats_TreatId",
                table: "FlavorTreats",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Flavors_FlavorId",
                table: "FlavorTreats");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Treats_TreatId",
                table: "FlavorTreats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlavorTreats",
                table: "FlavorTreats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors");

            migrationBuilder.RenameTable(
                name: "FlavorTreats",
                newName: "FlavorTreat");

            migrationBuilder.RenameTable(
                name: "Flavors",
                newName: "Flavor");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreats_TreatId",
                table: "FlavorTreat",
                newName: "IX_FlavorTreat_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreats_FlavorId",
                table: "FlavorTreat",
                newName: "IX_FlavorTreat_FlavorId");

            migrationBuilder.RenameIndex(
                name: "IX_Flavors_UserId",
                table: "Flavor",
                newName: "IX_Flavor_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlavorTreat",
                table: "FlavorTreat",
                column: "FlavorTreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavor",
                table: "Flavor",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavor_AspNetUsers_UserId",
                table: "Flavor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Flavor_FlavorId",
                table: "FlavorTreat",
                column: "FlavorId",
                principalTable: "Flavor",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
