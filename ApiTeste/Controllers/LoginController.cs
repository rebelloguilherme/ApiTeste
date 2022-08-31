using ApiTeste.Models;
using ApiTeste.Repositories;
using ApiTeste.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiTeste.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);
            if (user == null)
            {
                return NotFound(new {message = "Usuário não encontrado"});
            }
            var token = TokenService.GenerateToken(user);

            user.Password = string.Empty;

            return new
            {
                user = user,
                token = token
            };
        }
    }
}
