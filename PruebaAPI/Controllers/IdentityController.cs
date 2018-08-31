using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PruebaAPI.Controllers
{
    [Produces("application/json")]
    [Route("identity")]
    [Authorize]
    public class IdentityController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var x = new { newe = "dd", message = "sss" };
            //return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
            return new JsonResult(x);
        }
    }
}