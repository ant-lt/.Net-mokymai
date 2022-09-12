using P046_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Services
{
    internal class Statistics
    {

        private static SortedDictionary<DateTime, LogItem> historyRecords = new SortedDictionary<DateTime, LogItem>();

        public void ShowGameStatistics(Game currentGame)
        {

            LoadDataFromLogFile(currentGame.logFiles);
            CreateStatisticsReport();

        }


        /// <summary>
        /// Uzkraunami issaugoti zaidimo irasai is visu pasirenktu log failu formatu.
        /// </summary>
        /// <param name="logFiles"></param>
        private void LoadDataFromLogFile(List<LogFile> logFiles)
        {

            foreach (LogFile logFile in logFiles)
            {
                List<LogItem> logItems = logFile.GetLogs();    
                foreach (LogItem logItem in logItems)
                {
                    historyRecords.TryAdd(logItem.Date.AddMilliseconds(logItem.Move), logItem); // pridedam milisekundes nuo eijimo eiles, kad butu visi irasai unikalus pagal laika ir data
                }
            }


        }

        public void CreateStatisticsReport()
        {
            string datePattern = "yyyy-MM-dd HH:mm";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------------------------------------------------------");
            sb.AppendLine("| Žaidimo data       | Ėjimų kiekis iki laimėjimo | Pokytis  |");
            //int inicialMove = 1
            int lastWinMoveCount = 0;
            int currentMoveCount = 0;
            bool gameStarted = false;
            DateTime lastStartDate = DateTime.Now;
            foreach (LogItem logItem in historyRecords.Values)
            {
                if (logItem.Disk1 == 3 && logItem.Disk2 == 3 && logItem.Disk3 == 3 && logItem.Disk4 == 3)// win condition
                {
                    
                    sb.AppendLine("--------------------------------------------------------------");
                    sb.AppendLine($"{"|".PadRight(2, ' ')} {logItem.Date.ToString(datePattern),-16}{"".PadRight(2, ' ')}|{"".PadRight(4, ' ')}{logItem.Move,-20}{"".PadRight(4, ' ')}|{"".PadRight(4, ' ')}{logItem.Move - lastWinMoveCount,-6}|");
                    lastWinMoveCount = logItem.Move;
                    currentMoveCount = 1;
                    gameStarted = false;
                }
                else if (logItem.Disk1 != 1 && logItem.Disk2 == 1 && logItem.Disk3 == 1 && logItem.Disk4 == 1)// game start condition
                {
                    gameStarted = true;
                    currentMoveCount = logItem.Move;
                    lastStartDate = logItem.Date;
                   
                }
  
                currentMoveCount = logItem.Move;
            }

            if (gameStarted) // neuzbaigtas / nutrauktas zaidimas
            {
                sb.AppendLine("--------------------------------------------------------------");
                sb.AppendLine($"|  {lastStartDate.ToString(datePattern),-16}  |        N/B  | N/G    |");

            }
            
            sb.AppendLine("--------------------------------------------------------------");

            Console.WriteLine(sb.ToString());

        }

    }
}
