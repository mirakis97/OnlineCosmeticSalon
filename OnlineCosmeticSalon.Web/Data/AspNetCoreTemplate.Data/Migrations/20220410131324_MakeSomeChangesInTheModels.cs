using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreTemplate.Data.Migrations
{
    public partial class MakeSomeChangesInTheModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Services",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "SalonServices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SalonServices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Salons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Salons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Appointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Services_IsDeleted",
                table: "Services",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SalonServices_IsDeleted",
                table: "SalonServices",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Salons_IsDeleted",
                table: "Salons",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_IsDeleted",
                table: "Cities",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IsDeleted",
                table: "Categories",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_IsDeleted",
                table: "BlogPosts",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_IsDeleted",
                table: "Appointments",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Services_IsDeleted",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_SalonServices_IsDeleted",
                table: "SalonServices");

            migrationBuilder.DropIndex(
                name: "IX_Salons_IsDeleted",
                table: "Salons");

            migrationBuilder.DropIndex(
                name: "IX_Cities_IsDeleted",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Categories_IsDeleted",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_IsDeleted",
                table: "BlogPosts");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_IsDeleted",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "SalonServices");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SalonServices");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Appointments");
        }
    }
}
