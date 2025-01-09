using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtcAntarctic.Migrations
{
    public partial class AddPlacesAndTransportNotesModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Places_FromId",
                table: "TransportNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Places_ToId",
                table: "TransportNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId",
                table: "TransportNotes");

            migrationBuilder.DropIndex(
                name: "IX_TransportNotes_FromId",
                table: "TransportNotes");

            migrationBuilder.DropIndex(
                name: "IX_TransportNotes_ToId",
                table: "TransportNotes");

            migrationBuilder.DropIndex(
                name: "IX_TransportNotes_VehicleId",
                table: "TransportNotes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TransportNotes_FromId",
                table: "TransportNotes",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportNotes_ToId",
                table: "TransportNotes",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportNotes_VehicleId",
                table: "TransportNotes",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Places_FromId",
                table: "TransportNotes",
                column: "FromId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Places_ToId",
                table: "TransportNotes",
                column: "ToId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId",
                table: "TransportNotes",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
