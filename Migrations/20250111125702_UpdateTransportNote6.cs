using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtcAntarctic.Migrations
{
    public partial class UpdateTransportNote6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId1",
                table: "TransportNotes");

            migrationBuilder.DropIndex(
                name: "IX_TransportNotes_VehicleId1",
                table: "TransportNotes");

            migrationBuilder.DropColumn(
                name: "VehicleId1",
                table: "TransportNotes");

            migrationBuilder.CreateIndex(
                name: "IX_TransportNotes_VehicleId",
                table: "TransportNotes",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId",
                table: "TransportNotes",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId",
                table: "TransportNotes");

            migrationBuilder.DropIndex(
                name: "IX_TransportNotes_VehicleId",
                table: "TransportNotes");

            migrationBuilder.AddColumn<long>(
                name: "VehicleId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportNotes_VehicleId1",
                table: "TransportNotes",
                column: "VehicleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId1",
                table: "TransportNotes",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }
    }
}
