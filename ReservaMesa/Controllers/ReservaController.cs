using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reserva.Application.DTO;
using Reserva.Application.Interfaces;

namespace ReservaMesa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaAppService _reservaService;

        public ReservaController(IReservaAppService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpGet("BuscarReservas")]
        public IActionResult BuscarCliente()
        {
            return Ok(_reservaService.GetAll());
        }

        [HttpPost("FazerReserva")]
        public IActionResult FazerReserva(ReservaDTO ReservaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _reservaService.Post(ReservaDTO);
            return Ok("Reserva Cadastrada");
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return Ok(_reservaService.GetById(id));
        }

        [HttpPut("AlterarReserva")]
        public IActionResult AlterarReserva(ReservaDTO ReservaDTO)
        {
            _reservaService.Put(ReservaDTO);
            return Ok("Reserva alterada");
        }

        [HttpDelete("CancelarReserva")]
        public IActionResult CancelarReserva(int Id)
        {
            _reservaService.Delete(Id);
            return Ok("Reserva excluída");
        }
    }
}
