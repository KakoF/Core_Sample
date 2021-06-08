
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CredisanOpenBanking.Domain.Dtos.Usuario;
using CredisanOpenBanking.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController: ControllerBase
{
    private readonly IUsuarioService _service;
    public UsuarioController(IUsuarioService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var result = await _service.Get();
        return Ok(new {message = result.Count() > 0 ? "Usuários encontrados": "Nenhum usuário encontrado", data = result });
    }

    [HttpGet]
    [Route("{id}", Name = "GetWithId")]
    public async Task<ActionResult> Get(int id)
    {
        var result = await _service.Get(id);
        return Ok(new { message = "Usuário encontrado", data = result });
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateUsuarioDto usuario)
    {
        try
        {
            var result = await _service.Post(usuario);
            if (result != null)
                return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), new { message = "Usuário cadastrado", data = result });
            return BadRequest();
        }
        catch (ArgumentException e)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        }
    }
    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateUsuarioDto usuario)
    {
        try
        {
            var result = await _service.Put(id, usuario);
            if (result != null)
                return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), new { message = "Usuário alterado", data = result });
            return BadRequest();
        }
        catch (ArgumentException e)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        }
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        try
        {
            var result = await _service.Delete(id);
            return Ok(new { message = "Usuário excluído", data = result });
        }
        catch (ArgumentException e)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        }
    }
}