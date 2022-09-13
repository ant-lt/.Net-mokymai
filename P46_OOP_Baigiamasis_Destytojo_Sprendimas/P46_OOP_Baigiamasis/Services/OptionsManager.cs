using P46_OOP_Baigiamasis.Models;

namespace P46_OOP_Baigiamasis.Services
{
    public class OptionsManager
    {
        private string _filename;
        public OptionsManager(string filename)
        {
            _filename = filename;
        }

        public GameOptions Read()
        {
            var lines = File.ReadAllText(_filename);
            return new GameOptions
            {
                LogWriters = lines.Replace("LOG_WRITERS: ", "").Split(',').ToList()
            };
        }
    }
}
