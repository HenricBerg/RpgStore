using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RpgStore.Shared;

namespace RpgStore.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextController : ControllerBase
    {
        [HttpGet]
        public Text Get()
        {
            return new Text
            {
                Name = "TestName",
                Description = "TestDescription",
                TextContent = "TestContent",
                Modified = DateTime.UtcNow
            };
        }

        [HttpPost]
        public void Post(Text text)
        {
            var text1 = text;
        }
    }
}
