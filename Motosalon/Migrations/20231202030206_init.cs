using Microsoft.EntityFrameworkCore.Migrations;

namespace Motosalon.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mototransports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Volume = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    TypeMotorcycle = table.Column<string>(nullable: true),
                    TypeScooter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mototransports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    Surname = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    BoughtMotoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.UniqueConstraint("AK_Clients_PhoneNumber", x => x.PhoneNumber);
                    table.ForeignKey(
                        name: "FK_Clients_Mototransports_BoughtMotoId",
                        column: x => x.BoughtMotoId,
                        principalTable: "Mototransports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BoughtMotoId",
                table: "Clients",
                column: "BoughtMotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Mototransports");
        }
    }
}
