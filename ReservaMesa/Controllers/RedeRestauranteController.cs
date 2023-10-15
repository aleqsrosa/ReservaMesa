using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reserva.Application.DTO;
using Reserva.Application.Interfaces;

namespace ReservaMesa.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class RedeRestauranteController : ControllerBase
    {

        private readonly IRedeRestauranteAppService _redeRestauranteService;

        public RedeRestauranteController(IRedeRestauranteAppService redeRestauranteService)
        {
            _redeRestauranteService = redeRestauranteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_redeRestauranteService.GetAll());
        }

        [HttpPost, AllowAnonymous]
        public IActionResult Post(RedeRestauranteDTO RedeRestauranteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _redeRestauranteService.Post(RedeRestauranteDTO);
            return Ok("RedeRestaurante Cadastrado");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_redeRestauranteService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(RedeRestauranteDTO RedeRestauranteDTO)
        {
            _redeRestauranteService.Put(RedeRestauranteDTO);
            return Ok("RedeRestaurante alterado");
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _redeRestauranteService.Delete(Id);
            return Ok("RedeRestaurante excluído");
        }
    }
}
