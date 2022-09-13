using P46_OOP_Baigiamasis.Interfaces;

namespace P46_OOP_Baigiamasis.Services
{
    public class FileManager : IFileManager
    {
        private readonly string _filename;

        public FileManager(string filename)
        {
            _filename = filename;
        }

        public string Read()
        {
            if (!File.Exists(_filename))
                return "";

            string text = File.ReadAllText(_filename);
            return text;
        }

        public void Write(string data)
        {
            File.WriteAllText(_filename, data);
        }
    }
}