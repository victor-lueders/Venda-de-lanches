namespace MVC_Curso.Models
{
    public class Lanche
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string ShortDescription { get; set; }
        public string DetailedDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFavorite { get; set; }
        public bool InStock { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
