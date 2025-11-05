using System.ComponentModel.DataAnnotations;

namespace controle_produtos_webapi.Dtos
{
    public class ProdutosDto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
        public string Sabor { get; set; }
        public DateOnly DataVencimento { get; set; }
        public int Estoque { get; set; }
    }
}
