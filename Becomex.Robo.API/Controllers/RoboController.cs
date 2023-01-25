using Becomex.Robo.Application.Interfaces;
using Becomex.Robo.Application.Services.Robo;
using Becomex.Robo.Domain.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Becomex.Robo.API.Controllers
{
    [Route("api/v1/robo")]
    public class RoboController : Controller
    {
        private IRoboService _roboService;

        public RoboController(IRoboService roboService)
        {
            _roboService = roboService;
        }

        [Route("getPosicoes"), HttpGet]
        public IActionResult GetPosicoes()
        {
            return Ok(this._roboService.GetPosicoes());
        }

        [Route("reiniciar"), HttpGet]
        public IActionResult Reiniciar()
        {
            return Ok(this._roboService.ReiniciarRobo());
        }

        [Route("braco/movimentarPulso"), HttpPost]
        public IActionResult MovimentarPulso([FromBody] MovimentoBracoRequest request)
        {
            try
            {
                return Ok(this._roboService.MovimentarPulso(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("braco/movimentarCotovelo"), HttpPost]
        public IActionResult MovimentarCotovelo([FromBody] MovimentoBracoRequest request)
        {
            try
            {
                return Ok(this._roboService.MovimentarCotovelo(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("cabeca/rotacionar"), HttpPost]
        public IActionResult RotacionarCabeca([FromBody] MovimentoCabecaRequest request)
        {
            try
            {
                return Ok(this._roboService.RotacionarCabeca(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("cabeca/inclinar"), HttpPost]
        public IActionResult InclinarCabeca([FromBody] MovimentoCabecaRequest request)
        {
            try
            {
                return Ok(this._roboService.InclinarCabeca(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
