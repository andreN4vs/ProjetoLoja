using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLoja.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100,ErrorMessage ="Tamanho máximo de 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string categoriaName { get; set; }
        [StringLength(300, ErrorMessage = "Tamanho máximo de 300 caracteres")]
        [Required(ErrorMessage = "Informe o Descriçao")]
        [Display(Name = "Nome")]
        public string Descriçao { get; set; }

        public List<Produto> Produtos { get; set; }
    
    }
}
