using P46_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46_OOP_Baigiamasis.Services
{
    public class GameConsoleUi : GameUi
    {
        protected static readonly List<string> pictures = new List<string>
        {
            "      |      ",
            "     #|#     ",
            "    ##|##    ",
            "   ###|###   ",
            "  ####|####  "
        };
        private readonly Game _game;

        public GameConsoleUi(Game game)
        {
            _game = game;
            Piles = new string[game.DiskCount + 1, game.PilesCount];
        }

        public override void Display()
        {
            FillPiles();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($" {Title}");
            Console.WriteLine($"  Ėjimas {_game.MoveNo}");
            if (_game.IsEndState)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  SVEIKINAME, JŪS BAIGĖTE ŽAIDIMĄ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.WriteLine($"   Diskas rankoje: {(DiskInHand == null ? string.Empty : pictures[DiskInHand.Size])}");
            Console.WriteLine();

            for (int y = 0; y < Piles.GetLength(0); y++)
            {
                Console.Write($"   {y + 1}eil.");
                for (int x = 0; x < Piles.GetLength(1); x++)
                {
                    Console.Write(Piles[y, x]);
                }
                Console.WriteLine();
            }

            Console.Write("        ");
            for (int x = 0; x < Piles.GetLength(1); x++)
            {
                var rised = _game.Disks.Any(d => d.X == x && d.Y == null);
                Console.Write($"--{(rised ? "^^^" : "---")}[{x + 1}]{(rised ? "^^^" : "---")}--");
            }
            Console.WriteLine();
            Console.WriteLine();
            if (!string.IsNullOrEmpty(_game.HelpText))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"  {_game.HelpText}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  Norėdami išeiti paspauskite 'Esc' ");
            Console.WriteLine("  Pagalbai paspauskite 'H' ");
            if (!string.IsNullOrEmpty(_game.ErrText))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"  Klaida! {_game.ErrText} ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(DiskInHand != null ? "  Pasirinkite stulpelį iš kurio paimti" : "  Pasirinkite stulpelį į kurį padėti");

        }


        protected void FillPiles()
        {
            DiskInHand = _game.HasDiskInHand ? _game.Disks.Last() : null;

            for (int y = 0; y < Piles.GetLength(0); y++)
            {
                for (int x = 0; x < Piles.GetLength(1); x++)
                {
                    int? diskSize = _game.Disks.FirstOrDefault(d => d.X == x && d.Y == y)?.Size;
                    Piles[y, x] = pictures[diskSize == null ? 0 : (int)diskSize];
                }
            }
        }
    }
}
