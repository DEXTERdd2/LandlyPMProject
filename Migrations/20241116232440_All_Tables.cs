using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Landly.Migrations
{
    /// <inheritdoc />
    public partial class All_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_BlackHat",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_BlackHat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Domains",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Domains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_WhiteHat",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_WhiteHat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_SubDomains",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainId = table.Column<long>(type: "bigint", nullable: true),
                    WhiteHatId = table.Column<long>(type: "bigint", nullable: true),
                    BlackHatId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_SubDomains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_SubDomains_Tb_BlackHat_BlackHatId",
                        column: x => x.BlackHatId,
                        principalTable: "Tb_BlackHat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tb_SubDomains_Tb_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Tb_Domains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tb_SubDomains_Tb_WhiteHat_WhiteHatId",
                        column: x => x.WhiteHatId,
                        principalTable: "Tb_WhiteHat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_SubDomains_BlackHatId",
                table: "Tb_SubDomains",
                column: "BlackHatId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_SubDomains_DomainId",
                table: "Tb_SubDomains",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_SubDomains_WhiteHatId",
                table: "Tb_SubDomains",
                column: "WhiteHatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_SubDomains");

            migrationBuilder.DropTable(
                name: "Tb_Users");

            migrationBuilder.DropTable(
                name: "Tb_BlackHat");

            migrationBuilder.DropTable(
                name: "Tb_Domains");

            migrationBuilder.DropTable(
                name: "Tb_WhiteHat");
        }
    }
}
