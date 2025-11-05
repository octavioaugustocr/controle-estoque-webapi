using controle_produtos_webapi.Services.Produtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace controle_produtos_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosService _produtosService;

        public ProdutosController(IProdutosService produtosService)
        {
            _produtosService = produtosService;
        }

        [HttpGet]
        public IActionResult BuscarTodosProdutos()
        {
            var listaProdutos = _produtosService.BuscarTodosProdutos();
            if (listaProdutos == null || listaProdutos.Count <= 0)
                return BadRequest("Não foi encontrado nenhum produto!");

            return Ok(listaProdutos);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarProdutoPorId(int id)
        {
            var produto = _produtosService.BuscarProdutoPorId(id);
            if (produto == null)
                return BadRequest($"Não foi encontrado nenhum produto com esse ID ({id})!");

            return Ok(produto);
        }
    }
}
