using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FazendaBrasil.Migrations
{
    public partial class AddingEntititesRenaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalMedicationsanimalMedications_Animals_AnimalId",
                table: "AnimalMedicationsanimalMedications");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalMedicationsanimalMedications_Medications_MedicationId",
                table: "AnimalMedicationsanimalMedications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalMedicationsanimalMedications",
                table: "AnimalMedicationsanimalMedications");

            migrationBuilder.RenameTable(
                name: "AnimalMedicationsanimalMedications",
                newName: "AnimalMedications");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalMedicationsanimalMedications_MedicationId",
                table: "AnimalMedications",
                newName: "IX_AnimalMedications_MedicationId");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalMedicationsanimalMedications_AnimalId",
                table: "AnimalMedications",
                newName: "IX_AnimalMedications_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalMedications",
                table: "AnimalMedications",
                columns: new[] { "Id", "AnimalId", "MedicationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalMedications_Animals_AnimalId",
                table: "AnimalMedications",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalMedications_Medications_MedicationId",
                table: "AnimalMedications",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalMedications_Animals_AnimalId",
                table: "AnimalMedications");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalMedications_Medications_MedicationId",
                table: "AnimalMedications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalMedications",
                table: "AnimalMedications");

            migrationBuilder.RenameTable(
                name: "AnimalMedications",
                newName: "AnimalMedicationsanimalMedications");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalMedications_MedicationId",
                table: "AnimalMedicationsanimalMedications",
                newName: "IX_AnimalMedicationsanimalMedications_MedicationId");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalMedications_AnimalId",
                table: "AnimalMedicationsanimalMedications",
                newName: "IX_AnimalMedicationsanimalMedications_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalMedicationsanimalMedications",
                table: "AnimalMedicationsanimalMedications",
                columns: new[] { "Id", "AnimalId", "MedicationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalMedicationsanimalMedications_Animals_AnimalId",
                table: "AnimalMedicationsanimalMedications",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalMedicationsanimalMedications_Medications_MedicationId",
                table: "AnimalMedicationsanimalMedications",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
