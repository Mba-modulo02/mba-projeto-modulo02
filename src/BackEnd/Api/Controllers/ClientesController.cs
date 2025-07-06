using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
    
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]    
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;

        }        
        [HttpGet]
        [ProducesResponseType(typeof(List<Cliente>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(List<Cliente>), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    

    public async Task<ActionResult<List<Cliente>>> Get(CancellationToken cancellationToken)
        {
            List<Cliente>? resultado = await _clienteService.GetAsync(cancellationToken);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

    }

