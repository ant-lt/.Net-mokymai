using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Interfaces
{
    public abstract class IFileService
    {

        readonly string _filePath;

        public IFileService(string filePath)
        {
            _filePath = filePath;
        }

        public string[]? ReadFileLines()
        {
           
            if (File.Exists(_filePath))
                return File.ReadAllLines(_filePath);
            else return null;
        }

        public abstract string[] Decode(string dataSeed);
        public abstract void ReadData();
        public abstract void WriteData();
        public void WriteFileData(string[] data) => File.WriteAllLines(_filePath, data);
       
            
    


        /*
        public abstract string Name { get; }
        public abstract string Description { get; }
        public virtual string[] Result(string searchString)
        {
                return new string[] { "No result" };
        }

        public abstract string[] Search(string searchString);
        */


    }
}
