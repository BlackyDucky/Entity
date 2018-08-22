using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Library.Migrations
{
    public partial class _2afteraddingLibraryAssetasParent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Mechanics_MechanicId",
                table: "Specialities");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Admins_CreateAdminId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Mechanics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "libraryAssets");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "libraryAssets",
                newName: "User_IsActive");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "libraryAssets",
                newName: "User_CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreateAdminId",
                table: "libraryAssets",
                newName: "User_CreateAdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CreateAdminId",
                table: "libraryAssets",
                newName: "IX_libraryAssets_User_CreateAdminId");

            migrationBuilder.AlterColumn<bool>(
                name: "User_IsActive",
                table: "libraryAssets",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "User_CreateDate",
                table: "libraryAssets",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "libraryAssets",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "libraryAssets",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateAdminId",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MechanicName",
                table: "libraryAssets",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnalCount",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "libraryAssets",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Review_CreateAdminId",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Review_CreateDate",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerService",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Review_IsActive",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationAndAccessibilty",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MechanicId",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OverAll",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reliability",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewNotes",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpeedOfService",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValueForPrice",
                table: "libraryAssets",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_libraryAssets",
                table: "libraryAssets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_libraryAssets_CreateAdminId",
                table: "libraryAssets",
                column: "CreateAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_libraryAssets_CreateUserId",
                table: "libraryAssets",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_libraryAssets_Review_CreateAdminId",
                table: "libraryAssets",
                column: "Review_CreateAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_libraryAssets_CustomerId",
                table: "libraryAssets",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_libraryAssets_MechanicId",
                table: "libraryAssets",
                column: "MechanicId");

            migrationBuilder.AddForeignKey(
                name: "FK_libraryAssets_Admins_CreateAdminId",
                table: "libraryAssets",
                column: "CreateAdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_libraryAssets_libraryAssets_CreateUserId",
                table: "libraryAssets",
                column: "CreateUserId",
                principalTable: "libraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_libraryAssets_Admins_Review_CreateAdminId",
                table: "libraryAssets",
                column: "Review_CreateAdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_libraryAssets_libraryAssets_CustomerId",
                table: "libraryAssets",
                column: "CustomerId",
                principalTable: "libraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_libraryAssets_libraryAssets_MechanicId",
                table: "libraryAssets",
                column: "MechanicId",
                principalTable: "libraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_libraryAssets_Admins_User_CreateAdminId",
                table: "libraryAssets",
                column: "User_CreateAdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_libraryAssets_MechanicId",
                table: "Specialities",
                column: "MechanicId",
                principalTable: "libraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_libraryAssets_Admins_CreateAdminId",
                table: "libraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_libraryAssets_libraryAssets_CreateUserId",
                table: "libraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_libraryAssets_Admins_Review_CreateAdminId",
                table: "libraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_libraryAssets_libraryAssets_CustomerId",
                table: "libraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_libraryAssets_libraryAssets_MechanicId",
                table: "libraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_libraryAssets_Admins_User_CreateAdminId",
                table: "libraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_libraryAssets_MechanicId",
                table: "Specialities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_libraryAssets",
                table: "libraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_libraryAssets_CreateAdminId",
                table: "libraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_libraryAssets_CreateUserId",
                table: "libraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_libraryAssets_Review_CreateAdminId",
                table: "libraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_libraryAssets_CustomerId",
                table: "libraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_libraryAssets_MechanicId",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "CreateAdminId",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "MechanicName",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "PersonnalCount",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "Review_CreateAdminId",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "Review_CreateDate",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "CustomerService",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "Review_IsActive",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "LocationAndAccessibilty",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "MechanicId",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "OverAll",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "Reliability",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "ReviewNotes",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "SpeedOfService",
                table: "libraryAssets");

            migrationBuilder.DropColumn(
                name: "ValueForPrice",
                table: "libraryAssets");

            migrationBuilder.RenameTable(
                name: "libraryAssets",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "User_IsActive",
                table: "Users",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "User_CreateDate",
                table: "Users",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "User_CreateAdminId",
                table: "Users",
                newName: "CreateAdminId");

            migrationBuilder.RenameIndex(
                name: "IX_libraryAssets_User_CreateAdminId",
                table: "Users",
                newName: "IX_Users_CreateAdminId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Users",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Mechanics_MechanicId",
                table: "Specialities",
                column: "MechanicId",
                principalTable: "Mechanics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Admins_CreateAdminId",
                table: "Users",
                column: "CreateAdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
