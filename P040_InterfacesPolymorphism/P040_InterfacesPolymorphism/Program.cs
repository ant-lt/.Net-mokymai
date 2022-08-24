namespace P040_InterfacesPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Interfaces and Polymorphism!");

            SecondExampleShopInterfaces();

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
         */

    }
}