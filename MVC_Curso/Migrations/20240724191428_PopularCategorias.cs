using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Curso.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Name,Description) " +
                "VALUES('Fast food', 'Lanches rápidos e leves')");

            migrationBuilder.Sql("INSERT INTO Categorias(Name,Description) " +
                "VALUES('Natural', 'Lanches feitos com ingredientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
