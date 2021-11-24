using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAngualrTestJustin.Controllers
{
    [Route("demo")]
    [ApiController]
    public class Demo : ControllerBase
    {

        [HttpGet]
        public Object test()
        {
            return new { name= "Fred", id = 10};
        }
    }
}
