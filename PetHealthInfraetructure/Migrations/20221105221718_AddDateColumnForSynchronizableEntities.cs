using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHealth.Infrastructure.Migrations
{
    public partial class AddDateColumnForSynchronizableEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPet_Pets_PetsPetID",
                table: "ApplicationUserPet");

            migrationBuilder.RenameColumn(
                name: "PetsPetID",
                table: "ApplicationUserPet",
                newName: "PetsId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Vaccines",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "VaccineConsultations",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Surgeries",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Radiologies",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "PrescriptionDrug",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Pathologies",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "MedicalVisits",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "LabTests",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Drugs",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Condition",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSynchronized",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "AllergyConsultations",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDBDate",
                table: "Allergies",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserPet_Pets_PetsId",
                table: "ApplicationUserPet",
                column: "PetsId",
                principalTable: "Pets",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPet_Pets_PetsId",
                table: "ApplicationUserPet");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Vaccines");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "VaccineConsultations");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Surgeries");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Radiologies");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "PrescriptionDrug");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Pathologies");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "MedicalVisits");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "LabTests");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Drugs");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Condition");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastSynchronized",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "AllergyConsultations");

            migrationBuilder.DropColumn(
                name: "CreatedOnDBDate",
                table: "Allergies");

            migrationBuilder.RenameColumn(
                name: "PetsId",
                table: "ApplicationUserPet",
                newName: "PetsPetID");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserPet_Pets_PetsPetID",
                table: "ApplicationUserPet",
                column: "PetsPetID",
                principalTable: "Pets",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
