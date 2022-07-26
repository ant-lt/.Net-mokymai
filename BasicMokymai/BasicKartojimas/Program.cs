/* C# - Program Structure
   
A C# program consists of the following parts −
   - Namespace declaration
   - A class
   - Class methods
   - Internal methods
   - Method variables
   - Class variables
   - A Main method (entry point)
   - Statements and Expressions
   - Comments
*/

using System.Diagnostics;

namespace BasicKartojimas  // <-- Namespace declaration
{
    internal class Program // <---A class
    {
        public static int ManoKintamasis = 5; // <---- Class variables, field

        static void Main(string[] args) // <--- A Main method (entry point)
        {
            //DemoPaskaitoje();

            //Laipsninis Piesimas su konssole.
            //KonsolesValymas();

            //Switch / Machine states

            //Informacijos perdavimas su ref ir out

            //pvz. kada reiktų naudoti globalius kintamuosius, nes kitaip neišeitų išspręsti problemos

            //pvz.kai turime metodą, kuris priima string[] ir gražina char[]
            //var a = ToCharArray(new string[] { "namas", "auto", "komp" });
            //Console.WriteLine(string.Join(",", a));

            //char[] b = "kjdshfjkhdsfjksfskhfdks".ToCharArray();
            //Console.WriteLine(string.Join(",", b));

            //Kodėl cikluose reikia naudoti tik StringBuilder, o ne paprasta string?

            //for ir forech esminiai skirtumai ir pritaikymo limitacijos

            //validavimas, kad patikrint ar įvestas int, string, char TryParse ir Try Catch

            //null (ne apibrėžimas), o kada naudojam ir klaidos 'might be null' paaiškinimas ir kaip išvengti

            //array vs list, tuščio array užpildymas
            TuscioArrayPildymas();

            //while ir for loop skirtumai

            //plačiau apie github galimybes

            //Kuriais atvejais geriausia naudoti Debuginima


            //Metodo rekursija: už ir prieš

            //kodėl programuotojai negyvena ilgai :) (virš 40 skaičius krenta)

            //object? darant metoda, kartais programa sukuria "Private static object"
            //var dd = KazkoksMetodas();

            //uInt? kada panaudojame?

            //Debug kada verta naudoti? Ar dažnai naudojamas praktikoje
            //Debug.WriteLine("Hello World!");
        }

        private static object KazkoksMetodas()
        {
            throw new NotImplementedException();
        }

        #region array vs list, tuščio array užpildymas

        public static void TuscioListPildymas()
        {
            Random rnd = new Random();
            List<int> skaiciai = new List<int>(); //tuscias list

            for (int i = 0; i < 10; i++)
            {
                skaiciai.Add(rnd.Next(10)); //list pildymas
            }
        }
        public static void TuscioArrayPildymas()
        {
            Random rnd = new Random();
            int[] skaiciai = new int[10]; //tuscias array
            string[] tekstai = new string[10];


            Console.WriteLine(string.Join(",", skaiciai));
            Console.WriteLine(string.Join(",", tekstai));
            Console.WriteLine(tekstai.Length);

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rnd.Next(10); //array pildymas
            }
            Console.WriteLine(string.Join(",", skaiciai));
        }


        #endregion



        #region for ir forech esminiai skirtumai ir pritaikymo limitacijos

        public static void ForNaudojimas()
        {
            Random rnd = new Random();
            List<int> skaiciai = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                skaiciai.Add(rnd.Next(10));
            }
        }
        public static void ForeachNaudojimas()
        {
            List<int> skaiciai = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius);
            }

            //for (int i = 0; i < skaiciai.Count; i++)
            //{
            //    Console.WriteLine(skaiciai[i]);
            //}
        }


        #endregion


        #region Metodo shorthand sintaksė
        public static int TrumpasMetodas(int a) => a + a; //lambda function
        public static int TrumpasMetodasPailginas(int a)
        {
            var b = a == 0 ? "nulis" : "ne nulis"; //ternary operator

            var c = a switch
            {
                0 => "nulis",
                _ => "ne nulis"
            };//swith expresson


            int? duomenysIsInterneto = GautiDuomenisIsInterneto();

            var rezultas = duomenysIsInterneto ?? 0 * 10; //null-coalescing operator
            var rezultas2 = duomenysIsInterneto != null ? duomenysIsInterneto * 10 : null;


            return a + a;
        }

        private static int? GautiDuomenisIsInterneto()
        {
            //kazka daro
            return null;
        }


        #endregion

        #region pvz. kai turime metodą, kuris priima string[] ir gražina char[]
        public static char[] ToCharArray(string[] strArr)
        {
            string str = string.Join("", strArr);
            return str.ToCharArray();
        }
        #endregion

        #region pvz. kada reiktų naudoti globalius kintamuosius, nes kitaip neišeitų išspręsti problemos

        public static void Klausimas3Metodas(int a)
        {
            Klausimas3Metodas1(a);
        }
        public static void Klausimas3Metodas1(int a)
        {
            a = a + 9;
            Klausimas3Metodas2(a);
        }

        public static void Klausimas3Metodas2(int a)
        {
            a = 9 - a;
            Klausimas3Metodas3(a);
        }
        public static void Klausimas3Metodas3(int a)
        {
            a = 10 / a;
            Console.WriteLine(a);
            //kazkokia logika
        }
        #endregion

        #region Informacijos perdavimas su ref ir out

        public static bool TryParseReload(string input, out int result)
        {
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }



        #endregion


        #region Laipsninis Piesimas su konsole.
        public static void KonsolesValymas()
        {
            //Laipsninis Piesimas su konssole.
            while (true)
            {
                Console.WriteLine("Iveskite skaiciu arba parasykite 'exit'");
                string input = Console.ReadLine();

                if (input == "exit")
                    break;

                Console.Clear();
                if (int.TryParse(input, out _))
                {
                    Console.WriteLine($"Ivedete skaiciu {input}.");
                }
                else
                {
                    Console.WriteLine("Ivedete neteisingai bandykite dar karta, bet dabar tikrai skaiciu");
                }



            }
        }
        #endregion

        #region witch / Machine states
        public static void StateMachine(int state)
        {
            switch (state)
            {
                case 1:
                    Metodas1();
                    break;
                case 2:
                    Metodas2();
                    break;
                case 3:
                    Metodas3();
                    break;
                    //ir t.t.
            }
        }


        public static void Metodas1()
        {
            //kazkokia logika
        }
        public static void Metodas2()
        {
            //kazkokia logika
        }
        public static void Metodas3()
        {
            //kazkokia logika
        }

        #endregion

        public static void DemoPaskaitoje()
        {
            Console.WriteLine("Hello, World!"); // <--- Statement  (method invocation)
            int counter; // <-- Declaration statement.
            counter = 5; // <-- Assignment statement.

            double pi = 3.14; // <-- Declaration and initialize.

            List<string> strings = new List<string>(); // <-- Expression statement (new object creation).
            Random rnd = new Random(); //<-- Expression statement (new object creation).

            int[] radii = { 15, 32, 108, 74, 9 }; // Declare and initialize an array.
            foreach (int radius in radii)
            {
                // Declaration statement with initializer.
                double circumference = pi * (2 * radius);
            }

            #region **** C# - Type Conversion ****
            double d = 5673.74;
            int i;
            i = (int)d;

            decimal dd = i;

            #endregion

            #region **** C# - Type Conversion ****
            string skaiciusTekste = "42";
            Console.WriteLine(Convert.ToByte(skaiciusTekste));
            Console.WriteLine(Convert.ToChar(skaiciusTekste));
            Console.WriteLine(Convert.ToDecimal(skaiciusTekste));
            Console.WriteLine(Convert.ToDouble(skaiciusTekste));
            Console.WriteLine(Convert.ToInt32(skaiciusTekste));
            Console.WriteLine(Convert.ToUInt32(skaiciusTekste));


            Console.WriteLine(byte.Parse(skaiciusTekste));

            byte.TryParse(skaiciusTekste, out byte skaicius);
            Console.WriteLine(skaicius);

            #endregion



        }



        public static void ManoMetodas() // <-- Class methods
        {
            //...... kazkokia logika
            int kintamasis = 5; // <---- Method variable
            void VidinisMetodas() // <------ Internal method
            {
                ManoKintamasis = 50;
                //.... kazkokia logika
            }
        }

        // <---- Comment
        /*...*/ // <---- Comment
    }
}