namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> words=Console.ReadLine()
                .Split()
                .Where(w=> w.Length %2== 0)
                .ToList();
            foreach(string word in words) 
            {
            Console.WriteLine(word);
            }
        }
        //kiwi orange banana apple
    }
}