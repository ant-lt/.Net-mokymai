namespace String_kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String (tekstinio) tipo kintamieji");
            string kintamasis = "Hello World";
            Console.WriteLine(kintamasis);

            var stringkintamasis = "bet koks tekstas";
            string tuscias = "";
            string nulas = null;
            string laisvaerdve = "         ";

            string tekstas = "";

            string konkatinacija = stringkintamasis + kintamasis;

            Console.WriteLine(konkatinacija);

            string kompozicija = string.Format("{0}", stringkintamasis);
            string interpoliacija = $"{stringkintamasis}";

            kintamasis = "tekstas belekoks";

            Console.WriteLine(kintamasis);


        }
    }
}