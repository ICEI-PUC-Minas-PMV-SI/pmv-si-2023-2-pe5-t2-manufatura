using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a cor")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o preço")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade em estoque")]
        [Display(Name = "Quantidade em estoque")]
        public int QuantidadeEstoque { get; set; }

    }
}
