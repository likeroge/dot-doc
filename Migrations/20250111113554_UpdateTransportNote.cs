using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtcAntarctic.Migrations
{
    public partial class UpdateTransportNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FromId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ToId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_TransportNotes_FromId1",
                table: "TransportNotes",
                column: "FromId1");

            migrationBuilder.CreateIndex(
                name: "IX_TransportNotes_ToId1",
                table: "TransportNotes",
                column: "ToId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Places_FromId1",
                table: "TransportNotes",
                column: "FromId1",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Places_ToId1",
                table: "TransportNotes",
                column: "ToId1",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Places_FromId1",
                table: "TransportNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Places_ToId1",
                table: "TransportNotes");

            migrationBuilder.DropIndex(
                name: "IX_TransportNotes_FromId1",
                table: "TransportNotes");

            migrationBuilder.DropIndex(
                name: "IX_TransportNotes_ToId1",
                table: "TransportNotes");

            migrationBuilder.DropColumn(
                name: "FromId1",
                table: "TransportNotes");

            migrationBuilder.DropColumn(
                name: "ToId1",
                table: "TransportNotes");
        }
    }
}
