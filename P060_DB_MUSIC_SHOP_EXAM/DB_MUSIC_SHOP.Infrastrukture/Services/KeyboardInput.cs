using DB_MUSIC_SHOP.Infrastrukture.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_MUSIC_SHOP.Infrastrukture.Services
{
    internal class KeyboardInput
    {
        public int GetMenuChoose(string menuText, int maxMenuItemsCount, bool inputVisible, bool addKeyActive, string addKeyText, bool sortKeyActive, bool searchKeyActive, bool clearScreen)
        {
            bool inputData = true;
            int result = 0;

            if (clearScreen)
                Console.Clear();

            Console.WriteLine($"{menuText}");

            if (maxMenuItemsCount > 0)
                Console.WriteLine($"Pasirinkite nuo 1 iki {maxMenuItemsCount}");

            Console.Write("'q' - grįžti atgal ");

            if (addKeyActive)
                Console.Write("'y' - " + addKeyText + " ");
            if (sortKeyActive)
                Console.Write("'o' - atidaryti rikiavimo langą ");
            if (searchKeyActive)
                Console.Write("'s' - atidaryti paieškos langą");

            Console.WriteLine();

            while (inputData)
            {
                ConsoleKeyInfo keyInput;
                if (inputVisible)
                    keyInput = Console.ReadKey(false);
                else
                    keyInput = Console.ReadKey(true);


                var keyInputCode = keyInput.Key;

                if (keyInputCode == ConsoleKey.Q)
                {
                    result = (int)Ekey.BACK;
                }
                else if (keyInputCode == ConsoleKey.Y)
                {
                    result = (int)Ekey.ADD;
                }
                else if (keyInputCode == ConsoleKey.O)
                {
                    result = (int)Ekey.SORT;
                }
                else if (keyInputCode == ConsoleKey.S)
                {
                    result = (int)Ekey.SEARCH;
                }

                else if ((keyInputCode == ConsoleKey.NumPad1 || keyInputCode == ConsoleKey.D1) && maxMenuItemsCount >= 1)
                {
                    result = 1;
                }
                else if ((keyInputCode == ConsoleKey.NumPad2 || keyInputCode == ConsoleKey.D2) && maxMenuItemsCount >= 2)
                {
                    result = 2;
                }
                else if ((keyInputCode == ConsoleKey.NumPad3 || keyInputCode == ConsoleKey.D3) && maxMenuItemsCount >= 3)
                {
                    result = 3;
                }
                else if ((keyInputCode == ConsoleKey.NumPad4 || keyInputCode == ConsoleKey.D4) && maxMenuItemsCount >= 4)
                {
                    result = 4;
                }
                else if ((keyInputCode == ConsoleKey.NumPad5 || keyInputCode == ConsoleKey.D5) && maxMenuItemsCount >= 5)
                {
                    result = 5;
                }
                else if ((keyInputCode == ConsoleKey.NumPad6 || keyInputCode == ConsoleKey.D6) && maxMenuItemsCount >= 6)
                {
                    result = 6;
                }
                else if ((keyInputCode == ConsoleKey.NumPad7 || keyInputCode == ConsoleKey.D7) && maxMenuItemsCount >= 7)
                {
                    result = 7;
                }
                else if ((keyInputCode == ConsoleKey.NumPad8 || keyInputCode == ConsoleKey.D8) && maxMenuItemsCount >= 8)
                {
                    result = 8;
                }
                else if ((keyInputCode == ConsoleKey.NumPad9 || keyInputCode == ConsoleKey.D9) && maxMenuItemsCount >= 9)
                {
                    result = 9;
                }

                if ((result == (int)Ekey.BACK || (result == (int)Ekey.ADD && addKeyActive) || (result == (int)Ekey.SORT && sortKeyActive) || (result == (int)Ekey.SEARCH) && searchKeyActive) || (result > 0 && result <= maxMenuItemsCount))
                {
                    inputData = false;
                }
            }
            return result;
        }

        public long InputInt(string descriptionText)
        {
            long result = 0;
            bool arIvestasSkaicius = false;

            while (!arIvestasSkaicius)
            {
                Console.Write($"{descriptionText}");
                string? skaiciusTxt = Console.ReadLine();

                arIvestasSkaicius = long.TryParse(skaiciusTxt?.Trim(), out long skaiciusIvestas);
                if (arIvestasSkaicius)
                {
                    result = skaiciusIvestas;
                }
                else Console.WriteLine($"Įvedimo klaida!");

            }

            return result;
        }

        public string? InputText(string descriptionText, bool mandatory)
        {
            string? result = null;
            bool arIvestasTextas = false;

            while (!arIvestasTextas)
            {
                Console.Write($"{descriptionText}");
                string? text = Console.ReadLine()?.Trim();


                if ((text?.Length>0 && text != null) || (text?.Length==0 && !mandatory) )
                {
                    result = text;
                    arIvestasTextas = true;
                }
                else if ((text?.Length < 1 || text == null) && mandatory)
                {
                    Console.WriteLine($"Laukas negali buti neužpildytas.Tusčias.");
                }

            }

            return result;
        }

        public void PressAnyKey()
        {
            Console.WriteLine("Paspauskite bet kurį klavišą, kad tęstumėte.");
            Console.ReadKey(false);
        }

        public bool ChooseYesOrNo(string menuText)
        {
            bool inputData = true;
            bool ret = false;

            Console.WriteLine($"{menuText}");

            Console.WriteLine("'y' - Taip  'n' - Ne");
            while (inputData)
            {
                ConsoleKeyInfo keyInput;

                keyInput = Console.ReadKey(true);
                var keyInputCode = keyInput.Key;
                switch (keyInputCode)
                {
                    case ConsoleKey.Y:
                        ret = true;
                        inputData = false;
                        break;
                    case ConsoleKey.N:
                        ret = false;
                        inputData = false;
                        break;
                }
          
            }
            return ret;
        }
    }
}
