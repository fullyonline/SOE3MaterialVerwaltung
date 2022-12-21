using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOE3MaterialVerwaltung.Migrations
{
    /// <inheritdoc />
    public partial class umbenennen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Materialgroups_MaterialgroupId",
                table: "Materials");

            migrationBuilder.DropTable(
                name: "Materialgroups");

            migrationBuilder.CreateTable(
                name: "Materialgruppe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materialgruppe", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Materialgruppe_MaterialgroupId",
                table: "Materials",
                column: "MaterialgroupId",
                principalTable: "Materialgruppe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Materialgruppe_MaterialgroupId",
                table: "Materials");

            migrationBuilder.DropTable(
                name: "Materialgruppe");

            migrationBuilder.CreateTable(
                name: "Materialgroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materialgroups", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Materialgroups_MaterialgroupId",
                table: "Materials",
                column: "MaterialgroupId",
                principalTable: "Materialgroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
