using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Curso.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
