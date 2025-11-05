using controle_produtos_webapi.Data;
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
    }
}
