using P045_Generic.Domain.Interfaces;
using P045_Generic.Domain.Models;

namespace P045_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Generic!");

            BasicGenericExamples();
            GenericConstraintsAndFilters();

        }

        /// <summary>
        /// FirstExample()
        /// </summary>
        #region PIRMI_PAVYZDZIAI

        //Kolekcijos, kurios yra generic
        // List<T>
        // Dictionary <K, L>
        // ICollection<T>
        // IList<T>
        // LinkedList<T>
        // HashSet<T>
        // Queue<T>
        // Stack<T>
        public static void BasicGenericExamples()
        {
            // Pirmas generic pavyzdys
            List<int> genericNumberList = new List<int>();
            List<string> genericStringList = new List<string>();
            List<DateTime> genericDateTimeList = new List<DateTime>();
            IList<decimal> genericDecimalList = new List<decimal>();
            IList<ITool> toolList = new List<ITool>();

            Fork fork1 = new Fork();
            Keyboard keyboard1 = new Keyboard();
            toolList.Add(fork1);
            toolList.Add(keyboard1);

            //foreach(ITool tool in toolList)
            //{
            //    tool.PrintName();
            //}


            // Antras generic pavyzdys
            Dictionary<int, string> userDictionary = new Dictionary<int, string>();
            Dictionary<Guid, double> hashDictionary = new Dictionary<Guid, double>();
            Dictionary<Guid, Keyboard> keyboardDictionary = new Dictionary<Guid, Keyboard>();

            // Musu paciu sukurta generic klase
            NodeList<int> numberNodeList = new NodeList<int>();
            numberNodeList.Add(10);
            numberNodeList.Add(10);
            numberNodeList.Add(9);
            numberNodeList.Add(10);
            numberNodeList.Add(10);

            numberNodeList.ProcessAllNodes();

            Console.WriteLine("------------------------");

            numberNodeList.DeleteNode(10);

            numberNodeList.ProcessAllNodes();

            NodeList<string> stringNodeList = new NodeList<string>();
            stringNodeList.Add("Chicken");
            stringNodeList.Add("Car");
            stringNodeList.Add("Manufacturing");
            stringNodeList.Add("Sky");
            stringNodeList.Add("EasyGoing");

            stringNodeList.ProcessAllNodes();

            Fork fork2 = new Fork();

            NodeList<ITool> toolNodeList = new NodeList<ITool>();
            toolNodeList.Add(fork1);
            toolNodeList.Add(fork2);
            toolNodeList.Add(keyboard1);

            toolNodeList.ProcessAllNodes();

            Console.WriteLine("------------------------");

            toolNodeList.DeleteNode(fork1);

            toolNodeList.ProcessAllNodes();

            ICustomList<int> number2List = new NodeList<int>();
        }

        #endregion

        /* Uzduotis 1
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

        #region ANTRI_PAVYZDZIAI
        public static void GenericConstraintsAndFilters()
        {
            // Generic contstraints arba kitaip zinoma kaip filtrai:
            // struct -> filtras skirtas atskirti ar perduodama yra value dalis
            // class -> filtras skirtas atskirti ar perduodama dalis yra refference tipo
            // new() -> filtras skirtas atskirti ar perduodame klase su tusciu konstruktoriu
            // <BETKOKIA_KLASE> -> filtras skirtas atskirti ar perduodame nurodyta klase
            // <BETKOKS_INTERFACE> -> filtras skirtas atskirti ar perduodame nurodyto interface klase
            // U -> filtras skirtas patikrinti paveldimuma

            NodeListFilterStruct<int> structNodeList = new NodeListFilterStruct<int>();
            NodeListFilterStruct<DateTime> structNodeList2 = new NodeListFilterStruct<DateTime>();
            // NodeListFilterStruct veikia tik su value tipais
            //NodeListFilterStruct<ITool> structNodeList3 = new NodeListFilterStruct<ITool>();

            NodeListFilterClass<ITool> classNodeList = new NodeListFilterClass<ITool>();
            NodeListFilterClass<string> invalidClassNodeList = new NodeListFilterClass<string>();
            // NodeListFilterClass veik,ia tik su refference tipais
            // NodeListFilterClass<int> invalidClassNodeList = new NodeListFilterClass<int>();

            NodeListFilterClassNew<Fork> forkNodeList = new NodeListFilterClassNew<Fork>();
            // NodeListFilterClassNew priima tik klases duomenu tipus, kurie turi tuscia konstruktoriu
            // NodeListFilterClassNew<ITool> invalidClassNewNodeList = new NodeListFilterClassNew<ITool>();

            NodeListFilterSpecifiedClass<Tool> toolSpecClassNodeList = new NodeListFilterSpecifiedClass<Tool>();
            NodeListFilterSpecifiedClass<Fork> forkSpecClassNodeList = new NodeListFilterSpecifiedClass<Fork>();
            // NodeListFilterSpecifiedClass priima tik klase, kuri buvo nurodyta, arba klases, kurios paveldeja is pateiktos klases
            //NodeListFilterSpecifiedClass<ITool> invalidForkSpecClassNodeList = new NodeListFilterSpecifiedClass<ITool>();

            NodeListFilterSpecifiedInterface<ITool> toolSpecInterfaceNodeList = new NodeListFilterSpecifiedInterface<ITool>();
            NodeListFilterSpecifiedInterface<Fork> forkSpecInterfaceNodeList = new NodeListFilterSpecifiedInterface<Fork>();
            // NodeListFilterSpecifiedInterface priima tik interface arba klases, kurios paveldeja nurodyta interface
            // NodeListFilterSpecifiedInterface<int> invalidIntSpecInterfaceNodeList = new NodeListFilterSpecifiedInterface<int>();

            NodeListFilterSpecifiedMultipleInterface<Fork> nodeListFilterSpecifiedMultipleInterface = new NodeListFilterSpecifiedMultipleInterface<Fork>();
            // NodeListFilterSpecifiedMultipleInterface priima tik klases arba interface, kurie paveldeja visas filtruojamas (Constrained) interfaces arba klases.
            // NodeListFilterSpecifiedMultipleInterface<ITool> nodeListFilterSpecifiedMultipleInterface = new NodeListFilterSpecifiedMultipleInterface<Fork>();

            NodeListWithMultipleTypes<int, string> wordGenericList = new NodeListWithMultipleTypes<int, string>();
            wordGenericList.Add(1, "Blabla");

            NodeListFilterU<Fork, ITool> forkIToolNodeList = new NodeListFilterU<Fork, ITool>();
            NodeListFilterU<Fork, Tool> forkToolNodeList = new NodeListFilterU<Fork, Tool>();
            // NodeListFilterU priima tik klases, kurios paveldeja is U (Antro perduoto duomenu tipo)
            // NodeListFilterU<Fork, Keyboard> toolForkNodeList = new NodeListFilterU<Fork, Keyboard>();
        }

        #endregion

        /*
            Uzduotis 2
            Pries uzduotis susikurti 3 klases: PrivateClient, Administrator, 
            BusinessClient. Visos jos paveldeja is interface IUser (int Id get set, string Name get set, )
            Sukurti generic <EntityRepository> klase, kuri priimtu klases su tusciu 
            konstruktoriumi duomenu tipa ir turetu metodus: Add, Remove, Print(), Fetch(). 
            Repository savyje turi tureti generic sarasa, kuris priimtu sias 3 klases: 
            PrivateClient, Administrator, BusinessClient. 
            Tam, kad igyvendintumete salyga naudokite interface kaip duomenu tipa savo repository objektui. 
            Veikima irodykite testu pagalba(Isskyrus print) ir Main() metode idekite naujai sukurtus 
            3 objektus (Kiekvienai klasei po viena) i nauja sukurta sarasa.
        */

    }
}