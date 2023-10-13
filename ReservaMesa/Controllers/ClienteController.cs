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
            return Ok(_clienteService.());
        }

        [HttpPost, AllowAnonymous]
        public IActionResult Post(ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(_clienteService.Post(clienteDTO));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(_clienteService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(ClienteDTO clienteDTO)
        {
            return Ok(_clienteService.Put(clienteDTO));
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            return Ok(_clienteService.Delete(Id));
        }

       
    }
}
