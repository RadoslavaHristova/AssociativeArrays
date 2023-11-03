namespace _01.CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> inputChars=Console.ReadLine().ToList();

            var collectionWithCounts=new Dictionary<char, int>();
            
            for (int i = 0; i < inputChars.Count; i++)
            {

            if (inputChars[i] == ' ')
                { continue; }

            if (!collectionWithCounts.ContainsKey(inputChars[i]))
                { collectionWithCounts.Add(inputChars[i], 1);}
            else
                { collectionWithCounts[inputChars[i]]++; }

            }

            foreach(var kvp in collectionWithCounts) 
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}