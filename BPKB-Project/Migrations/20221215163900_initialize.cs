using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BPKBProject.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    locationid = table.Column<string>(name: "location_id", type: "nvarchar(450)", nullable: false),
                    locationname = table.Column<string>(name: "location_name", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.locationid);
                });

            migrationBuilder.CreateTable(
                name: "bpkbs",
                columns: table => new
                {
                    agreementnumber = table.Column<string>(name: "agreement_number", type: "nvarchar(450)", nullable: false),
                    bpkbno = table.Column<string>(name: "bpkb_no", type: "nvarchar(max)", nullable: false),
                    branchid = table.Column<string>(name: "branch_id", type: "nvarchar(max)", nullable: false),
                    bpkbdate = table.Column<DateTime>(name: "bpkb_date", type: "datetime2", nullable: false),
                    fakturno = table.Column<string>(name: "faktur_no", type: "nvarchar(max)", nullable: false),
                    fakturdate = table.Column<DateTime>(name: "faktur_date", type: "datetime2", nullable: false),
                    locationid = table.Column<string>(name: "location_id", type: "nvarchar(450)", nullable: false),
                    policeno = table.Column<string>(name: "police_no", type: "nvarchar(max)", nullable: false),
                    bpkbdatein = table.Column<DateTime>(name: "bpkb_date_in", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bpkbs", x => x.agreementnumber);
                    table.ForeignKey(
                        name: "FK_bpkbs_locations_location_id",
                        column: x => x.locationid,
                        principalTable: "locations",
                        principalColumn: "location_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "locations",
                columns: new[] { "location_id", "location_name" },
                values: new object[,]
                {
                    { "L001", "Bali" },
                    { "L002", "Jakarta" },
                    { "L003", "Sumatera" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bpkbs_location_id",
                table: "bpkbs",
                column: "location_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bpkbs");

            migrationBuilder.DropTable(
                name: "locations");
        }
    }
}
