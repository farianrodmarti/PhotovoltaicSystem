using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PhotovoltaicSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Housing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HouseNumber = table.Column<int>(type: "integer", nullable: false),
                    Address_Street = table.Column<string>(type: "text", nullable: false),
                    Address_City = table.Column<string>(type: "text", nullable: false),
                    Address_PostalCode = table.Column<string>(type: "text", nullable: false),
                    Address_Country = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inverter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    MaximumPower = table.Column<double>(type: "double precision", nullable: false),
                    PhotovoltaicSystemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inverter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NumberOfApartment = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Housing_Id",
                        column: x => x.Id,
                        principalTable: "Housing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Houses_Housing_Id",
                        column: x => x.Id,
                        principalTable: "Housing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhotovoltaicSystem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HasBattery = table.Column<bool>(type: "boolean", nullable: false),
                    InverterId = table.Column<Guid>(type: "uuid", nullable: false),
                    HousingId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotovoltaicSystem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotovoltaicSystem_Housing_HousingId",
                        column: x => x.HousingId,
                        principalTable: "Housing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhotovoltaicSystem_Inverter_InverterId",
                        column: x => x.InverterId,
                        principalTable: "Inverter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    PhotovoltaicSystemInstallId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PhtovoltaicSystemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => new { x.PhotovoltaicSystemInstallId, x.Id });
                    table.ForeignKey(
                        name: "FK_Maintenances_PhotovoltaicSystem_PhotovoltaicSystemInstallId",
                        column: x => x.PhotovoltaicSystemInstallId,
                        principalTable: "PhotovoltaicSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolarPanel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    Capacity_Value = table.Column<int>(type: "integer", nullable: false),
                    Capacity_Unit = table.Column<string>(type: "text", nullable: false),
                    PhtovoltaicSystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    PhotovoltaicSystemInstallId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarPanel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarPanel_PhotovoltaicSystem_PhotovoltaicSystemInstallId",
                        column: x => x.PhotovoltaicSystemInstallId,
                        principalTable: "PhotovoltaicSystem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhotovoltaicSystem_HousingId",
                table: "PhotovoltaicSystem",
                column: "HousingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotovoltaicSystem_InverterId",
                table: "PhotovoltaicSystem",
                column: "InverterId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarPanel_PhotovoltaicSystemInstallId",
                table: "SolarPanel",
                column: "PhotovoltaicSystemInstallId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropTable(
                name: "SolarPanel");

            migrationBuilder.DropTable(
                name: "PhotovoltaicSystem");

            migrationBuilder.DropTable(
                name: "Housing");

            migrationBuilder.DropTable(
                name: "Inverter");
        }
    }
}
