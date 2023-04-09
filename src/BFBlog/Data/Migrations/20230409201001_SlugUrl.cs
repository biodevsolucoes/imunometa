using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BFBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SlugUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("294c9729-fe88-426e-8626-5026c1c9f62f"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("67986aaf-2cee-4ac7-b0d1-a398a8dbe5c7"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("77df7240-d8f3-4365-a58f-25fe2f2d0a75"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("939ac56e-4ac3-4974-a95c-c19be8f8985c"));

            migrationBuilder.AddColumn<string>(
                name: "SlugUrl",
                table: "Post",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SlugUrl",
                table: "Categoria",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome", "SlugUrl" },
                values: new object[,]
                {
                    { new Guid("0814b799-752b-41c8-8dfd-08b21f7c19bc"), "OFF", "" },
                    { new Guid("191684d9-9a3b-4e7c-b874-c23a587b8453"), "DevOps", "" },
                    { new Guid("2451b1ac-368b-4083-b8e4-114cc06bf03a"), "Segurança", "" },
                    { new Guid("51f1d5e9-42d7-4259-a7cc-300213efe3fe"), "Desenvolvimento", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("0814b799-752b-41c8-8dfd-08b21f7c19bc"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("191684d9-9a3b-4e7c-b874-c23a587b8453"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("2451b1ac-368b-4083-b8e4-114cc06bf03a"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("51f1d5e9-42d7-4259-a7cc-300213efe3fe"));

            migrationBuilder.DropColumn(
                name: "SlugUrl",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "SlugUrl",
                table: "Categoria");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("294c9729-fe88-426e-8626-5026c1c9f62f"), "DevOps" },
                    { new Guid("67986aaf-2cee-4ac7-b0d1-a398a8dbe5c7"), "OFF" },
                    { new Guid("77df7240-d8f3-4365-a58f-25fe2f2d0a75"), "Desenvolvimento" },
                    { new Guid("939ac56e-4ac3-4974-a95c-c19be8f8985c"), "Segurança" }
                });
        }
    }
}
