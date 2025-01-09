using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtcAntarctic.Migrations
{
    public partial class AddPlacesAndTransportNotesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportNotes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FromId = table.Column<long>(type: "INTEGER", nullable: false),
                    ToId = table.Column<long>(type: "INTEGER", nullable: false),
                    VehicleId = table.Column<long>(type: "INTEGER", nullable: false),
                    Atd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ata = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Rmk = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportNotes_Places_FromId",
                        column: x => x.FromId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportNotes_Places_ToId",
                        column: x => x.ToId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportNotes_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransportNotes");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
