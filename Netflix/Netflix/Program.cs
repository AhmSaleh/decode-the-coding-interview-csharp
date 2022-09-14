using Netflix.Feature_1;

namespace Netflix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Feature 1 Run
            var titles = new List<string> { "duel", "dule", "speed", "spede", "deul", "cars" };
            var titlesDic = Feautre1.getAnagramDict(titles);

            foreach (var kvp in titlesDic)
            {
                foreach (var title in kvp.Value)
                {
                    Console.Write($"{title} ");
                }

                Console.WriteLine();
            }






        }
    }
}