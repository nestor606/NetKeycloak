using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraEstructure.Migrations
{
    /// <inheritdoc />
    public partial class DockerPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityCard = table.Column<int>(type: "int", nullable: false),
                    IdentityType = table.Column<string>(type: "VARCHAR(5)", maxLength: 5, nullable: true),
                    Name = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    Profession = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    NumberPhone = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: true),
                    Adress = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    CityID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.ID);
                    table.UniqueConstraint("ALT_IDENTITY", x => x.IdentityCard);
                });

            migrationBuilder.CreateIndex(
                name: "UNIQ_IDENTITYCARD",
                table: "Employee",
                column: "IdentityCard",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UNIQ_NUMBERPHONE",
                table: "Employee",
                column: "NumberPhone",
                unique: true,
                filter: "[NumberPhone] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UNIQID",
                table: "Employee",
                column: "ID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
