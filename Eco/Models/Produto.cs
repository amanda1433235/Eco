using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Eco.Models
{
    [Table("Produtos")]
    public class Produto
    {
       
         [Key]
            public int Codigo { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o nome do produto!")]
            public string Nome { get; set; }

            public string Imagem { get; set; }

            [Required(ErrorMessage = "Obrigatório informar a descrição do produto!")]
            [Display(Name = "Descrição")]
            public string Descricao { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o tipo de produto!")]
            [Display(Name = "Tipo")]
            public TipoProduto TipoProduto { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o valor do produto!")]
            public double Valor { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o frete do produto!")]
            public double Frete { get; set; }

            [Required(ErrorMessage = "Obrigatório informar a quantidade no estoque!")]
            public int Estoque { get; set; }        

    }

    public enum TipoProduto
    {
        Vegano = 0,
        NaoVegano = 1
    }
}
