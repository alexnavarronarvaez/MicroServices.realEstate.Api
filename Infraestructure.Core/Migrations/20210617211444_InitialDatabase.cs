using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Core.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Owner",
                schema: "dbo",
                columns: table => new
                {
                    IdOwner = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(400)", nullable: true),
                    Address = table.Column<string>(type: "varchar(2000)", nullable: true),
                    Photo = table.Column<string>(type: "varchar(2000)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    CreationUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    ModificationUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.IdOwner);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                schema: "dbo",
                columns: table => new
                {
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(250)", nullable: true),
                    Address = table.Column<string>(type: "varchar(2000)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(22,4)", nullable: false),
                    CodeInternational = table.Column<string>(type: "varchar(100)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    IdOwner = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    CreationUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    ModificationUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.IdProperty);
                    table.ForeignKey(
                        name: "FK_Property_Owner_IdOwner",
                        column: x => x.IdOwner,
                        principalSchema: "dbo",
                        principalTable: "Owner",
                        principalColumn: "IdOwner",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyImage",
                schema: "dbo",
                columns: table => new
                {
                    IdPropertyImage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProperty = table.Column<int>(type: "int", nullable: false),
                    TypeFile = table.Column<string>(type: "varchar(10)", nullable: true),
                    File = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyImage", x => x.IdPropertyImage);
                    table.ForeignKey(
                        name: "FK_PropertyImage_Property_IdProperty",
                        column: x => x.IdProperty,
                        principalSchema: "dbo",
                        principalTable: "Property",
                        principalColumn: "IdProperty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTrace",
                schema: "dbo",
                columns: table => new
                {
                    IdPropertyTrace = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProperty = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(22,4)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(22,4)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    CreationUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    ModificationUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTrace", x => x.IdPropertyTrace);
                    table.ForeignKey(
                        name: "FK_PropertyTrace_Property_IdProperty",
                        column: x => x.IdProperty,
                        principalSchema: "dbo",
                        principalTable: "Property",
                        principalColumn: "IdProperty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Property_IdOwner",
                schema: "dbo",
                table: "Property",
                column: "IdOwner");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImage_IdProperty",
                schema: "dbo",
                table: "PropertyImage",
                column: "IdProperty");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTrace_IdProperty",
                schema: "dbo",
                table: "PropertyTrace",
                column: "IdProperty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyImage",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PropertyTrace",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Property",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Owner",
                schema: "dbo");
        }
    }
}
