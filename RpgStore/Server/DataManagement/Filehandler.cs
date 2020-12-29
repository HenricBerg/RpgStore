using Newtonsoft.Json;
using RpgStore.Shared;
using System.IO;

namespace RpgStore.Server.Data_Management
{
    public class Filehandler
    {
        public void AddNewCharacterFile(Character character)
        {
            var filePath = "..\\Files\\" + character.Name + ".txt";
            File.WriteAllText(filePath, JsonConvert.SerializeObject(character));
        }

        public Character GetCharacterFromFile(string name)
        {
            var filePath = "..\\Files\\" + name + ".txt";
            Character character = JsonConvert.DeserializeObject<Character>(File.ReadAllText(filePath));
            return character;
        }
    }
}
