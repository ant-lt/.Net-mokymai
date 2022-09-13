using P46_OOP_Baigiamasis.Extensions;
using P46_OOP_Baigiamasis.Interfaces;
using P46_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46_OOP_Baigiamasis.Services
{
    public class GameFunctionManager : IGameFunctionManager
    {
        private readonly List<IGameFunction> moves;
        public GameFunctionManager(List<IGameFunction> moves)
        {
            this.moves = moves;
        }
        public void Invoke(string input)
        {
            moves.First(m => m.ApplysTo(input)).Move(input);
        }

        public class TakeDisk : IGameFunction
        {
            private readonly Game _game;
            private readonly IGameLogManager _logger;

            public TakeDisk(Game game, IGameLogManager logger)
            {
                _game = game;
                _logger = logger;
            }

            public bool ApplysTo(string input)
            {
                if (!int.TryParse(input, out int x))
                    return false;
                return !_game.HasDiskInHand && _game.Disks.Any(d => d.X == (x - 1) && d.Y != null);

            }

            public void Move(string input)
            {
                var x = Convert.ToInt32(input) - 1;
                var disk = _game.Disks.Where(d => d.X == x && d.Y != null).OrderBy(d => d.Size).FirstOrDefault();
                _game.HelpText = string.Empty;
                _game.Disks.Remove(disk);
                _game.Disks.Add(new Disk(disk.Size, disk.X, null));
                
                _logger.Write(_game, input);
            }
        }
        public class PutDiskToEmptyPile : IGameFunction
        {
            private readonly Game _game;
            private readonly IGameLogManager _logger;

            public PutDiskToEmptyPile(Game game, IGameLogManager logger)
            {
                _game = game;
                _logger = logger;
            }

            public bool ApplysTo(string input)
            {
                if (!int.TryParse(input, out int x))
                    return false;

                return _game.HasDiskInHand && !_game.Disks.Any(d => d.X == (x - 1) && d.Y != null);
            }

            public void Move(string input)
            {
                var x = Convert.ToInt32(input) - 1;
                var disk = _game.Disks.Last();
                _game.HelpText = string.Empty;
                _game.Disks.Remove(disk);
                _game.Disks.Add(new Disk(disk.Size, x, _game.DiskCount));
                _game.MoveNo++;
                
                _logger.Write(_game, input);
            }
        }
        public class PutDiskToNonEmptyPile : IGameFunction
        {
            private readonly Game _game;
            private readonly IGameLogManager _logger;

            public PutDiskToNonEmptyPile(Game game, IGameLogManager logger)
            {
                _game = game;
                _logger = logger;
            }

            public bool ApplysTo(string input)
            {
                if (!int.TryParse(input, out int x))
                    return false;

                if (!_game.HasDiskInHand)
                    return false;

                if (!_game.Disks.Any(d => d.X == (x - 1)))
                    return false;

                if (_game.Disks.Any(d => d.X == (x - 1) && d.Y != null && d.Size < _game.Disks.Last().Size))
                    return false;

                return true;
            }

            public void Move(string input)
            {
                var x = Convert.ToInt32(input) - 1;
                var topDisk = _game.Disks.Where(d => d.X == x && d.Y != null).OrderBy(d => d.Size).First();
                var disk = _game.Disks.Last();

                _game.HelpText = string.Empty;
                _game.Disks.Remove(disk);
                _game.Disks.Add(new Disk(disk.Size, x, topDisk.Y - 1));
                _game.MoveNo++;
                
                _logger.Write(_game, input);
            }
        }
        public class Help : IGameFunction
        {
            private readonly Game _game;
            private readonly IGameLogManager _logger;

            public Help(Game game, IGameLogManager logger)
            {
                _game = game;
                _logger = logger;
            }

            public bool ApplysTo(string input) => input.ToLower() == "h";

            public void Move(string input)
            {
                _game.HelpText = "<pagalba> PAGALBA NEGALIMA";
                var log = _logger.Read().Where(x => x.IsCompleted);
                var currentPosition = _game.Disks.OrderBy(d => d.Size).Select(d => (d.X + 1) ?? 0).ToArray();

                var movesToEnd = int.MaxValue;
                List<int> helpPosition = new List<int>();
                foreach (var g in log)
                {
                    for (int i = 0; i < g.Moves.Count; i++)
                    {
                        var isArrayEqual = currentPosition.SequenceEqual(g.Moves[i].Positions);
                        if (isArrayEqual)
                        {
                            var toEnd = g.Moves.Count - i;
                            if (toEnd < movesToEnd)
                            {
                                helpPosition = g.Moves[i + 1].Positions;
                            }
                            movesToEnd = toEnd;
                        }
                    }
                }

                if (helpPosition.Count != 0)
                {
                    for (int i = 0; i < currentPosition.Length; i++)
                    {
                        if (currentPosition[i] != helpPosition[i])
                            _game.HelpText = $"<pagalba> - paimkite diską iš {PileExtension.FromToText(currentPosition[i])} stulpelio ir padėkite į {PileExtension.ToToText(helpPosition[i])}";
                    }
                }
            }
        }

    }
}
