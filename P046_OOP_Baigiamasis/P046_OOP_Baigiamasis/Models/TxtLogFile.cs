using P046_OOP_Baigiamasis.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Models
{
    public class TxtLogFile : LogFile
    {

        private static Dictionary<int, string[]> columnsNamesLT = new Dictionary<int, string[]>()
        {
                { 1, new string[2] { "pirmo", "pirmą"} },
                { 2, new string[2] { "antro", "antrą"} },
                { 3, new string[2] { "trečio", "trečią"} }
        };

        private static Dictionary<string, int> textToColumnsNamesLT = new Dictionary<string,int>()
        {
                { "pirmo", 1 },
                { "pirmą",1 },
                { "antro", 2 },
                { "antrą",2 },
                { "trečio", 3 },
                { "trečią",3 },
        };

        public TxtLogFile() : base(Environment.CurrentDirectory + "\\Data\\log.txt")
        {
            ReadData();
        }

        public override void ReadData()
        {

            string[]? data = ReadFileLines();

            if (data != null)
            {
                

                LogItem prevMove = new LogItem();
                // pradinis taskas kai visi diskai pirmajame stulpelyje
                prevMove.Disk1 = 1;
                prevMove.Disk2 = 1;
                prevMove.Disk3 = 1;
                prevMove.Disk4 = 1;

                LogItem currentMove = new LogItem();

                foreach (string line in data)
                {
                    string[]? splitValue = line.Replace(",", "").Split(" ");

                    if (splitValue != null && splitValue.Length == 20)
                    {
                        int readMove = int.Parse(splitValue[7]);
                        string dateTime = splitValue[3].Trim() + " " + splitValue[4].Trim();
                        int disko_dydis = int.Parse(splitValue[8].Trim());
                        string columnToText = splitValue[19].Trim();

                        DateTime parsedDate;
                        int tower;
                        if (textToColumnsNamesLT.TryGetValue(columnToText, out tower) && DateTime.TryParseExact(dateTime, datePattern, null,
                                         DateTimeStyles.None, out parsedDate))
                        {
                            if (readMove == 1)
                            {
                                prevMove.Disk1 = 1;
                                prevMove.Disk2 = 1;
                                prevMove.Disk3 = 1;
                                prevMove.Disk4 = 1;
                                currentMove = prevMove;
                            }

                            if (disko_dydis == 1)
                            {
                                currentMove.Disk1 = tower;
                            }
                            else if (disko_dydis == 2)
                            {
                                currentMove.Disk2 = tower;
                            }
                            else if (disko_dydis == 3)
                            {
                                currentMove.Disk3 = tower;
                            }
                            else if (disko_dydis == 4)
                            {
                                currentMove.Disk4 = tower;
                            }

                            currentMove.Date = parsedDate;
                            currentMove.Move = readMove;

                            
                            AddToLog(new LogItem 
                            {   Date = currentMove.Date, 
                                Move = currentMove.Move, 
                                Disk1 = currentMove.Disk1, 
                                Disk2 = currentMove.Disk2, 
                                Disk3 = currentMove.Disk3, 
                                Disk4 = currentMove.Disk4
                            });

                        }

                    }
                    
                }
            }

        }

        public override void SaveData()
        {
            List<LogItem> items = GetLogs();

            List<string> logsData = new List<string>();

           
            int disko_dydis = 0;
            LogItem prevMove = new LogItem();
            string columnFromText="";
            string columnToText = "";

            foreach (LogItem item in items)
            {
                if (item.Move == 1 )
                {
                    // pradinis taskas kai visi diskai pirmajame stulpelyje
                    prevMove.Disk1=1;
                    prevMove.Disk2=1;
                    prevMove.Disk3=1;
                    prevMove.Disk4=1;
                }

                if (prevMove.Disk1 != item.Disk1)
                {
                    disko_dydis = 1;
                    columnFromText = columnsNamesLT[prevMove.Disk1].GetValue(0).ToString();
                    columnToText = columnsNamesLT[item.Disk1].GetValue(1).ToString();
                    prevMove = item;
                }
                else if (prevMove.Disk2 != item.Disk2)
                {
                    disko_dydis = 2;
                    columnFromText = columnsNamesLT[prevMove.Disk2].GetValue(0).ToString();
                    columnToText = columnsNamesLT[item.Disk2].GetValue(1).ToString();
                    prevMove = item;

                }
                else if (prevMove.Disk3 != item.Disk3)
                {
                    disko_dydis = 3;
                    columnFromText = columnsNamesLT[prevMove.Disk3].GetValue(0).ToString();
                    columnToText = columnsNamesLT[item.Disk3].GetValue(1).ToString();
                    prevMove = item;

                }
                else if (prevMove.Disk4 != item.Disk4)
                {
                    disko_dydis = 4;
                    columnFromText = columnsNamesLT[prevMove.Disk4].GetValue(0).ToString();
                    columnToText = columnsNamesLT[item.Disk4].GetValue(1).ToString();
                    prevMove = item;
                }
                else
                {
                    //jeigu diskas paimamas ir padedamas atgal i ta pati stulpeli
                    int tower;
                    if (textToColumnsNamesLT.TryGetValue(columnToText, out tower))
                    {
                       columnToText = columnsNamesLT[tower].GetValue(1).ToString();
                       columnFromText = columnsNamesLT[tower].GetValue(0).ToString();
                    }
                }

                logsData.Add($"žaidime kuris pradėtas {item.Date.ToString(datePattern)}, ėjimu nr {item.Move} {disko_dydis} dalių diskas buvo paimtas iš {columnFromText} sulpelio ir padėtas į {columnToText}");
            }
           

            WriteFileData(logsData.ToArray());
        }
    }
}
