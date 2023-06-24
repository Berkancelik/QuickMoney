using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccsessLayer.Migrations
{
    public partial class mig_add_description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "CustomerAccounts",
                newName: "AppUserID");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "CustomerAccounts",
                newName: "CustomerAccountNumber");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "CustomerAccounts",
                newName: "CustomerAccountCurrency");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "CustomerAccounts",
                newName: "CustomerAccountBalance");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccounts_AppUserId",
                table: "CustomerAccounts",
                newName: "IX_CustomerAccounts_AppUserID");

            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountProcessID",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CustomerAccountProcesses",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverID",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderID",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_ReceiverID",
                table: "CustomerAccountProcesses",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_SenderID",
                table: "CustomerAccountProcesses",
                column: "SenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesses",
                column: "ReceiverID",
                principalTable: "CustomerAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesses",
                column: "SenderID",
                principalTable: "CustomerAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserID",
                table: "CustomerAccounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserID",
                table: "CustomerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_ReceiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_SenderID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "CustomerAccountProcessID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "ReceiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "CustomerAccountProcesses");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "CustomerAccounts",
                newName: "AppUserId");

            migrationBuilder.RenameColumn(
                name: "CustomerAccountNumber",
                table: "CustomerAccounts",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "CustomerAccountCurrency",
                table: "CustomerAccounts",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "CustomerAccountBalance",
                table: "CustomerAccounts",
                newName: "Balance");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccounts_AppUserID",
                table: "CustomerAccounts",
                newName: "IX_CustomerAccounts_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
