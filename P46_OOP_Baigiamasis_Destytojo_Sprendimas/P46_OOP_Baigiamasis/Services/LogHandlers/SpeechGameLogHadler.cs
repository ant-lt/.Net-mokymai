using P46_OOP_Baigiamasis.Extensions;
using P46_OOP_Baigiamasis.Interfaces;
using P46_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46_OOP_Baigiamasis.Services.LogHandlers
{
    public class SpeechGameLogHadler : IGameLogHandler
    {
        private readonly IFileManager _fileManager;
        public DateTime StartTime { get; private set; }

        public SpeechGameLogHadler(DateTime startTime, IFileManager fileManager)
        {
            _fileManager = fileManager;
            StartTime = startTime;
        }

        private string colFrom = "";
        private string colTo = "";
        private int discSize = 0;


        public List<GameLog> Read()
        {
            var res = new List<GameLog>();
            var data = _fileManager.Read().Replace(",", "");
            var lines = data.Split(Environment.NewLine);
            var readingDate = new DateTime();
            var positions = new int[] { 1, 1, 1, 1 };
            foreach (var line in lines)
            {
                var arr = line.Split(' ');
                if (arr.Length > 1)
                {
                    var date = DateTime.Parse(arr[3] + " " + arr[4]);
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
                    var move = new GameMoveLog(int.Parse(arr[7]));
                    positions[int.Parse(arr[8]) - 1] = PileExtension.ToToNumber(arr[19]);
                    move.Positions.AddRange(positions);

                    res[res.Count - 1].Moves.Add(move);
                }
            }

            return res;
        }

        public void Write(Game game, string input)
        {
            if (game.HasDiskInHand)
            {
                colFrom = PileExtension.FromToText((int)game.Disks.Last().X + 1);
                discSize = game.Disks.Last().Size;
            }
            else
            {
                colTo = PileExtension.ToToText(int.Parse(input));
                var txt = $"žaidime kuris pradėtas {StartTime}, ėjimu nr {game.MoveNo}, {discSize} {(discSize > 1 ? "dalių" : "dalies")} diskas buvo paimtas iš {colFrom} sulpelio ir padėtas į {colTo}";
                var data = _fileManager.Read();
                data = data + txt + Environment.NewLine;
                _fileManager.Write(data);

                colFrom = "";
                colTo = "";
                discSize = 0;
            }
        }
    }
}
