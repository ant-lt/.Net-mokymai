using P046_OOP_Baigiamasis.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace P046_OOP_Baigiamasis.Models
{
    public class HtmlLogFile : LogFile
    {
        public HtmlLogFile() : base(Environment.CurrentDirectory + "\\Data\\log.html")
        {
            ReadData();
        }
        public override void ReadData()
        {
            string[]? data = ReadFileLines();

            if (data != null)
            {
                DateTime parsedDate;
                string dataSeed = string.Join(string.Empty, data);
                string[] rows = dataSeed.Split("<tr>");
                if (rows.Length > 2)
                {

                    for (int i = 2; i < rows.Length; i++)
                    {
                        string[] cells = rows[i]
                        .Replace("<th>", "")
                        .Replace("table border>", "")
                        .Replace("</table>", "")
                        .Replace(Environment.NewLine, "")
                        .Replace("</td>", "")
                        .Replace("</tr>", "")
                        .Split("<td>");

                        if (DateTime.TryParseExact(cells[1], datePattern, null, DateTimeStyles.None, out parsedDate))
                        {
                            AddToLog(new LogItem { Date = parsedDate, Move = int.Parse(cells[2]), Disk1 = int.Parse(cells[3]), Disk2 = int.Parse(cells[4]), Disk3 = int.Parse(cells[5]), Disk4 = int.Parse(cells[6]) });
                        }

                    }

                }

            }

        }

        public override void SaveData()
        {
            List<LogItem> items = GetLogs();

            List<string> logsData = new List<string>();

            logsData.Add("<table border>");
            logsData.Add("<tr>");
            logsData.Add("<th>ŽAIDIMO PRADŽIOS DATA</td>");
            logsData.Add("<th>ĖJIMO NR</td>");
            logsData.Add("<th>DISKO 1 VIETA</td>");
            logsData.Add("<th>DISKO 2 VIETA</td>");
            logsData.Add("<th>DISKO 3 VIETA</td>");
            logsData.Add("<th>DISKO 4 VIETA</td>");
            logsData.Add("</tr>");

            foreach (LogItem item in items)
            {
                logsData.Add("<tr>");
                logsData.Add($"<td>{item.Date.ToString(datePattern)}</td>");
                logsData.Add($"<td>{item.Move}</td>");
                logsData.Add($"<td>{item.Disk1}</td>");
                logsData.Add($"<td>{item.Disk2}</td>");
                logsData.Add($"<td>{item.Disk3}</td>");
                logsData.Add($"<td>{item.Disk4}</td>");
                logsData.Add("</tr>");
            }
            logsData.Add("</table>");

            WriteFileData(logsData.ToArray());
        }
    }
}
