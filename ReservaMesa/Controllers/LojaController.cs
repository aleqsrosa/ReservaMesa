using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reserva.Application.DTO;
using Reserva.Application.Interfaces;

namespace ReservaMesa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LojaController : ControllerBase
    {
        private readonly ILojaAppService _lojaService;

        public LojaController(ILojaAppService LojaService)
        {
            _lojaService = LojaService;
        }

        [HttpGet("BuscarLoja")]
        public IActionResult Get()
        {
            return Ok(_lojaService.GetAll());
        }

        [HttpPost("CadastrarLoja")]
        public IActionResult Post(LojaDTO lojaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _lojaService.Post(lojaDTO);
            return Ok("Loja Cadastrado");
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_lojaService.GetById(id));
        }

        [HttpPut("AlterarLoja")]
        public IActionResult Put(LojaDTO lojaDTO)
        {
            _lojaService.Put(lojaDTO);
            return Ok("Loja alterado");
        }

        [HttpDelete("DeletarLoja")]
        public IActionResult Delete(int Id)
        {
            _lojaService.Delete(Id);
            return Ok("Loja excluído");
        }
    }
}
