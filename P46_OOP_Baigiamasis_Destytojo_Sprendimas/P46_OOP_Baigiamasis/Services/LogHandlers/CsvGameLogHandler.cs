using P46_OOP_Baigiamasis.Interfaces;
using P46_OOP_Baigiamasis.Models;

namespace P46_OOP_Baigiamasis.Services.LogHandlers
{
    public class CsvGameLogHandler : IGameLogHandler
    {
        private readonly IFileManager _fileManager;
        public DateTime StartTime { get; private set; }

        public CsvGameLogHandler(DateTime startTime, IFileManager fileManager)
        {
            _fileManager = fileManager;
            StartTime = startTime;
        }

        public void Write(Game game, string input)
        {
            if (game.HasDiskInHand)
                return;
            var places = game.Disks.OrderBy(d => d.Size).Select(d => d.X + 1);
            var txt = $"{StartTime},{game.MoveNo},{string.Join(",", places)}";
            var data = _fileManager.Read();
            data = data + txt + Environment.NewLine;
            _fileManager.Write(data);
        }
        public List<GameLog> Read()
        {
            var res = new List<GameLog>();
            var data = _fileManager.Read();
            var lines = data.Split(Environment.NewLine);
            var readingDate = new DateTime();
            foreach (var line in lines)
            {
                var csv = line.Split(',');
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
                    for (int i = 2; i < csv.Length; i++)
                    {
                        move.Positions.Add(int.Parse(csv[i]));
                    }

                    res[res.Count - 1].Moves.Add(move);
                }

            }

            return res;
        }
    }
}
