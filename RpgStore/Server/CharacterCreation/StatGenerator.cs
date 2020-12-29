using RpgStore.Shared;
using System;

namespace RpgStore.Server.CharacterCreation
{
    public class StatGenerator
    {
        public Stats GenerateRandomStats()
        {
            var rng = new Random();
            var stats = new Stats();

            foreach (var stat in stats.GetType().GetProperties())
            {
                stat.SetValue(stats, rng.Next(3,19));
            }

            return stats;
        }
    }
}
