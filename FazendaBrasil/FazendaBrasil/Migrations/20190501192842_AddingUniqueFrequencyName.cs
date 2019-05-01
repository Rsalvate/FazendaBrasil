using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FazendaBrasil.Migrations
{
    public partial class AddingUniqueFrequencyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Frequencies",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Frequencies_Name",
                table: "Frequencies",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Frequencies_Name",
                table: "Frequencies");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Frequencies",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
