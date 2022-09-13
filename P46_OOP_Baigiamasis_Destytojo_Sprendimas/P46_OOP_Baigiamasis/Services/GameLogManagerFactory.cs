using P46_OOP_Baigiamasis.Interfaces;
using P46_OOP_Baigiamasis.Models;
using P46_OOP_Baigiamasis.Services.LogHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46_OOP_Baigiamasis.Services
{
    public class GameLogManagerFactory : IGameLogManagerFactory
    {
        private readonly GameOptions _options;
        private readonly DateTime _now;

        public GameLogManagerFactory(GameOptions options, DateTime now)
        {
            _options = options;
            _now = now;
        }

        public IGameLogManager Build()
        {
            var loggers = new List<IGameLogHandler>();
            foreach (var option in _options.LogWriters)
            {
                if (option == "csv")
                    loggers.Add(new CsvGameLogHandler(_now, new FileManager("game.csv")));
                if (option == "html")
                    loggers.Add(new HtmlGameLogHandler(_now, new FileManager("game.html")));
                if (option == "txt")
                    loggers.Add(new SpeechGameLogHadler(_now, new FileManager("game.txt")));
            }

            return new GameLogManager(loggers);
        }

       
    }
}
