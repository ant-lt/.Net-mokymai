using P46_OOP_Baigiamasis.Interfaces;
using P46_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46_OOP_Baigiamasis.Services.LogHandlers
{
    public class HtmlGameLogHandler : IGameLogHandler
    {
        private readonly IFileManager _fileManager;

        public HtmlGameLogHandler(DateTime startTime, IFileManager fileManager)
        {
            _fileManager = fileManager;
            StartTime = startTime;
        }

        public DateTime StartTime { get; private set; }

        public List<GameLog> Read()
        {
            var res = new List<GameLog>();
            var data = _fileManager.Read();
            var a = @"<table border>
<tr>
<th>ŽAIDIMO PRADŽIOS DATA</th>
<th>ĖJIMO NR</th>
<th>DISKO 1 VIETA</th>
<th>DISKO 2 VIETA</th>
<th>DISKO 3 VIETA</th>
<th>DISKO 4 VIETA</th>
</tr>";
            data = data.Replace(a, "")
                .Replace("</table>", "")
                .Replace("</tr>", "")
                .Replace("<td>", "")
                .Replace(Environment.NewLine, "");




            var lines = data.Split("<tr>");
            var readingDate = new DateTime();
            foreach (var line in lines)
            {
                var csv = line.Split("</td>");
                if (csv.Length > 1)
                {
                    var date = DateTime.Parse(csv[0]);
                    if (readingDate != date)
                    {
                        var game = new GameLog
                        {
                            StartTime = date,
                            Moves = new List<GameMoveLog>(),
                        };
                        res.Add(game);
                        readingDate = date;
                    }
                    var move = new GameMoveLog(int.Parse(csv[1]));
                    for (int i = 2; i < csv.Length - 1; i++)
                    {
                        move.Positions.Add(int.Parse(csv[i]));
                    }

                    res[res.Count - 1].Moves.Add(move);
                }

            }
            return res;
        }

        public void Write(Game game, string input)
        {
            if (game.HasDiskInHand)
                return;

            var places = game.Disks.OrderBy(d => d.Size).Select(d => d.X + 1);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<tr>");
            sb.AppendLine($"<td>{StartTime}</td>");
            sb.AppendLine($"<td>{game.MoveNo}</td>");
            foreach (var p in places)
            {
                sb.AppendLine($"<td>{p}</td>");
            }
            sb.AppendLine("</tr>");
            sb.AppendLine("</table>");

            var data = _fileManager.Read();
            if (!data.Contains("<table border>"))
                data = CreateTable();

            data = data.Replace(Environment.NewLine + "</table>", sb.ToString());
            _fileManager.Write(data);
        }


        private string CreateTable()
        {
            string data = @"<table border>
<tr>
<th>ŽAIDIMO PRADŽIOS DATA</th>
<th>ĖJIMO NR</th>
<th>DISKO 1 VIETA</th>
<th>DISKO 2 VIETA</th>
<th>DISKO 3 VIETA</th>
<th>DISKO 4 VIETA</th>
</tr>
</table>
";
            _fileManager.Write(data);
            return data;
        }

    }
}

