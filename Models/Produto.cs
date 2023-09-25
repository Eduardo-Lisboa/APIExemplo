using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int IdProduto { get; set; }
        public string Descricao { get; set; }

        public double Preco { get; set; }

        public int QtdMin { get; set; }

        public string Categoria { get; set; }

        public double Tamanho { get; set; }

        public string Cor { get; set; }
    }
}
