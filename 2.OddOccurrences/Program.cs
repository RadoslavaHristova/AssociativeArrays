using System.Diagnostics.Metrics;

namespace _2.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List < string > words= Console.ReadLine()
                 .Split()
                 .ToList();

            var wordsCount = new Dictionary<string, int>();
            
            foreach ( string word in words )
            {
               string toLower= word.ToLower();

                if( !wordsCount.ContainsKey(toLower) )
                { wordsCount.Add(toLower, 1); }
                else
                { wordsCount[toLower]++; }
            }

            foreach (var count in wordsCount)

            {if(count.Value%2!=0)
                { Console.Write(count.Key + " "); }
            }
        }
        }
    }
