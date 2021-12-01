using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class UpdatedRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Description_DescriptionId",
                table: "Leads");

            migrationBuilder.DropIndex(
                name: "IX_Leads_DescriptionId",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Leads");

            migrationBuilder.AddColumn<int>(
                name: "LeadsLeadId",
                table: "Description",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Description_LeadsLeadId",
                table: "Description",
                column: "LeadsLeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Description_Leads_LeadsLeadId",
                table: "Description",
                column: "LeadsLeadId",
                principalTable: "Leads",
                principalColumn: "LeadId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Description_Leads_LeadsLeadId",
                table: "Description");

            migrationBuilder.DropIndex(
                name: "IX_Description_LeadsLeadId",
                table: "Description");

            migrationBuilder.DropColumn(
                name: "LeadsLeadId",
                table: "Description");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Leads",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leads_DescriptionId",
                table: "Leads",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Description_DescriptionId",
                table: "Leads",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
