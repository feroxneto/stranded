using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class Attachment_Citizen_NOK_TravelingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Institution");

            migrationBuilder.DropColumn(
                name: "TelefoneOther",
                table: "Institution");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "VisitPurpose",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "VisitPurpose",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "VisitPurpose",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "VisitPurpose",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Stranded",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Stranded",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Stranded",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Stranded",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Relationship",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Relationship",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Relationship",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Relationship",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Notification",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Notification",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Notification",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Notification",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Institution",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Institution",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Institution",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Institution",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Institution",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumberOther",
                table: "Institution",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "HealthStatus",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "HealthStatus",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "HealthStatus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "HealthStatus",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "DocumentType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DocumentType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "DocumentType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "DocumentType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "CitizenshipType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CitizenshipType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "CitizenshipType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CitizenshipType",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Citizen",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Surname = table.Column<string>(maxLength: 20, nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DocumentNumber = table.Column<string>(maxLength: 50, nullable: false),
                    CitizenshipTypeId = table.Column<long>(nullable: false),
                    DocumentTypeId = table.Column<long>(nullable: false),
                    CountryId = table.Column<long>(nullable: false),
                    HealthStatusId = table.Column<long>(nullable: false),
                    StrandedId = table.Column<long>(nullable: false),
                    VisitPurposeId = table.Column<long>(nullable: true),
                    LockOutCountryId = table.Column<long>(nullable: true),
                    LockOutCityId = table.Column<long>(nullable: true),
                    LockOutStatus = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    PhoneNumberOther = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    CurrentAddress = table.Column<string>(maxLength: 100, nullable: true),
                    PermanentResidenceAddress = table.Column<string>(maxLength: 100, nullable: true),
                    IsVerified = table.Column<bool>(nullable: false),
                    CitizenComment = table.Column<string>(type: "ntext", nullable: true),
                    AdminPublicComment = table.Column<string>(type: "ntext", nullable: true),
                    AdminInternalComment = table.Column<string>(type: "ntext", nullable: true),
            
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citizen_CitizenshipType_CitizenshipTypeId",
                        column: x => x.CitizenshipTypeId,
                        principalTable: "CitizenshipType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citizen_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citizen_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citizen_HealthStatus_HealthStatusId",
                        column: x => x.HealthStatusId,
                        principalTable: "HealthStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citizen_City_LockOutCityId",
                        column: x => x.LockOutCityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citizen_Country_LockOutCountryId",
                        column: x => x.LockOutCountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citizen_Stranded_StrandedId",
                        column: x => x.StrandedId,
                        principalTable: "Stranded",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citizen_VisitPurpose_VisitPurposeId",
                        column: x => x.VisitPurposeId,
                        principalTable: "VisitPurpose",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 20, nullable: false),
                    CitizenId = table.Column<long>(nullable: false),
                    Picture = table.Column<byte[]>(type: "image", nullable: true),
                    AttachmentType = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_Citizen_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NextOfKin",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    CitizenId = table.Column<long>(nullable: false),
                    RelationshipTypeId = table.Column<long>(nullable: true),
                    CountryId = table.Column<long>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    PhoneNumberOther = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextOfKin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NextOfKin_Citizen_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NextOfKin_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NextOfKin_Relationship_RelationshipTypeId",
                        column: x => x.RelationshipTypeId,
                        principalTable: "Relationship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelingInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitizenId = table.Column<long>(nullable: false),
                    HasValidAirlineTicket = table.Column<bool>(nullable: false),
                    AirlineName = table.Column<string>(maxLength: 50, nullable: false),
                    OriginalReturnDate = table.Column<DateTime>(nullable: true),
                    CityOfDestinyId = table.Column<long>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelingInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelingInfo_Citizen_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelingInfo_City_CityOfDestinyId",
                        column: x => x.CityOfDestinyId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_CitizenId",
                table: "Attachment",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizen_CitizenshipTypeId",
                table: "Citizen",
                column: "CitizenshipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizen_CountryId",
                table: "Citizen",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizen_DocumentTypeId",
                table: "Citizen",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizen_HealthStatusId",
                table: "Citizen",
                column: "HealthStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizen_LockOutCityId",
                table: "Citizen",
                column: "LockOutCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizen_LockOutCountryId",
                table: "Citizen",
                column: "LockOutCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizen_StrandedId",
                table: "Citizen",
                column: "StrandedId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizen_VisitPurposeId",
                table: "Citizen",
                column: "VisitPurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKin_CitizenId",
                table: "NextOfKin",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKin_CountryId",
                table: "NextOfKin",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKin_RelationshipTypeId",
                table: "NextOfKin",
                column: "RelationshipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelingInfo_CitizenId",
                table: "TravelingInfo",
                column: "CitizenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelingInfo_CityOfDestinyId",
                table: "TravelingInfo",
                column: "CityOfDestinyId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "NextOfKin");

            migrationBuilder.DropTable(
                name: "TravelingInfo");

            migrationBuilder.DropTable(
                name: "Citizen");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "VisitPurpose");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VisitPurpose");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "VisitPurpose");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "VisitPurpose");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Stranded");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Stranded");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Stranded");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Stranded");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Relationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Relationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Relationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Relationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Institution");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Institution");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Institution");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Institution");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Institution");

            migrationBuilder.DropColumn(
                name: "PhoneNumberOther",
                table: "Institution");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "HealthStatus");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "HealthStatus");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "HealthStatus");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "HealthStatus");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "DocumentType");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DocumentType");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "DocumentType");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "DocumentType");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "CitizenshipType");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CitizenshipType");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "CitizenshipType");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CitizenshipType");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Institution",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefoneOther",
                table: "Institution",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
