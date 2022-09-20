using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P055_DB_DataSeed.Services
{
    public class BatuParduotuve : IBatuParduotuve
    {
        private readonly IParduotuveRepository _repository;

        public BatuParduotuve(IParduotuveRepository repository)
        {
            _repository = repository;
        }

        public void Begin()
        {
            Console.WriteLine("Pasirinkite veiksma:");
            //Console.WriteLine("1. Pardavimų statistika");
            Console.WriteLine("2. Pirkimas");
            var veiksmas = Console.ReadKey().Key;

            if (veiksmas == ConsoleKey.NumPad2) Pirkti();
        }

        private void Pirkti()
        {
            while (true)
            {
                Console.Clear();
                var turimiBatai = _repository.GetBatai();
                foreach (var batas in turimiBatai)
                {
                    Console.WriteLine($"Batas Nr. {batas.BatasId} {batas.Tipas} {batas.Pavadinimas} kaina {batas.Kaina}Eur");
                }
                Console.WriteLine("Pasirinkite bato Nr. kurį norite pirkti");
                int batasId = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Pasirinkite dydį");
                var pasirinktasBatas = turimiBatai.First(x => x.BatasId == batasId);
                foreach (var dydis in pasirinktasBatas.Dydziai)
                {
                    Console.WriteLine($"{dydis.Dydis} turimas kiekis - {dydis.Kiekis}");
                }
                int ivestasDydis = int.Parse(Console.ReadLine());
                var pasirinktasDydis = pasirinktasBatas.Dydziai.First(x => x.Dydis == ivestasDydis);
                Console.WriteLine("Nurodykite kiekį");
                var kiekis = int.Parse(Console.ReadLine());

                _repository.InsertPardavimasIrSumazintiKieki(pasirinktasDydis.Id, kiekis);

                Console.WriteLine();
                Console.WriteLine("Tęsti pirkimą? t/n ");
                var pirkti = Console.ReadKey().Key;
                if (pirkti == ConsoleKey.N)
                    break;
            }
        }
    }
}
