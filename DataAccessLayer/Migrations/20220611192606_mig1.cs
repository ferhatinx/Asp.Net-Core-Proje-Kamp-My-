using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AboutDETAILS1 = table.Column<string>(type: "text", nullable: true),
                    AboutDETAILS2 = table.Column<string>(type: "text", nullable: true),
                    AboutIMAGE1 = table.Column<string>(type: "text", nullable: true),
                    AboutIMAGE2 = table.Column<string>(type: "text", nullable: true),
                    AboutMAPLOCATION = table.Column<string>(type: "text", nullable: true),
                    AboutSTATUS = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryNAME = table.Column<string>(type: "text", nullable: true),
                    CategoryDescription = table.Column<string>(type: "text", nullable: true),
                    CategoryStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactUSERNAME = table.Column<string>(type: "text", nullable: true),
                    ContactMAIL = table.Column<string>(type: "text", nullable: true),
                    ContactSUBJECT = table.Column<string>(type: "text", nullable: true),
                    ContactMESSAGE = table.Column<string>(type: "text", nullable: true),
                    ContactDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ContactStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriterID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WriterNAME = table.Column<string>(type: "text", nullable: true),
                    WriterIMAGE = table.Column<string>(type: "text", nullable: true),
                    WriterABOUT = table.Column<string>(type: "text", nullable: true),
                    WriterMAIL = table.Column<string>(type: "text", nullable: true),
                    WriterPassword = table.Column<string>(type: "text", nullable: true),
                    WriterStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriterID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlogTITLE = table.Column<string>(type: "text", nullable: true),
                    BlogCONTENT = table.Column<string>(type: "text", nullable: true),
                    BlogTHUMBNAILIMAGE = table.Column<string>(type: "text", nullable: true),
                    BlogIMAGE = table.Column<string>(type: "text", nullable: true),
                    BlogCREATEDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BlogStatus = table.Column<bool>(type: "boolean", nullable: false),
                    CategoryID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CommentUSERNAME = table.Column<string>(type: "text", nullable: true),
                    CommentTITLE = table.Column<string>(type: "text", nullable: true),
                    CommentCONTENT = table.Column<string>(type: "text", nullable: true),
                    CommentDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CommentStatus = table.Column<bool>(type: "boolean", nullable: false),
                    BlogID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogID",
                table: "Comments",
                column: "BlogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Writers");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
