using P046_OOP_Baigiamasis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Models
{
    internal class FileConfig : IFileService
    {
        public FormatConfig FormatConfig { get; set; }

        public FileConfig() : base(Environment.CurrentDirectory + "\\Data\\game.config")
        {
            FormatConfig = new FormatConfig();
            ReadData();
        }

        public override string[] Decode(string dataSeed)
        {
            string[] result = dataSeed.Split(",");
            return result;
        }


        public override void ReadData()
        {
            string[]? data = ReadFileLines();

            if (data != null)
            {

                string[] splitValue = Decode(data[1]);

                FormatConfig.TXT = splitValue[0] == "1" ? true : false;
                FormatConfig.HTML = splitValue[1] == "1" ? true : false;
                FormatConfig.CSV = splitValue[2] == "1" ? true : false;
            }
            else // if configuration file is not exist then write default configuration
                WriteData();
        }

        public override void WriteData()
        {
            string[] data = new string[2];

            char txt = FormatConfig.TXT == true ? '1' : '0';
            char html = FormatConfig.HTML == true ? '1' : '0';
            char csv = FormatConfig.CSV == true ? '1' : '0';

            data[0] = string.Format($"TXT_Format,HTML_Format,CSV_Format");
            data[1] = string.Format($"{txt},{html},{csv}");

            WriteFileData(data);
        }

       
    }
}
