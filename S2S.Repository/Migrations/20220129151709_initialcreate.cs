using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace S2S.Repository.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[] { 1, "Чехов" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[] { 2, "Толстой" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[] { 3, "Достоевский" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "PublishedAt", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1903, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Вишнёвый сад" },
                    { 2, 1, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Три сестры" },
                    { 3, 1, new DateTime(1896, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Дядя Ваня" },
                    { 4, 2, new DateTime(1856, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Война и мир" },
                    { 5, 2, new DateTime(1873, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Анна Каренина" },
                    { 6, 2, new DateTime(1889, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Детство" },
                    { 7, 3, new DateTime(1879, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Братья Карамазовы" },
                    { 8, 3, new DateTime(1866, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Преступление и наказание" },
                    { 9, 3, new DateTime(1867, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Идиот" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
