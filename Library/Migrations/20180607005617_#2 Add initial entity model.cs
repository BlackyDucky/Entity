using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Library.Migrations
{
    public partial class _2Addinitialentitymodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Users",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Users",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Users",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateAdminId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "VehicleBrand",
                table: "Users",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleManfacturer",
                table: "Users",
                maxLength: 70,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<int>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mechanics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    CreateAdminId = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    MechanicName = table.Column<string>(maxLength: 70, nullable: true),
                    PersonnalCount = table.Column<int>(nullable: false),
                    ShopName = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mechanics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mechanics_Admins_CreateAdminId",
                        column: x => x.CreateAdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mechanics_Users_CreateUserId",
                        column: x => x.CreateUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAdminId = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    CustomerService = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LocationAndAccessibilty = table.Column<int>(nullable: false),
                    MechanicId = table.Column<int>(nullable: true),
                    OverAll = table.Column<int>(nullable: false),
                    Reliability = table.Column<int>(nullable: false),
                    ReviewNotes = table.Column<string>(nullable: true),
                    SpeedOfService = table.Column<int>(nullable: false),
                    ValueForPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Admins_CreateAdminId",
                        column: x => x.CreateAdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Mechanics_MechanicId",
                        column: x => x.MechanicId,
                        principalTable: "Mechanics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAdminId = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Label = table.Column<string>(maxLength: 70, nullable: false),
                    MechanicId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialities_Admins_CreateAdminId",
                        column: x => x.CreateAdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Specialities_Mechanics_MechanicId",
                        column: x => x.MechanicId,
                        principalTable: "Mechanics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreateAdminId",
                table: "Users",
                column: "CreateAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Mechanics_CreateAdminId",
                table: "Mechanics",
                column: "CreateAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Mechanics_CreateUserId",
                table: "Mechanics",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CreateAdminId",
                table: "Reviews",
                column: "CreateAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MechanicId",
                table: "Reviews",
                column: "MechanicId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_CreateAdminId",
                table: "Specialities",
                column: "CreateAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_MechanicId",
                table: "Specialities",
                column: "MechanicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Admins_CreateAdminId",
                table: "Users",
                column: "CreateAdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Admins_CreateAdminId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "Mechanics");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Users_CreateAdminId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreateAdminId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VehicleBrand",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VehicleManfacturer",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
