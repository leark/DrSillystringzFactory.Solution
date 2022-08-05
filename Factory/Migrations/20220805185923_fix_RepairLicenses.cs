using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class fix_RepairLicenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicenses_Engineers_EngineerId1",
                table: "RepairLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicenses_Machines_MachineId1",
                table: "RepairLicenses");

            migrationBuilder.DropIndex(
                name: "IX_RepairLicenses_EngineerId1",
                table: "RepairLicenses");

            migrationBuilder.DropIndex(
                name: "IX_RepairLicenses_MachineId1",
                table: "RepairLicenses");

            migrationBuilder.DropColumn(
                name: "EngineerId1",
                table: "RepairLicenses");

            migrationBuilder.DropColumn(
                name: "MachineId1",
                table: "RepairLicenses");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "RepairLicenses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EngineerId",
                table: "RepairLicenses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairLicenses_EngineerId",
                table: "RepairLicenses",
                column: "EngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairLicenses_MachineId",
                table: "RepairLicenses",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicenses_Engineers_EngineerId",
                table: "RepairLicenses",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicenses_Machines_MachineId",
                table: "RepairLicenses",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicenses_Engineers_EngineerId",
                table: "RepairLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicenses_Machines_MachineId",
                table: "RepairLicenses");

            migrationBuilder.DropIndex(
                name: "IX_RepairLicenses_EngineerId",
                table: "RepairLicenses");

            migrationBuilder.DropIndex(
                name: "IX_RepairLicenses_MachineId",
                table: "RepairLicenses");

            migrationBuilder.AlterColumn<string>(
                name: "MachineId",
                table: "RepairLicenses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EngineerId",
                table: "RepairLicenses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EngineerId1",
                table: "RepairLicenses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MachineId1",
                table: "RepairLicenses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairLicenses_EngineerId1",
                table: "RepairLicenses",
                column: "EngineerId1");

            migrationBuilder.CreateIndex(
                name: "IX_RepairLicenses_MachineId1",
                table: "RepairLicenses",
                column: "MachineId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicenses_Engineers_EngineerId1",
                table: "RepairLicenses",
                column: "EngineerId1",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicenses_Machines_MachineId1",
                table: "RepairLicenses",
                column: "MachineId1",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
