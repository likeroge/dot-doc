using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtcAntarctic.Migrations
{
    public partial class AddPobColToTransportNotesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Pob",
                table: "TransportNotes",
                type: "INTEGER",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pob",
                table: "TransportNotes");
        }
    }
}
