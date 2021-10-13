using Microsoft.EntityFrameworkCore.Migrations;

namespace CancionWeb.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cancion",
                columns: table => new
                {
                    NombreCancion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NombreAutor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LinkCancion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancion", x => x.NombreCancion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancion");
        }
    }
}
