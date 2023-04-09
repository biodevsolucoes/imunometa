using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BFBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SlugUrl2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "SlugUrl",
                table: "Post",
                type: "varchar(1000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "SlugUrl",
                table: "Categoria",
                type: "varchar(1000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome", "SlugUrl" },
                values: new object[,]
                {
                    { new Guid("272fb22f-4b2e-49e6-b591-e27ffbc5822f"), "Desenvolvimento", "" },
                    { new Guid("7cd97d71-4c20-442b-bd09-227c590013e9"), "OFF", "" },
                    { new Guid("9d7520d2-9a59-42c1-82e0-f8af2a462643"), "DevOps", "" },
                    { new Guid("c13d795f-925d-4804-94ac-bac4338c4a54"), "Segurança", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("272fb22f-4b2e-49e6-b591-e27ffbc5822f"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("7cd97d71-4c20-442b-bd09-227c590013e9"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("9d7520d2-9a59-42c1-82e0-f8af2a462643"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("c13d795f-925d-4804-94ac-bac4338c4a54"));

            migrationBuilder.AlterColumn<string>(
                name: "SlugUrl",
                table: "Post",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1000)");

            migrationBuilder.AlterColumn<string>(
                name: "SlugUrl",
                table: "Categoria",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1000)");

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
    }
}
