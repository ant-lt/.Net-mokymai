using P046_OOP_Baigiamasis.Enums;
using P046_OOP_Baigiamasis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace P046_OOP_Baigiamasis.Models
{
    public class Game
    {
        internal const int NumberOfTowers = 3;
        internal const int NumberOfDisks = 4;
        internal int MinimalNumberOfMoves = (int)Math.Pow(2, NumberOfDisks)-1;
        internal int move = 0;
        internal Disc? diskOnHand;
        internal string? errorMessage;

        internal List<Tower> towers = new List<Tower>();
        internal FileConfig filesConfig = new FileConfig();
        private KeyboardInput userInput = new KeyboardInput();
        internal List<LogFile> logFiles = new List<LogFile>();
        internal Statistics statistics = new Statistics();

        private bool IsDiskOnHand()
        {
            return diskOnHand != null;
        }

        public Game()
        {

            userInput.ChooseFilesConfiguration(this);


            for (int i = 0; i < NumberOfTowers; i++)
            {
                towers.Add(new Tower());
            }

            Initialize();
        }

        private void Initialize()
        {
            move = 0;
            diskOnHand = null; // nera pasirinktas nei vienas diskas

            // isvalyti sarasus disku kiekviename Tower jeigu jau anksciai buvo zaidimas
            for (int i = 0; i < NumberOfTowers; i++)
            {
                towers[i].Disks.Clear();
            }


            //pirmo boksto pastatymas uzpildymas diskais
            for (int i = 0; i < NumberOfDisks + 1; i++)
            {
                towers[0].Disks.Add(new Disc(i));
            }

            // tusciu bokstu pastatymas be disku
            for (int i = 1; i < NumberOfTowers; i++)
            {
                for (int ii = 0; ii < NumberOfDisks + 1; ii++)
                {
                    towers[i].Disks.Add(new Disc(0));
                }
            }
        }

        public void Run()
        {
            int input = 0;
            bool isRunning = true;
            Screen screen = new Screen();
 
            do
            {                
                screen.Refresh(this);

                if (!IsDiskOnHand())
                {
                    input = userInput.GetTower("Pasirinkite stulpelį iš kurio paimti");
                    if (input > 0)
                    {
                        if (OnTowerSelectFrom(input))
                        {
                            move++;
                        }
                        else
                        {
                            errorMessage = "STULPELYJE NĖRA DISKO";
                        }
                    }
                    else if (input == (int)Ekey.ANY ) 
                    {
                        errorMessage = "NETEISINGA ĮVESTIS";
                    }
                }
                else
                {
                    input = userInput.GetTower("Pasirinkite stulpelį į kurį padėti");

                    if (input > 0 && !OnTowerSelectTo(input)) 
                    {
                        errorMessage = "NEGALIMA DIDESNIO DISKO DĖTI ANT MAŽESNIO";
                    }
                }

                if (IsWin())
                {
                    
                    screen.Refresh(this);
                    screen.ShowMessage("Laimejote");
                    statistics.ShowGameStatistics(this);
                    
                    Console.ReadKey(true);
                    Initialize();

                }
                if (input == (int)Ekey.ESCAPE)
                    isRunning = false;
                   
            } while (isRunning);

            // logu irasymas i failus pagal nustatytus formatus
            foreach (var logFile in logFiles)
            {
                logFile.SaveData();
            }
            

        }

        private bool IsWin()
        {
            bool winCondition = false;
            int counterOfDisksOnRightPlace = 0;

            for (int i = 0; i < NumberOfDisks + 1; i++)
            {
                if (towers[NumberOfTowers - 1].Disks[i].CountOfElements == i) counterOfDisksOnRightPlace++; 
            }

             if (counterOfDisksOnRightPlace == NumberOfDisks + 1) winCondition = true;

            return winCondition;
        }

        private bool OnTowerSelectFrom(int selectedTower)
        {
            bool result = false;

            int? diskIndex = FindTopDiskOnTower(selectedTower);

            if (diskIndex.HasValue)
            {
                diskOnHand = towers[selectedTower - 1].Disks[(int)diskIndex];
                towers[selectedTower - 1].Disks[(int)diskIndex] = new Disc(0);
                towers[selectedTower - 1].IsTowerFromSelected = true;
                result = true;
            }

            return result;
        }

        private bool OnTowerSelectTo(int selectedTower)
        {
            bool result = false;

            int? diskIndex = FindTopDiskOnTower(selectedTower);

            if (diskIndex is null)// tuscias tower jame nera nei vieno disko
            {
                towers[selectedTower - 1].Disks[NumberOfDisks] = diskOnHand;
                diskOnHand = null;
                result = true;
            }
            else if (IsMoveAllowed(selectedTower, diskIndex))
            {
                towers[selectedTower - 1].Disks[(int)diskIndex - 1] = diskOnHand;
                diskOnHand = null;
                result = true;
            }
            else
            {
                result = false;
            }

            
            if (result)
            {
                DeselectTowerMark(); // nuimti rodykles nuo pazymeto tower jeigu diskas padedamas i pasirenkta tower
                foreach (var logFile in logFiles)
                {
                    logFile.AddToLog(new LogItem { Move = move, Disk1 = FindDiskTower(1), Disk2 = FindDiskTower(2), Disk3 = FindDiskTower(3), Disk4 = FindDiskTower(4) });
                }
                
            }
            return result;
        }

       
        private void DeselectTowerMark()
        {
            foreach (var tower in towers)
            {
                tower.IsTowerFromSelected = false;
            }
        }

        private bool IsMoveAllowed(int selectedTower, int? TowerTopDiscIndex)
        {
            bool result = false;

            if (towers[selectedTower - 1].Disks[(int)TowerTopDiscIndex].CountOfElements > diskOnHand?.CountOfElements)
            {                
                result = true;
            }

            return result;
        }

        private int? FindTopDiskOnTower(int selectedTower)
        {
            int? result=null;

            for (int i = 1; i < NumberOfDisks + 1; i++)
            {
                if (towers[selectedTower - 1].Disks[i].CountOfElements > 0)
                {
                    result = i;                   
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Grąžina stulpelio numeri kur yra nurodyto dydžio diskas
        /// </summary>
        /// <param name="diskSize"></param>
        /// <returns></returns>
        private int FindDiskTower(int diskSize)
        {
            int result =0;

            for (int i = 0; i < NumberOfTowers; i++)
            {
                for (int ii = 0; ii < NumberOfDisks + 1; ii++)
                {
                    if (towers[i].Disks[ii].CountOfElements == diskSize)
                    {
                        result = i+1;
                        break;
                    }
                }
                if (result > 0) break;
            }
            return result;
        }

       


    }
}
