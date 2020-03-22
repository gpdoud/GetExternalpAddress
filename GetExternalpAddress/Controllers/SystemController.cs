using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetExternalpAddress.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase {

        [HttpGet("/")]
        public IActionResult GetIp() {
            return new JsonResult(new { ip = Request.HttpContext.Connection.RemoteIpAddress.ToString() });
        }
    }
}