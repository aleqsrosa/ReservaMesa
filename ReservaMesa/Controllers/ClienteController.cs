using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reserva.Application.DTO;
using Reserva.Application.Interfaces;
using System.Security.Claims;

namespace ReservaMesa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteAppService _clienteService;

        public ClienteController(IClienteAppService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet("BuscarCliente")]
        public IActionResult Get()
        {
            return Ok(_clienteService.GetAll());
        }

        [HttpPost("CadastrarCliente"), AllowAnonymous]
        public IActionResult Post(ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _clienteService.Post(clienteDTO);
            return Ok("Cliente Cadastrado");
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_clienteService.GetById(id));
        }

        [HttpPut("AlterarCliente")]
        public IActionResult Put(ClienteDTO clienteDTO)
        {
            _clienteService.Put(clienteDTO);
            return Ok("Cliente alterado");
        }

        [HttpDelete("DeletarCliente")]
        public IActionResult Delete(int Id)
        {
            _clienteService.Delete(Id);
            return Ok("Cliente excluído");
        }
               
    }
}
