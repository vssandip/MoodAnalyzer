namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \"WElcome to Mood Analyzer\" ");
            Mood a = new Mood();
            Console.WriteLine("Enter mood");
            string c = Console.ReadLine();
            Console.WriteLine(a.check(c));
        }
    }
}