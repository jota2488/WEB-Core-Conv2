using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_Core_Conv2.Migrations
{
    public partial class migracionproducto2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prueba",
                table: "Paciente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prueba",
                table: "Paciente");
        }
    }
}
