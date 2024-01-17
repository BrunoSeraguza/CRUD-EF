using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blogapi.Controller
{
    [ApiController]
    [Route("")]
    public class HomeController:ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        => Ok( "certoo");

        [HttpPost]
        public IActionResult Post()
        => Ok();
    }
}