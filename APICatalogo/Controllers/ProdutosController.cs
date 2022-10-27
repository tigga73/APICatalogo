using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly ApiCatalogoContext _context;

    public ProdutosController(ApiCatalogoContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> Get()
    {
        var produtos = _context.Produtos?.ToList();
        if(produtos is null)
        {
            return NotFound("¯¯\\_(ヅ)_/¯¯ Poxa, não encontramos nenhum produto em nossa base.");
        }
        return produtos;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Produto> Get(int id)
    {
        var produto = _context.Produtos?.FirstOrDefault(p => p.ProdutoId == id);
        if(produto is null)
        {
            return NotFound("¯¯\\_(ヅ)_/¯¯ Poxa, seu produto não foi encontrado.");
        }
        return produto;
    }
}
