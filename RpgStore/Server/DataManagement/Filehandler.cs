using Newtonsoft.Json;
using RpgStore.Shared;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RpgStore.Server.Data_Management
{
    public class Filehandler
    {
        public void AddNewCharacterFile(Character character)
        {
            var filePath = "..\\Files\\" + character.Name + ".txt";
            File.WriteAllText(filePath, JsonConvert.SerializeObject(character));
        }
    }
}
