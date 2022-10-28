using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriasController : ControllerBase
{
    private readonly ApiCatalogoContext _context;

    public CategoriasController(ApiCatalogoContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Categoria>> Get()
    {
        var categorias = _context.Categorias?.ToList();

        if (categorias is null)
            return NotFound("¯¯\\_(ヅ)_/¯¯ Poxa, não encontramos nenhum produto em nossa base.");

        return categorias;  
    }

    [HttpGet("{id:int}")]
    public ActionResult<Categoria> Get(int id)
    {
        var categoria = _context.Categorias?.FirstOrDefault(c => id == c.CategoriaId);

        if (categoria is null)
            return NotFound("¯¯\\_(ヅ)_/¯¯ Poxa, seu produto não foi encontrado.");

        return categoria;
    }
}
