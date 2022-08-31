using P045_Generic.Domain.Interfaces;
using P045_Generic.Domain.Models;

namespace P045_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Generic!");

            FirstExample();


        }

        /// <summary>
        /// FirstExample()
        /// </summary>
        public static void FirstExample()
        {
            // Pirmas generic pavyzdys
            List<int> genericNumber = new List<int>();
            List<string> genericStringList = new List<string>();
            List<DateTime> genericDateTime = new List<DateTime>();
            IList<decimal> genericDecimalList = new List<decimal>();
            IList<ITool> keybordList = new List<ITool>();

            IList<ITool> toolList = new List<ITool>();

            Fork fork1 = new Fork();
            Keyboard keyboard1 = new Keyboard();
            toolList.Add(fork1);
            toolList.Add(keyboard1);

            foreach (ITool tool in toolList)
            {
                tool.PrintName();
            }

            // Antras generic pavyzdys
            Dictionary<int, string> userDictionary = new Dictionary<int, string>();
            Dictionary<Guid, double> hashDictionary = new Dictionary<Guid, double>();
            Dictionary<Guid, Keyboard> userDictionary2 = new Dictionary<Guid, Keyboard>();

            // Musu paciu sukurtas generic klase
            NodeList<int> numberNodeList = new NodeList<int>();

            numberNodeList.Add(10);
            numberNodeList.Add(10);
            numberNodeList.Add(9);
            numberNodeList.Add(10);
            numberNodeList.Add(10);

            numberNodeList.ProcessAllNodes();

            Console.WriteLine("----------------");

            numberNodeList.DeleteNode(10);

            numberNodeList.ProcessAllNodes();


            NodeList<string> stringNodeList = new NodeList<string>();
            stringNodeList.Add("Chicken");
            stringNodeList.Add("Car");
            stringNodeList.Add("Manufacturing");
            stringNodeList.Add("Sky");
            stringNodeList.Add("EasyGoing");

            stringNodeList.ProcessAllNodes();

            Console.WriteLine("----------------");
            Fork fork2 = new Fork();


            NodeList<ITool> toolsNodeList = new NodeList<ITool>();
            toolsNodeList.Add(fork1);
            toolsNodeList.Add(fork2);
            toolsNodeList.Add(keyboard1);

            toolsNodeList.ProcessAllNodes();
            Console.WriteLine("----------------");

            toolsNodeList.DeleteNode(fork1);

            toolsNodeList.ProcessAllNodes();


        }

        /*
         *  Sukurkite generic klase <Cordinate>, kuri gali buti bet kokio tipo (int, string, double, datetime) kordinate x ir y asyse. 
         *  Jusu klase turetu tureti generic konstruktoriu, kuris gali priimti, bet kokio tipo x ir y kordinates. 
         *  X ir y pozicijas galima keisti ir kituose projektuose kreipiantis i objekta. 
         *  Paveldekite is <ICordinate> interface, kuris savyje turi: 
         *  string GetCordinate() // grazina x ir y kordinates viename stringe//, 
         *  void ResetCordinate() // grazina default reiksmes// metodus. 
         *  Irodykite veikima sukurdami 3 atskirus objektus. Pirmas objektas su string, antras su int, trecias su dateTime. 
         *  Testai turetu patikrinti abu metodus ir bent 3 skirtingais duomenu tipais inicializuotas reiksmes (Siem testam pasitelkite GetCordinate metoda) 
         * 
         * 
         */

    }
}