    using Microsoft.EntityFrameworkCore.Migrations;

namespace BanHang.Data.Migrations
{
    public partial class note1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BilldetailId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BilldetailId",
                table: "Bill",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Billdetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<float>(nullable: true),
                    Price = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billdetail", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_BilldetailId",
                table: "Product",
                column: "BilldetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_BilldetailId",
                table: "Bill",
                column: "BilldetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Billdetail_BilldetailId",
                table: "Bill",
                column: "BilldetailId",
                principalTable: "Billdetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Billdetail_BilldetailId",
                table: "Product",
                column: "BilldetailId",
                principalTable: "Billdetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Billdetail_BilldetailId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Billdetail_BilldetailId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Billdetail");

            migrationBuilder.DropIndex(
                name: "IX_Product_BilldetailId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Bill_BilldetailId",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "BilldetailId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BilldetailId",
                table: "Bill");
        }
    }
}
