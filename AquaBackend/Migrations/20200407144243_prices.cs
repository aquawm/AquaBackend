using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AquaBackend.Migrations
{
    public partial class prices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecTypeBaseCode = table.Column<string>(nullable: true),
                    PrincipalCurrencyCode = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    MaturityDate = table.Column<DateTime>(nullable: false),
                    RiskCountryCode = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ThruDate = table.Column<DateTime>(nullable: false),
                    PriceValue = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Price");
        }
    }
}
