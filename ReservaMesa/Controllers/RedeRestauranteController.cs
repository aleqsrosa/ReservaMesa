using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reserva.Application.DTO;
using Reserva.Application.Interfaces;

namespace ReservaMesa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedeRestauranteController : ControllerBase
    {

        private readonly IRedeRestauranteAppService _redeRestauranteService;

        public RedeRestauranteController(IRedeRestauranteAppService redeRestauranteService)
        {
            _redeRestauranteService = redeRestauranteService;
        }

        [HttpGet("BuscarRedeRestaurante")]
        public IActionResult Get()
        {
            return Ok(_redeRestauranteService.GetAll());
        }

        [HttpPost("CadastraRedeRestaurante")]
        public IActionResult Post(RedeRestauranteDTO RedeRestauranteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _redeRestauranteService.Post(RedeRestauranteDTO);
            return Ok("RedeRestaurante Cadastrado");
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_redeRestauranteService.GetById(id));
        }

        [HttpPut("AlterarRedeRestaurante")]
        public IActionResult Put(RedeRestauranteDTO RedeRestauranteDTO)
        {
            _redeRestauranteService.Put(RedeRestauranteDTO);
            return Ok("RedeRestaurante alterado");
        }

        [HttpDelete("DeletarRedeRestaurante")]
        public IActionResult Delete(int Id)
        {
            _redeRestauranteService.Delete(Id);
            return Ok("RedeRestaurante excluído");
        }
    }
}
