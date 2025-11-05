using controle_produtos_webapi.Dtos;
using controle_produtos_webapi.Models;

namespace controle_produtos_webapi.Services.Produtos
{
    public interface IProdutosService
    {
        List<ProdutosModel> BuscarTodosProdutos();
        ProdutosModel BuscarProdutoPorId(int id);
        bool AdicionarProduto(ProdutosDto produtosDto);
    }
}
