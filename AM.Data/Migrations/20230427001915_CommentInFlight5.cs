﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Data.Migrations
{
    public partial class CommentInFlight5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTraveller",
                table: "Passengers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "IsTraveller",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
