using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reserva.Application.DTO;
using Reserva.Application.Interfaces;
using System.Security.Claims;

namespace ReservaMesa.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteAppService _clienteService;

        public ClienteController(IClienteAppService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clienteService.GetAll());
        }

        [HttpPost, AllowAnonymous]
        public IActionResult Post(ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _clienteService.Post(clienteDTO);
            return Ok("Cliente Cadastrado");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_clienteService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(ClienteDTO clienteDTO)
        {
            _clienteService.Put(clienteDTO);
            return Ok("Cliente alterado");
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _clienteService.Delete(Id);
            return Ok("Cliente excluído");
        }
               
    }
}
