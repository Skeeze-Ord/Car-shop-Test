﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop2.Migrations
{
    public partial class ShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "Car",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "ShopCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    СarId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ShopCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCartItems_Car_СarId",
                        column: x => x.СarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_СarId",
                table: "ShopCartItems",
                column: "СarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCartItems");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Car",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
