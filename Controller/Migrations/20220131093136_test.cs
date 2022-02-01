using Microsoft.EntityFrameworkCore.Migrations;

namespace Controller.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Vehicles_VehicleId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_VehicleId",
                table: "Workers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Workers_VehicleId",
                table: "Workers",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Vehicles_VehicleId",
                table: "Workers",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
