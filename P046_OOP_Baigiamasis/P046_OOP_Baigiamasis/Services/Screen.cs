using P046_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Services
{
    public class Screen
    {
        internal void Refresh(Game currentGame)
        {
            Console.Clear();
            Console.WriteLine("Tower Of Hanoi");
            Console.WriteLine($"Ėjimas {currentGame.move}");
            Console.WriteLine($"Diskas rankoje: {currentGame.diskOnHand?.PrintDiskElements()}");
            Console.WriteLine();

            for (int ii = 0; ii < Game.NumberOfDisks + 1; ii++)
            {
                Console.Write($"{ii + 1}eil. ");
                for (int i = 0; i < Game.NumberOfTowers; i++)
                {
                    Console.Write(currentGame.towers[i].Disks[ii].PrintDiskElements());
                }
                Console.WriteLine();
            }

            Console.Write("      ");
            for (int i = 0; i < Game.NumberOfTowers; i++)
            {
                int SelectedMarkerSize = 0;
                if (currentGame.towers[i].IsTowerFromSelected) SelectedMarkerSize = 2;
                Console.Write($"{"".PadRight(Game.NumberOfDisks + 1 - SelectedMarkerSize, '-')}{"".PadRight(SelectedMarkerSize, '^')}[{i + 1}]{"".PadRight(SelectedMarkerSize, '^')}{"".PadRight(Game.NumberOfDisks + 1 - SelectedMarkerSize, '-')}");
            }

            Console.WriteLine();

            if (currentGame.errorMessage != null)
            {
                ShowErrorMessage(currentGame.errorMessage);
                currentGame.errorMessage = null;
            }
            else
            {
                Console.WriteLine();
            }

        }

        private void ShowErrorMessage(string messageText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(messageText);
            Console.ResetColor();
        }

        internal void ShowMessage(string messageText)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(messageText);
            Console.ResetColor();
            Console.ReadKey(true);
        }

    }
}
