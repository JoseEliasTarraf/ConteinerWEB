using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBTest.Migrations
{
    public partial class AddTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "conteiners",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "conteiners");
        }
    }
}
