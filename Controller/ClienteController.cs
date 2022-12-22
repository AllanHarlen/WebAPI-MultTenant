using AntaresAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UsuarioAPI.Controller
{
    [ApiController]
    public class ClienteController : ControllerBase
    {

        [HttpGet("/{empresa}/Cliente")]
        public async Task<IActionResult> getClientes(
            [FromRoute] string empresa,
            [FromServices] AntaresContext context            
            ) 
        {
            var clientes = await context.Clientes.ToListAsync();
            return Ok(clientes);
        }
    }
}
