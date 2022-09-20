using Curso.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        public IActionResult Login(LoginInput loginInput) 
        {
            return Ok( loginInput);
        }


        [HttpPost]
        public IActionResult Register(LoginInput loginInput)
        {
            return Created("", loginInput);
        }
    }
}
