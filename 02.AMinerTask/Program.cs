namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resourcesCollection =new Dictionary<string, int>();
            string currentResource = "";
            string command = "";
            int counter = 0;
            while((command=Console.ReadLine()) != "stop")
            {
            counter++;
                if(counter%2!=0) 
                {
                    currentResource = command;

                if(!resourcesCollection.ContainsKey(command))
                    { resourcesCollection.Add(command, 0); }
                }

                else
                {
                   
                     resourcesCollection[currentResource] += int.Parse(command); 
                }
            }
            foreach(var kvp in resourcesCollection)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
        /*
Gold
155
Silver
10
Copper
17
Gold
15
stop

         */
    }
}