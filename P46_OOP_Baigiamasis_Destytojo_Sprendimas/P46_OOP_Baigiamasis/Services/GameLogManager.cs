using P46_OOP_Baigiamasis.Interfaces;
using P46_OOP_Baigiamasis.Models;

namespace P46_OOP_Baigiamasis.Services
{
    public class GameLogManager : IGameLogManager
    {
        private readonly List<IGameLogHandler> _handlers;

        public GameLogManager(List<IGameLogHandler> handlers)
        {
            _handlers = handlers;
        }

        public List<GameLog> Read()
        {
            var res = new List<GameLog>();
            foreach (var l in _handlers)
            {
                var games = l.Read();
                foreach (var game in games)
                {
                    if (!res.Any(x => x.StartTime == game.StartTime))
                    {
                        res.Add(game);
                    }
                }
            }
            return res.OrderBy(x => x.StartTime).ToList();
        }

        public void Write(Game game, string input)
        {
            foreach (var l in _handlers)
            {
                l.Write(game, input);
            }
        }
    }
}
