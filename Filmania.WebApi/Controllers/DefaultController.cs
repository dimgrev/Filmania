using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filmania.WebApi.Controllers
{
    [Route("api/Default")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        [Route("NumbersAddition")]
        public IActionResult TestAction([FromQuery(Name ="num1")] int x,[FromQuery(Name ="num2")] int y)
        {
            var result = $"The sum of {x},{y} is {x + y}";
            return Ok(result);
        }


        [HttpPost]
        [Route("Test")]
        public IActionResult TestAction2()
        {
            return Ok("Cov-id 20 succ conected to all people!");
        }
    }
}