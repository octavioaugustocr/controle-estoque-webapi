using controle_produtos_webapi.Data;

namespace controle_produtos_webapi.Services.Produtos
{
    public class ProdutosService : IProdutosService
    {
        private readonly AppDbContext _appDbContext;

        public ProdutosService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
