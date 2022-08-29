namespace P042_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Abstract!");

            //SearchEngine searchEngine = new SearchEngine(); //taip negalima
            SearchEngine googleSearchEngine = new GoogleSearchEngine();
            SearchEngine duckDuckGoSearchEngine = new DuckDuckGoSearchEngine();

            string[] googleResults = googleSearchEngine.Search("aa");
            string[] duckDuckGoResults = duckDuckGoSearchEngine.Search("bb");
            Console.WriteLine($"googleResults = [{string.Join(", ", googleResults)}]");
            Console.WriteLine($"duckDuckGoResults = [{string.Join(", ", duckDuckGoResults)}]");

            string[] googleResults1 = googleSearchEngine.Result("");
            string[] duckDuckGoResults1 = duckDuckGoSearchEngine.Result("");
            Console.WriteLine($"googleResults1 = [{string.Join(", ", googleResults1)}]");
            Console.WriteLine($"duckDuckGoResults1= [{string.Join(", ", duckDuckGoResults1)}]");

        }
    }
}