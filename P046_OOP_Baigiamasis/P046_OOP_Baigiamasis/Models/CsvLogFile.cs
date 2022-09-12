using P046_OOP_Baigiamasis.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace P046_OOP_Baigiamasis.Models
{
    public class CsvLogFile : LogFile
    {


        public CsvLogFile() : base(Environment.CurrentDirectory + "\\Data\\log.csv")
        {
            ReadData();
        }

        public override void ReadData()
        {
            string[]? data = ReadFileLines();

            if (data != null)
            {
                DateTime parsedDate;

                foreach (string line in data)
                {
                    string[]? splitValue = line.Split(",");

                    if (splitValue != null && splitValue.Length == 6)
                    {
                        if (DateTime.TryParseExact(splitValue[0], datePattern, null,
                                         DateTimeStyles.None, out parsedDate))
                        {
                            AddToLog(new LogItem { Date = parsedDate, Move = int.Parse(splitValue[1]), Disk1 = int.Parse(splitValue[2]), Disk2 = int.Parse(splitValue[3]), Disk3 = int.Parse(splitValue[4]), Disk4 = int.Parse(splitValue[5]) });
                        }
                    }
                }
            }
        }


    public override void SaveData()
        {
            List<LogItem> items = GetLogs();
            
            List<string> logsData = new List<string>();

            logsData.Add("zaidimo_pradzios_data, ejimo_nr, disko_1_vieta, disko_2_vieta, disko_3_vieta, disko_4_vieta");

            foreach (LogItem item in items)
            {
                logsData.Add($"{item.Date:yyyy-MM-dd HH:mm},{item.Move},{item.Disk1},{item.Disk2},{item.Disk3},{item.Disk4}");
            }
            WriteFileData(logsData.ToArray());
        }
    }

}
