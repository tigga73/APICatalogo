using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            return NotFound("¯¯\\_(ヅ)_/¯¯ Poxa, não encontramos nenhum produto em nossa base.");

        return produtos;
    }

    [HttpGet("{id:int}", Name="ObterProduto")]
    public ActionResult<Produto> Get(int id)
    {
        var produto = _context.Produtos?.FirstOrDefault(p => p.ProdutoId == id);
        if(produto is null)
            return NotFound("¯¯\\_(ヅ)_/¯¯ Poxa, seu produto não foi encontrado.");

        return produto;
    }

    [HttpPost]
    public ActionResult Post(Produto produto)
    {
        if (produto is null)
            return BadRequest("ಠ_ಠ Parâmetros inválidos.");

        _context.Produtos?.Add(produto);
        _context.SaveChanges();

        return new CreatedAtRouteResult("ObterProduto",
            new { id = produto.ProdutoId }, produto);
    }

    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Produto produto)
    {
        if(id != produto.ProdutoId || produto is null)
            return BadRequest("ಠ_ಠ Parâmetros inválidos.");

        _context.Entry(produto).State = EntityState.Modified;
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var produto = _context.Produtos?.FirstOrDefault(p => p.ProdutoId == id);
        
        if(produto is null)
            return NotFound("¯¯\\_(ヅ)_/¯¯ Poxa, seu produto não foi encontrado.");

        _context.Produtos?.Remove(produto);
        _context.SaveChanges();

        return Ok();
    }
}
