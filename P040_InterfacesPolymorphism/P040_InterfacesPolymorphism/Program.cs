using System.Security.Claims;

namespace P040_InterfacesPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Interfaces and Polymorphism!");

            SecondExampleShopInterfaces();

            Console.WriteLine();

            Console.WriteLine("-----------------");
            IEatable saladUnhealthy = new Salad();
            IHealthy saladHealthy = new Salad();
            saladUnhealthy.GetVitamins();
            saladHealthy.GetVitamins();

        }


        #region FirstExampleOfInterfaces

        // Deklaruojame kontrakta, kuri privalo igyvendinti BETKOKIA klase, kuri paveldeja si inteface
        // Viskas ka mes apsirasome igyvendinti PRIVALO buti public
        public interface INameable
        {
            // Mes privalome tureti paveldejancioje klaseje property pavadinimu Name su get ir set metodais
            string Name { get; set; }
            // Mes privalome turetu paveldejancioje klaseje void metoda pavadinimu PrintName()
            void PrintName();
        }

        public interface IColoreable
        {
            public string Color { get; set; }
        }

        public class C : INameable, IColoreable
        {
            public string Name { get; set; }
            private string color;

            public string Color
            {
                get { return color + " colorification"; }
                set { color = value; }
            }


            public void PrintName()
            {
                Console.WriteLine($"{Name} - {Color}");
            }
        }

        public class D
        {
            // Klases kontrakto dalis yra VISKAS KAS YRA PUBLIC
            public string Color { get; set; } // Klases kontrakto dalis
            private List<INameable> _items = new List<INameable>();
            public void AddItem(INameable itemWithName) // Klases kontrakto dalis
            {
                _items.Add(itemWithName);
            }

            public void PrintItems()
            {
                foreach (INameable item in _items)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        public class A : C
        {
            public A()
            {
                Name = "A";
                Color = "Green";
            }

            public string Type { get; set; }
        }

        public class B : INameable
        {
            public B()
            {
                Name = "B";
            }

            public string Name { get; set; }

            public void PrintName()
            {
                throw new NotImplementedException();
            }
        }

        public static void FirstBasicInterfaceExample()
        {
            // Inicializuojame A klase kaip objekta, kurio veiksnumas yra apibreztas TIK INameable interface dalyje
            // Pasiekti kitu A klases atributu mes nebegalime, nes mes apibreziame interface scope ()
            INameable a1 = new A()
            {
                Name = "A",
                Color = "Green"
            };

            A a2 = new A()
            {
                Name = "A2",
                Color = "Teal"
            };

            A a3 = new A()
            {
                Name = "A3",
                Color = "Purple"
            };

            // a1.Color = "Blue"; // Nevalidu, nes Color nepakliuna po kontrakto/interface INameable dalimi.
            a2.Color = "Blue";


            INameable b1 = new B();

            D d1 = new D();
            d1.AddItem(a1);
            d1.AddItem(b1);
        }

        #endregion
        #region SecondExampleOfInterfaces
        public interface IPurchasable
        {
            string Name { get; }
            double Price { get; set; }
            int Discount { get; }
            void ChangeDiscount(int discountPercentage);
            void PrintLabel();
        }

        public class Food : IPurchasable, IEquatable<Food>, IEquatable<A>
        {
            public Food()
            {

            }
            public Food(string type)
            {
                Type = type;
                Console.WriteLine($"Constructor from Food was called. Type was set to: {Type}");
            }

            public Food(string type, string name)
            {
                Type = type;
                Name = name;
                Console.WriteLine($"Constructor from Food was called. Type was set to: {Type}. Name was set to: {Name}");
            }

            public string Type { get; set; }

            // Interface dalis
            public string Name { get; protected set; }
            // Interface dalis
            public double Price { get; set; }
            // Interface dalis
            public int Discount { get; protected set; }
            // Interface dalis
            public void ChangeDiscount(int discountPercentage)
            {
                Discount = discountPercentage;
            }

            public bool Equals(Food other) => other.Type == Type;

            public bool Equals(A other) => other.Type == Type;
            // Interface dalis
            public void PrintLabel()
            {
                Console.WriteLine($"Food product {Name}:{Type} is priced at: {Price}");
            }
        }

        public class Apple : Food
        {
            public Apple() { }
            public Apple(string color, int quality, int size, double price) : base("Fruit", $"{color} {quality}/5* {size}/5 size")
            {
                Color = color;
                Quality = quality;
                Size = size;
                Price = price;
            }

            public string Color { get; }
            public int Quality { get; }
            public int Size { get; private set; }
            public void ChangeSize(int newSize)
            {
                Size = newSize;
            }
        }

        public class Pizza : Food
        {
            public Pizza() { }
            public Pizza(string name, double price) : base("Pizza", name)
            {
                Price = price;
                Console.WriteLine("Constructor from Pizza was called");
            }
            public string CompanyName { get; set; }
        }

        public class Furniture : IPurchasable
        {
            public Furniture() { }
            public Furniture(string name)
            {
                Name = name;
            }

            public string Color { get; protected set; }
            public string Material { get; protected set; }

            // Interface dalis
            public string Name { get; protected set; }
            // Interface dalis
            public double Price { get; set; }
            // Interface dalis
            public int Discount { get; protected set; }
            // Interface dalis
            public void ChangeDiscount(int discountPercentage)
            {
                Discount = discountPercentage;
            }

            public void PrintLabel()
            {
                Console.WriteLine($"Furniture product {Name}:{Material} is priced at: {Price}");
            }
        }

        public class Chair : Furniture
        {
            public Chair() { }
            public Chair(string color, string material, string name, double price) : base(name)
            {
                Color = color;
                Material = material;
                Price = price;
            }
        }

        // public class GeneratedConstructorClass { } // Pavyzdine klase
        public interface IAccount
        {
            string BankNo { get; }
            string OwnerName { get; }
            string GetAccountInfo();
            double Withdraw(double money);
            double TransferMoney(double money);
        }

        public class CheckingAccount : IAccount
        {
            public CheckingAccount() { }

            public CheckingAccount(string ownerName, string bankNo, double money)
            {
                OwnerName = ownerName;
                BankNo = bankNo;
                Money = money;
            }

            public string BankNo { get; }

            public string OwnerName { get; }
            protected double Money { get; set; }

            public string GetAccountInfo() => $"{OwnerName} bank account has {Money}$";

            public double TransferMoney(double price)
            {
                double deducedMoney = Money - price;
                Console.WriteLine($"From: {Money} a deduction was made to {deducedMoney}");
                Money = deducedMoney;
                return Money;
            }

            public double Withdraw(double money)
            {
                throw new NotImplementedException();
            }
        }

        public class SavingAccount : IAccount
        {
            public string BankNo => throw new NotImplementedException();

            public string OwnerName => throw new NotImplementedException();

            public string GetAccountInfo()
            {
                throw new NotImplementedException();
            }

            public double TransferMoney(double money)
            {
                throw new NotImplementedException();
            }

            public double Withdraw(double money)
            {
                throw new NotImplementedException();
            }
        }

        public interface ICart
        {
            public void AddToCart(IPurchasable item);
            public void Purchase(IAccount account);
            public void PrintItemList();
        }
        public class Cart : ICart
        {
            protected List<IPurchasable> Items { get; set; } = new List<IPurchasable>();
            public void AddToCart(IPurchasable item)
            {
                Items.Add(item);
                Console.WriteLine($"Item '{item.Name}' was successfully added to the cart.");
            }

            public void PrintItemList()
            {
                foreach (IPurchasable item in Items)
                {
                    Console.WriteLine($"{item.Name} - {item.Price}$");
                }
            }

            public void Purchase(IAccount account)
            {
                double priceTotal = Items.Sum(i => i.Price);
                account.TransferMoney(priceTotal);
                Console.WriteLine($"Transfer of {priceTotal}$ was deducted from {account.OwnerName} account.");
                Console.WriteLine($"{account.OwnerName} brought items included:");
                PrintItemList();
                //foreach(IPurchasable item in Items)
                //{
                //    priceTotal += item.Price;
                //}

            }
        }

        public static void SecondExampleOfInterfaces()
        {
            Food burger = new Food("Burger");
            Food pizza1 = new Food("Pizza");
            Food pizza2 = new Food("Pizza");
            A a1 = new A()
            {
                Type = "Pizza"
            };

            Console.WriteLine($"Is burger == pizza: {burger.Equals(pizza1)}");
            Console.WriteLine($"Is pizza == pizza: {pizza1.Equals(pizza2)}");
            Console.WriteLine($"Is a.Type == pizza.Type: {pizza1.Equals(a1)}");
        }

        public static void SecondExampleShopInterfaces()
        {
            Apple redApple = new Apple("Red", 4, 4, 0.79);
            // Naudojant interface mes nebegalime pasiekti Color, Quality ir Size
            IPurchasable greenApple = new Apple("Green", 4, 3, 0.79);
            redApple.ChangeSize(3);
            // greenApple.ChageSize(4); // Negalima igyvendinti del to, kad tai nera kontrakto dalis
            greenApple.Price = 0.89;

            // Kada mes kaireje puseje deklaruojam Class varda, siuo atveju <Pizza>, mes galime pasiekti visus egzistuojancius atributus <Pizza>
            // ir paveldejimose klasese (Siuo atveju mes galime pasiekti <Pizza> attributus ir <Food> atributus ir <Object> atributus)
            Pizza italianPizza = new Pizza("Le Express", 9.99);
            // Kada mes kaireje puseje deklaruojam Interface varda, siuo atveju <IPurchasable>, mes galime pasiekti TIK <IPurchasable> atributus.
            // Siuo atveju mes negaletume pasiekti <CompanyName>
            IPurchasable americanPizza = new Pizza("Americano", 12.99);
            IPurchasable blueDenimChair = new Chair("Denim", "Plastic", "Denimo", 15.99);

            IAccount mainAccount = new CheckingAccount("Edvinas", "LT984598185180", 5000);

            ICart cart = new Cart();
            cart.AddToCart(redApple);
            cart.AddToCart(greenApple);
            cart.AddToCart(italianPizza);
            cart.AddToCart(americanPizza);
            cart.AddToCart(blueDenimChair);

            cart.PrintItemList();

            cart.Purchase(mainAccount);
        }

        public interface IEatable
        {
            void GetVitamins();
        }

        public interface IHealthy
        {
            void GetVitamins();
        }

        public class Salad : IEatable, IHealthy
        {
            void IHealthy.GetVitamins()
            {
                Console.WriteLine("A, B, C");
            }
            void IEatable.GetVitamins()
            {
                Console.WriteLine("E496");
            }

            public void GetVitamins()
            {
                Console.WriteLine("A, B, C, E496");
            }
        }
        #endregion


        /*
         * Uzduotis 1: Sukurkite klasę Skaicius . Savyje turi tik readonly kintamąjį kuriame saugoma reikšmė sveikasis skaičius.
            - Sukurkite interfeisą IMatematika .
            - Interfeise aprašykite metodus: (Pridėti, Atimti, Padauginti, Padalinti --> metodams bus paduodamas sveikasis skaičius ir bus grąžinama reikšmė),
            - PakeltiKvadratu , PakeltiKubu --> metodai grąžina reikšmes.
            - Klasė Skaicius paveldi interfeisą .
            - Implementuokite paveldėtus metodus.
            Irodyti veikima parasant testus kiekvienam metodui.
         * 
         * 
         * 
         * Uzduotis 2. - Sukurti klasę Figura , kuri saugo pavadinimą readonly propertyje
         *- Sukurti interfeisą IGeometrija , kurioje aprašyti du metodai Plotas ir Perimetras. Abu grąžina double reikšmes.
         *- Sukurti klases: Kvadratas, Staciakampis , Statusis Trikampis ir Apskritimas 
            (klasėse susikurti reikiamus properčius fieldus visi jie turi būti readonly ). 
         *- Kiekviena klasė paveldi klasę Figura ir interfeisą IGeometrija.
         *- Realizuoti klases.
         * Irodyti veikima parasant testus kiekvienam metodui.
         * 
         * 
            Uzduotis 3: Sukurkite interface <IPayable>. Sis interface bus naudojamas apskaitos departamento sistemose rasant israsus. <IPayable> turetu tureti sias tris kontrakto funkcines dalis:
            1.	Isgauti dabartine alga
            2.	Padidinti esama alga
            3.	Isgauti uzmokescio adresa (Fizinis siunciamas laisku)
            Sukurkite klase <Employee> ir paveldekite ja <Person> klaseje (Snippet pasiimkit is apacios)
        internal class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }
        <Employee> turetu tureti siuos properties:
        1.	Salary {get;private set;}
        2.	Mailing address {get;private set;}

        <Employee> turetu paveldeti is <IPayable> interface. Kiekviena kontrakto dali uzpildykite logiskais sprendimais pvz: IPayable adreso isgavimo funkcionalumas turetu grazinti zmogaus esama registruota adresa.
        Irodyti veikima parasant testus kiekvienam metodui.

         * 
         * 
         * Uzduotis 4
        -	Sukurti <Movie> klase (Id, CreationDate)
        -	Sukurti <Music> klase (Id, Length, ArtistName)
        -	Sukurti <Game> klase (Id, Platform, IsMultiplayer)
        -	Sukurti <IHobby> interface ir visoms sukurtoms klasems sukurti interface implementacijas:
        o	String Name get
        o	String Publisher get
        o	String Genre get
        o	Int Rating get
        o	String GetHobbyName() -> Turetu grazinti atgal ar tai filmas, daina ar zaidimas
        o	String GetHobbyInformation() -> Turetu grazinti atgal informacija apie pati hobi pvz, kad tai filmas kazkokio zanro, kurio ivertinimas yra X/Y
        -	Sukurti <Person> klase, kuri turetu savyje laikyti sarasa megstamiausiu dalyku. Turetume galeti programos eigoje prideti i ta pati sarasa bet koki Hobby t.y Movie, Music, Game
        -	Sukurti <IPerson>
        o	Void Interact(<IHobby>) -> Turetu atspausdinti i ekrana informacija apie tai kas ivyksta kada vartotojas nusprendzia uzsiimti paduota veikla. Pvz jei buna paduodamas filmas i ekrana turetu isvesti “<UserName> will now watch a <MovieName> which is a <Genre> movie.
        o	string GetFavoriteHobbyType() -> Turetu gauti hobio tipa (pvz Movie). Atspausdinti apie tai informacija I ekrana ir grazinti atgal hobio pavadinima
        o	IHobby GetFavoriteHobby() -> Turetu grazinti megstamiausios rusies hobio auksciausia ivertinima turincio iraso informacija
        o	List<IHobby> GetFavoriteFromEachHobby() -> Turetu grazinti auksciausio ivertinimo irasa is kiekvienos rusies hobio
        o	String GetFavoriteMusicGenre() -> Turetu grazinti megstamiausia dazniausiai pasikartojanti muzikos zanra zmogaus hobiuose
        o	Dictionary<string, int> GetEachHobbyAvgRating() -> Grazina dictionary su irasais kuriuose key yra hobio tipas pvz filmas, o value yra vidurkis
        o	Void ShareHobbies(<Person>) -> Pasidalina hobiais su paduotu zmogumi ir tie hobiai prisideda prie perduoto zmogaus hobiu
        o	Void ShareOldMovies(<Person>) -> Pasildaina filmais, kurie atsirado veliau nei 2010 metai
        o	List<IHobby> FindSimilarHobbies(<Person>) -> Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais
        o	List<IHobby> FindSimilarHobbies(<Person>, string hobbyType) -> Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais ir yra tik tarp perduoto hobbyType pvz filmu
        o	List<string> FindMatchingGenres(<Person>, string hobbyType) -> Randa sutampancius zanrus su paduoto zmogaus, kurie butu paduoto hobby tipo
        -	Prie <Person> pridekite nauja sarasa List<IHobby> CheckoutList
        -	Sukurkite nauja <Person> metoda void AddRandomToCheckList(<Person>), kuris prideda nauja(Nesikartojanti) hobby is kito zmogaus atsitiktine tvarka, 
        -	Visus metodus istestuoskite
         * 
         */

    }
}