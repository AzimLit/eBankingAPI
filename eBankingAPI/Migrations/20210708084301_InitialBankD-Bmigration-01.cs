using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBankingAPI.Migrations
{
    public partial class InitialBankDBmigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AcnumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustId = table.Column<int>(type: "int", nullable: false),
                    BId = table.Column<int>(type: "int", nullable: false),
                    Opening_balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Atype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Astatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AcnumberId);
                });

            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    BId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bcity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.BId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ltname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobileno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustId);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Custid = table.Column<int>(type: "int", nullable: false),
                    Bid = table.Column<int>(type: "int", nullable: false),
                    Loan_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                });

            migrationBuilder.CreateTable(
                name: "Trandetails",
                columns: table => new
                {
                    TnumberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AcnumberId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dot = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Medium_of_transaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transaction_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transaction_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trandetails", x => x.TnumberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Trandetails");
        }
    }
}
