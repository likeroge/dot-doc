using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtcAntarctic.Migrations
{
    public partial class UpdateTransportNote5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId1",
                table: "TransportNotes");

            migrationBuilder.AlterColumn<long>(
                name: "VehicleId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId1",
                table: "TransportNotes",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId1",
                table: "TransportNotes");

            migrationBuilder.AlterColumn<long>(
                name: "VehicleId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Vehicles_VehicleId1",
                table: "TransportNotes",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
