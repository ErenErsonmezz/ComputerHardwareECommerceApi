using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerHardwareECommerceApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseFiles_Products_ProductId",
                table: "BaseFiles");

            migrationBuilder.DropIndex(
                name: "IX_BaseFiles_ProductId",
                table: "BaseFiles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseFiles");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "BaseFiles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseFiles",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "BaseFiles",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseFiles_ProductId",
                table: "BaseFiles",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseFiles_Products_ProductId",
                table: "BaseFiles",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
