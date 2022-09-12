using P046_OOP_Baigiamasis.Enums;
using P046_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Services
{
    public class KeyboardInput
    {
        public int GetTower(string towerChoseText)
        {
            Console.WriteLine(Environment.NewLine + "Norėdami išeiti paspauskite 'Esc'" + Environment.NewLine + "Pagalbai paspauskite 'H'" + Environment.NewLine + towerChoseText);

            while (true)
            {
                ConsoleKeyInfo keyInput = Console.ReadKey(true);

                switch (keyInput.Key)
                {
                    case ConsoleKey.H:
                        return (int)Ekey.HELP;
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        return 1;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        return 2;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        return 3;
                    case ConsoleKey.Escape:
                        return (int)Ekey.ESCAPE;
                        default:
                        return (int)Ekey.ANY;

                }
            }
        }

        public void ChooseFilesConfiguration(Game currentGame)
        {

            bool choose = true;
            bool IsConfigReady = false;

            currentGame.logFiles.Clear();

            while (choose)
            {
                Console.Clear();

                char txt = currentGame.filesConfig.FormatConfig.TXT == true ? 'X' : ' ';
                char html = currentGame.filesConfig.FormatConfig.HTML == true ? 'X' : ' ';
                char csv = currentGame.filesConfig.FormatConfig.CSV == true ? 'X' : ' ';


                Console.WriteLine();
                Console.WriteLine("Pasirinkite žaidimo įrašymo formatus(skaičiai nuo 1-3):");
                Console.WriteLine($"1) TXT [{txt}]");
                Console.WriteLine($"2) HTML [{html}]");
                Console.WriteLine($"3) CSV [{csv}]");
                Console.WriteLine();
                Console.WriteLine($"Spaskite Enter - išsaugoti pasirinkimą ir pradėti žaidimą.");

                IsConfigReady = currentGame.filesConfig.FormatConfig.TXT || currentGame.filesConfig.FormatConfig.HTML || currentGame.filesConfig.FormatConfig.CSV;
                ConsoleKeyInfo keyInput = Console.ReadKey(true);

                switch (keyInput.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        currentGame.filesConfig.FormatConfig.TXT = !currentGame.filesConfig.FormatConfig.TXT;
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        currentGame.filesConfig.FormatConfig.HTML = !currentGame.filesConfig.FormatConfig.HTML;
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        currentGame.filesConfig.FormatConfig.CSV = !currentGame.filesConfig.FormatConfig.CSV;
                        break;
                    case ConsoleKey.Enter:
                        if (IsConfigReady)
                        {
                            currentGame.filesConfig.WriteData();
                            choose = false;
                        }
                        else
                            currentGame.filesConfig.FormatConfig.TXT = true;
                        break;
                }
            }

            if (currentGame.filesConfig.FormatConfig.TXT) currentGame.logFiles.Add(new TxtLogFile());
            if (currentGame.filesConfig.FormatConfig.HTML) currentGame.logFiles.Add(new HtmlLogFile());
            if (currentGame.filesConfig.FormatConfig.CSV) currentGame.logFiles.Add(new CsvLogFile());                        

        }
    }
}
