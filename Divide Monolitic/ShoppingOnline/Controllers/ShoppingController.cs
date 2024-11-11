using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingOnline.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShoppingController : ControllerBase
{
    private readonly UseCaseApplication _shop;

    public ShoppingController(UseCaseApplication shop)
    {
        _shop = shop;
    }

    [HttpGet("/getall")]
    public ActionResult<IEnumerable<Shopping>> GetAll()
    {
        var lst = _shop.GetAllAsync();

        if (lst.Result == null)
            return NotFound("No hay registros.");

        return Ok(lst.Result);
    }

    [HttpGet("/getbyid")]
    public ActionResult<Shopping> Get([FromQuery] int id)
    {
        var articulo = _shop.GetById(id);

        if (articulo.Result == null)
            return NotFound("Artículo inexistente.");

        return Ok(articulo.Result);
    }
}
