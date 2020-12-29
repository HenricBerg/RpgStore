using System;

namespace RpgStore.Shared
{
    public class Character
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Modified { get; set; }
        public Stats Stats { get; set; }
    }
}
