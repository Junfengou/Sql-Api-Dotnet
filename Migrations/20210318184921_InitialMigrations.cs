using Microsoft.EntityFrameworkCore.Migrations;

namespace SpicyWebApi.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sqlCommands",
                columns: table => new
                {
                    SqlCmdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SqlCmdLine = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SqlCmdDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sqlCommands", x => x.SqlCmdId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sqlCommands");
        }
    }
}
