using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtcAntarctic.Migrations
{
    public partial class UpdateTransportNote2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Places_FromId1",
                table: "TransportNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Places_ToId1",
                table: "TransportNotes");

            migrationBuilder.AlterColumn<long>(
                name: "ToId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<long>(
                name: "FromId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Places_FromId1",
                table: "TransportNotes",
                column: "FromId1",
                principalTable: "Places",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportNotes_Places_ToId1",
                table: "TransportNotes",
                column: "ToId1",
                principalTable: "Places",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Places_FromId1",
                table: "TransportNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportNotes_Places_ToId1",
                table: "TransportNotes");

            migrationBuilder.AlterColumn<long>(
                name: "ToId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "FromId1",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

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
    }
}
