using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLoja.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Tamanho máximo de 80 e mínimo 10 caracteres")]
        [Required(ErrorMessage = "Informe o nome do produto")]
        [Display(Name = "Nome")]
        public string ProdutpName { get; set; }
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Tamanho máximo de 200 e mínimo 10 caracteres")]
        [Required(ErrorMessage = "Informe a descriçao")]
        [Display(Name = "Nome")]
        public string DescriçaoSimples { get; set; }
        [StringLength(400, MinimumLength = 10, ErrorMessage = "Tamanho máximo de 400 e mínimo 10 caracteres")]
        [Required(ErrorMessage = "Informe a descriçao detalhada")]
        [Display(Name = "Nome")]
        public string DescriçaoCompleta { get; set; }
        [Required(ErrorMessage = "Informe o preço")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }
        public string ImagremTunbUrl { get; set; }
        public bool Preferidos { get; set; }
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
 