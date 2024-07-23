using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Curso.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do lanche")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string DetailedDescription { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Price { get; set; }

        [Display(Name = "Caminho imagem normal")]
        public string ImageUrl { get; set; }

        [Display(Name = "Caminho imagem miniatura")]
        public string ThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsFavorite { get; set; }

        [Display(Name = "Estoque")]
        public bool InStock { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
