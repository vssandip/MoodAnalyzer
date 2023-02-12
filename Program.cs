namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" \"WElcome to Mood Analyzer\" ");
            //Mood a = new Mood();
            //Console.WriteLine("Enter mood");
            //string c = Console.ReadLine();
            //Console.WriteLine(a.check(c));
            //Mood1 a = new Mood1("i am sad");
            //Mood1 b = new Mood1("i am happy");

            //Console.WriteLine("Enter mood");
            //string c = Console.ReadLine();
            //Console.WriteLine(a.check());
            //Console.WriteLine(b.check());
            Mood2 a = new Mood2("i am sad");
            Mood2 b = new Mood2("i am happy");

            Console.WriteLine("Enter mood");
            string c = Console.ReadLine();
            Console.WriteLine(a.check());
            Console.WriteLine(b.check());
        }
    }
}