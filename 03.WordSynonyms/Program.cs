namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();

            int wordsQty = int.Parse(Console.ReadLine());

                string newWord = "";
                string synonym = "";
            for (int i = 1; i <= wordsQty * 2; i++)
            {
                if (i % 2 == 0)
                {
                    synonym = Console.ReadLine();

                    if (words.ContainsKey(newWord))
                    { words[newWord].Add(synonym); }

                }
                else
                {
                    newWord = Console.ReadLine();

                    if (!words.ContainsKey(newWord))
                    { words.Add(newWord, new List<string>()); }
                }
            }
                foreach (var kvp in words)
                {
                    List<string> synonyms = kvp.Value;
                    string synonymsString = string.Join(", ", synonyms);

                    string output = $"{kvp.Key} - {synonymsString}";
                    Console.WriteLine(output);
                }

            }
        }
    }

/*
3
cute
adorable
cute
charming
smart
clever

 */