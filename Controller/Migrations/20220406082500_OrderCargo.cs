using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Controller.Migrations
{
    public partial class OrderCargo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "orderEnum",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CargoId",
                table: "Orders",
                column: "CargoId",
                unique: true,
                filter: "[CargoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cargos_CargoId",
                table: "Orders",
                column: "CargoId",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cargos_CargoId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CargoId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "orderEnum",
                table: "Orders");
        }
    }
}
