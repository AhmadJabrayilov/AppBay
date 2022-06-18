using Microsoft.EntityFrameworkCore.Migrations;

namespace AppBayBackEnd.Migrations
{
    public partial class addModerCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModernCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModernTitle = table.Column<string>(nullable: true),
                    ModernDesc = table.Column<string>(nullable: true),
                    ModernIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModernCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModernCard");
        }
    }
}
