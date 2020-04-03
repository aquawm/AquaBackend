using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AquaBackend.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioCode = table.Column<string>(nullable: true),
                    TransactionCode = table.Column<string>(nullable: true),
                    TranCodeLabel = table.Column<string>(nullable: true),
                    SecTypeCode1 = table.Column<string>(nullable: true),
                    Symbol1 = table.Column<string>(nullable: true),
                    FullName1 = table.Column<string>(nullable: true),
                    PrincipalCurrencyCode1 = table.Column<string>(nullable: true),
                    SecTypeCode2 = table.Column<string>(nullable: true),
                    Symbol2 = table.Column<string>(nullable: true),
                    FullName2 = table.Column<string>(nullable: true),
                    PrincipalCurrencyCode2 = table.Column<string>(nullable: true),
                    TradeDate = table.Column<DateTime>(nullable: true),
                    SettleDate = table.Column<DateTime>(nullable: true),
                    Quantity = table.Column<float>(nullable: true),
                    TradeAmount = table.Column<float>(nullable: true),
                    UnitPrice = table.Column<float>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
