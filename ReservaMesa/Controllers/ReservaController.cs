using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reserva.Application.DTO;
using Reserva.Application.Interfaces;

namespace ReservaMesa.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaAppService _reservaService;

        public ReservaController(IReservaAppService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_reservaService.GetAll());
        }

        [HttpPost, AllowAnonymous]
        public IActionResult Post(ReservaDTO ReservaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _reservaService.Post(ReservaDTO);
            return Ok("Reserva Cadastrado");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_reservaService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(ReservaDTO ReservaDTO)
        {
            _reservaService.Put(ReservaDTO);
            return Ok("Reserva alterado");
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _reservaService.Delete(Id);
            return Ok("Reserva excluído");
        }
    }
}
