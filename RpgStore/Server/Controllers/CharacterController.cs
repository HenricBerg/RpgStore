using System;
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

        [HttpGet("{name}")]
        public Character Get(string name)
        {
            return filehandler.GetCharacterFromFile(name);
        }

        [HttpPost]
        public void Post(Character character)
        {
            character.Modified = DateTime.UtcNow;
            filehandler.AddNewCharacterFile(character);
        }
    }
}
