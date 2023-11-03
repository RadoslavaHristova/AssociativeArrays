namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            var counts=new SortedDictionary<int, int>();

            foreach (var number in numbers) 
            {
            if (counts.ContainsKey(number))
                { counts[number]++; }
            else
                { counts.Add(number, 1); }
            }

             

            foreach(var number in counts)
            { Console.WriteLine($"{number.Key} -> {number.Value}"); }
        }
    }
}