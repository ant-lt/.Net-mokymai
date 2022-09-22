using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb_Namu_darbas.Services
{
    public class ShoeShop: IShoeShop
    {
        private readonly IShoeShopRepository _repository;

        public ShoeShop(IShoeShopRepository shoeShopRepository)
        {
            _repository = shoeShopRepository;
        }

        public void Begin()
        {
            Console.WriteLine("Pasirinkite veiksma:");
            //Console.WriteLine("1. Pardavimų statistika");
            Console.WriteLine("2. Pirkimas");
            var operation = Console.ReadKey().Key;
            if (operation == ConsoleKey.NumPad2) Purschase();
        }

        private void Purschase()
        {
            while (true)
            {
                Console.Clear();
                var shoesList = _repository.GetAllShoes();

                foreach (var shoe in shoesList)
                {
                    Console.WriteLine(shoe.ShoeId + shoe.Type + shoe.Name);
                }
                Console.WriteLine("Pasirinkite bato nr. kuri norite pirkti");

                int shoeId = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Pasirinkite dydi");
                var selectShoe = shoesList.First(x => x.ShoeId == shoeId);

                foreach (var size in selectShoe.ShoeSizes)
                {
                    Console.WriteLine(size.Size + size.Quantity);
                }

                int selectSize = int.Parse(Console.ReadLine());
                var choosedSize = selectShoe.ShoeSizes.First(x => x.Size == selectSize);

                Console.WriteLine("Nurodykite kieki");

                var quatity = int.Parse(Console.ReadLine());

                _repository.MakePurchaseAndReduceQuantity(choosedSize.ShoeID, quatity);

                Console.WriteLine();

                Console.WriteLine("Testi pirkima? t/n");

                var purchase = Console.ReadKey().Key;
                if (purchase == ConsoleKey.N)
                    break;

            }
        }
    }
}
