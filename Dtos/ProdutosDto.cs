using System.ComponentModel.DataAnnotations;

namespace controle_produtos_webapi.Dtos
{
    public class ProdutosDto
    {
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe a marca do produto")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Informe o fabricante do produto")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "Informe o sabor do produto")]
        public string Sabor { get; set; }

        [Required(ErrorMessage = "Informe a data de vencimento do produto")]
        [DataType(DataType.Date, ErrorMessage = "A data de vencimento informada é invalida!")]
        public DateOnly DataVencimento { get; set; }

        [Required(ErrorMessage = "Informe o estoque do produto")]
        [Range(0, int.MaxValue, ErrorMessage = "O estoque informado é inválido!")]
        public int Estoque { get; set; }
    }
}
