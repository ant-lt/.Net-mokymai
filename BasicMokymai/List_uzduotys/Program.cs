namespace List_uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            DidesnisUzDidziausia(fake);
        }

        /*
         * 1. DIDŽIAUSIAS SĄRAŠE
     Duotas vienmatis sveikų skaičių sąrašas. 
     Parašykite programą, kuri suranda didžiausią skaičių saraše
     { 5, 1, 6, 8, 7 }

     rezultatas:  8
         * 
         */
        public static int Didziausias_sarase(List<int> intSarasas)
        {
            intSarasas.Sort((x, y) => y - x);
            return intSarasas[0];
        }

        public static int Didziausias_sarase2(List<int> lst)
        {
            int max = lst[0];
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] > max)
                {
                    max = lst[i];
                }
            }
            return max;
        }

        /*
         * DIDESNIS UŽ DIDŽIAUSIĄ
       Duotas vienmatis sveikų skaičių sąrašas. 
       Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią

       pvz:
       { 5, 1, 6, 8, 7 }
       rezultatas:  5, 1, 6, 8, 7, 9
         * 
         * 
         */
        public static List<int> DidesnisUzDidziausia(List<int> lst)
        {
            // destytojo pvz
            //List<int> kopijaLst = new List<int>();
            //kopijaLst.AddRange(lst);

            List<int> kopijaLst= new List<int>(lst);
           
            int max = Didziausias_sarase(kopijaLst);
            lst.Add(max+1);
            return lst;

        }


        /*
         * 
         * 
         * 
         * 
         */




    }
}