using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blalogin.Data.Migrations
{
    public partial class pk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dailyproducts",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Shift = table.Column<string>(nullable: true),
                    SmNo = table.Column<int>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    AgentName = table.Column<string>(nullable: true),
                    BMCM = table.Column<string>(nullable: true),
                    Cans = table.Column<int>(nullable: false),
                    Kgs = table.Column<int>(nullable: false),
                    Ltrs = table.Column<int>(nullable: false),
                    Fat = table.Column<int>(nullable: false),
                    CLR = table.Column<int>(nullable: false),
                    SNF = table.Column<int>(nullable: false),
                    FatKg = table.Column<int>(nullable: false),
                    SnfKg = table.Column<int>(nullable: false),
                    Weighment = table.Column<string>(nullable: true),
                    QcEntry = table.Column<string>(nullable: true),
                    QtyOrg = table.Column<int>(nullable: false),
                    FatOrg = table.Column<int>(nullable: false),
                    SnfOrg = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dailyproducts", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Routename = table.Column<string>(nullable: true),
                    Supervisorname = table.Column<string>(nullable: true),
                    Billdays = table.Column<int>(nullable: false),
                    Code = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dailyproducts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
