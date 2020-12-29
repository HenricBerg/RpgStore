using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RpgStore.Server.Data_Management;
using RpgStore.Shared;

namespace RpgStore.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly Filehandler filehandler;

        public CharacterController()
        {
            filehandler = new Filehandler();
        }

        [HttpGet]
        public Character Get()
        {
            return new Character
            {
                Name = "TestName",
                Description = "TestDescription",
                Modified = DateTime.UtcNow
            };
        }

        [HttpPost]
        public void Post(Character character)
        {
            character.Modified = DateTime.UtcNow;
            filehandler.AddNewCharacterFile(character);
        }
    }
}
