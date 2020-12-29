using Microsoft.AspNetCore.Mvc;
using RpgStore.Server.CharacterCreation;
using RpgStore.Shared;

namespace RpgStore.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {
        private readonly StatGenerator statGenerator;

        public StatsController()
        {
            statGenerator = new StatGenerator();
        }

        [HttpGet]
        public Stats Get()
        {
            return statGenerator.GenerateRandomStats();
        }
    }
}
