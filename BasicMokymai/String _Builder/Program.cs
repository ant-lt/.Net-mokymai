using System.Text;

namespace String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, StringBuilder!");

            StringBuilder sb = new StringBuilder(); // be teksto
            StringBuilder sb1 = new StringBuilder("Labas pasauli"); // sukurimo metu irasomas tekstas
            StringBuilder sb2 = new StringBuilder(123456); // sukurimo metu irasomas tekstas

            // teksto isgavimas is StringBuilderi

            Console.WriteLine(sb.ToString());

            // teksto pridejimas per StringBuilder

            sb.Append("Labas");
            sb.Append("pasauli");
            sb.AppendLine();
            sb.AppendLine("labas C#");
            Console.WriteLine(sb.ToString());

            // Teksto iterpimas
            sb.Insert(10, "  AAAAA ");

            Console.WriteLine(sb.ToString());

            // Teksto pasalinimas

            sb.Remove(6, 2);
            sb.Replace("Labas", "Hello");

        }
    }
}