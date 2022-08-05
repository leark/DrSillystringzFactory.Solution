using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class add_RepairLicenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepairLicenses",
                columns: table => new
                {
                    RepairLicenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EngineerId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MachineId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EngineerId1 = table.Column<int>(type: "int", nullable: true),
                    MachineId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairLicenses", x => x.RepairLicenseId);
                    table.ForeignKey(
                        name: "FK_RepairLicenses_Engineers_EngineerId1",
                        column: x => x.EngineerId1,
                        principalTable: "Engineers",
                        principalColumn: "EngineerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepairLicenses_Machines_MachineId1",
                        column: x => x.MachineId1,
                        principalTable: "Machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepairLicenses_EngineerId1",
                table: "RepairLicenses",
                column: "EngineerId1");

            migrationBuilder.CreateIndex(
                name: "IX_RepairLicenses_MachineId1",
                table: "RepairLicenses",
                column: "MachineId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepairLicenses");
        }
    }
}
