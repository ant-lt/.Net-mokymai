namespace P044_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Extensions!");

            string text = "Hello, Extensions!";
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToRandomCase());

            List<string> list = new List<string>();
            list.SortBySecondLetter(text);

            SortBySecondLetter(list);

        }

        public static List<string> SortBySecondLetter(List<string> text)
        {
            return new List<string>();
        }
    }

    public static class StringExtensions
    {
        private static Random random = new Random();

        public static string ToRandomCase(this string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if(random.Next(2) == 0)
                    result += text.Substring(i,1).ToUpper();
                else
                    result += text.Substring(i, 1).ToLower();
            }

            return result;
        }

        public static List<string> SortBySecondLetter(this List<string> text, string a)
        {
            //kazkokia implementacija
            return new List<string>();
        }

    }
}