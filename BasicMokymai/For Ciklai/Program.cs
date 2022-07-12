namespace For_Ciklai
{
    public class Program
    {
        static void Main(string[] args)
        {
            ForLoopNesting();
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void ForLoopBack()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        private static void BreakForLoop()
        {
            int skaicius = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == skaicius)
                {
                    break;
                }
            }
        }
        private static void SkipIterationForLoop()
        {
            int praleistiIteracija = 5;
            int pradziosTaskas = 0;
            int pabaigosTaskas = 10;

            for (int i = pradziosTaskas; i < pabaigosTaskas; i++)
            {
                if (i == praleistiIteracija)
                {
                    Console.WriteLine("Skip");
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        private static void ForLoopNesting()
        {

            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(i);
            }
        }

        public static bool DNRGrandinesValidacija_Replace( string dnr)
        {
            var s = dnr.Replace("-", "")
                .Replace("A", "")
                .Replace("T", "")
                .Replace("C", "")
                .Replace("G", "");
            return s.Length ==0;
        }

        public static bool DNRGrandinesValidacija_For(string dnr)
        {
            for (int i = 0; i < dnr.Length; i++)
            {
                if (dnr[i] != '-' &&
                        dnr[i] != 'A' &&
                        dnr[i] != 'T' &&
                        dnr[i] != 'C' &&
                        dnr[i] != 'G')
                { return false; }
            }
            return true;
           
        }

        public static int KiekKartuPasikartoja_For_Interpoliation(string dnr, string element)
        {
            var count = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                if ($"{dnr[i]}{dnr[i+1]}{dnr[i+2]}" == element)
                    count++;
            }
            return count;
        }

        public static int KiekKartuPasikartoja_For_Composition(string dnr, string element)
        {
            var count = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                var s = string.Format("{0}{1}{2}",dnr[i],dnr[i + 1],dnr[i + 2]);
                if ( s == element)
                    count++;
            }
            return count;
        }

        public static int KiekKartuPasikartoja_For_Concat(string dnr, string element)
        {
            var count = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                string s = "";
                for (int j = 0; j < 3; j++)
                {
                    s += dnr[i + j].ToString();
                }
                if ( s == element)
                {
                    count++;
                }
            }
            return count;
        }


    }
}