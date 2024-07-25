using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Curso.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (Name,ShortDescription,DetailedDescription,Price,ImageUrl,ThumbnailUrl,IsFavorite,InStock,CategoriaId) VALUES ('Duplo bacon', 'Sanduíche com 2 hambúrgueres, acompanhados de fatias de bacon', 'Ingredientes: pão com gergelim, 2 hambúrgueres 85g, bacon fatiado, queijo cheddar', 27.90, 'https://github.com/victor-lueders/Venda-de-lanches/blob/master/MVC_Curso/wwwroot/images/lanche1.jpg?raw=true', 'https://github.com/victor-lueders/Venda-de-lanches/blob/master/MVC_Curso/wwwroot/images/lanche1.jpg?raw=true', 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (Name,ShortDescription,DetailedDescription,Price,ImageUrl,ThumbnailUrl,IsFavorite,InStock,CategoriaId) VALUES ('X bacon', 'Sanduíche com 1 hambúrguer, acompanhado de fatias de bacon, alface, tomate e cebola', 'Ingredientes: pão com gergilim, 1 hambúrguer 160g, bacon fatiado, queijo cheddar, alface, tomate e cebola', 25.90, 'https://github.com/victor-lueders/Venda-de-lanches/blob/master/MVC_Curso/wwwroot/images/lanche1.jpg?raw=true', 'https://github.com/victor-lueders/Venda-de-lanches/blob/master/MVC_Curso/wwwroot/images/lanche1.jpg?raw=true', 0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (Name,ShortDescription,DetailedDescription,Price,ImageUrl,ThumbnailUrl,IsFavorite,InStock,CategoriaId) VALUES ('Lanche natural', 'Sanduíche com 1 hambúrguer, acompanhado de alface, tomate, picles, maionese e cebola roxa', 'Ingredientes: pão integral, 1 hambúrguer 100g, alface, tomate, picles, maionese e cebola roxa', 29.90, 'https://github.com/victor-lueders/Venda-de-lanches/blob/master/MVC_Curso/wwwroot/images/lanches1.jpg?raw=true', 'https://github.com/victor-lueders/Venda-de-lanches/blob/master/MVC_Curso/wwwroot/images/lanches1.jpg?raw=true', 0, 1, 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
