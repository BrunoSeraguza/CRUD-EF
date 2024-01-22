using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blogapi.Controller
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        //injecao de dependencia 
        private readonly TokenService _tokenService;

        //agora meu servico tem uma dependecia e eu nao preciso ficar instanciando 
        public AccountController(TokenService token)
        {
            _tokenService = token;
            
        }

        [HttpPost("v1/login")]
        public IActionResult Login()
        {
            var token = _tokenService.GetToken(null);

            return Ok(token);

        }
    }
}
