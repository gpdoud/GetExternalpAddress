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
        public ActionResult GetIp() {
            var ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            return new OkObjectResult(new { ip });
        }
    }
}