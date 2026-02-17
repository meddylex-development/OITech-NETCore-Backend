using Microsoft.AspNetCore.Mvc;
using OITech.Models.Request;
using OITech.Models.Response;
using OITech.Services;

namespace OITech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("loging")]
        public IActionResult Autentificar([FromBody] AuthRequest model)
        {
            var usuario = _userService.Auth(model);
            if (usuario == null)
            {
                return BadRequest(new Respuesta
                {
                    Exito = 0,
                    Mensaje = "Usuario o contraseña incorrecta"
                });
            }

            return Ok(new Respuesta
            {
                Exito = 1,
                Data = usuario
            });
        }
    }
}
