using controle_produtos_webapi.Data;
using controle_produtos_webapi.Dtos;
using controle_produtos_webapi.Models;

namespace controle_produtos_webapi.Services.Produtos
{
    public class ProdutosService : IProdutosService
    {
        private readonly AppDbContext _appDbContext;

        public ProdutosService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<ProdutosModel> BuscarTodosProdutos()
        {
            return _appDbContext.Produtos.ToList();
        }

        public ProdutosModel BuscarProdutoPorId(int id)
        {
            return _appDbContext.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public bool AdicionarProduto(ProdutosDto produtosDto)
        {
            try
            {
                var produtoModel = new ProdutosModel()
                {
                    Nome = produtosDto.Nome,
                    Preco = produtosDto.Preco,
                    Marca = produtosDto.Marca,
                    Fabricante = produtosDto.Fabricante,
                    Sabor = produtosDto.Sabor,
                    DataVencimento = produtosDto.DataVencimento,
                    Estoque = produtosDto.Estoque
                };

                _appDbContext.Produtos.Add(produtoModel);
                _appDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
