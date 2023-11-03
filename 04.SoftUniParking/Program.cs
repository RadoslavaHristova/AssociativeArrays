/* 
4
register Jony AA4132BB
register Jony AA4132BB
register Linda AA9999BB
unregister Jony

6
register Jacob MM1111XX
register Anthony AB1111XX
unregister Jacob
register Joshua DD1111XX
unregister Lily
register Samantha AA9999BB
 */
namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int commandsCount =int.Parse(Console.ReadLine());

           var parkingCollections=new Dictionary<string,string>();

            for(int i = 0; i < commandsCount; i++) 
            {
                string[]token=Console.ReadLine()
                    .Split()
                    .ToArray();

                string username = token[1];

                switch(token[0])
                {
                    case "register":
                        if(!parkingCollections.ContainsKey(username))
                        { 
                            parkingCollections.Add(username, token[2]);
                            Console.WriteLine($"{username} registered {token[2]} successfully");                      
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parkingCollections[username]}");
                        }
                        break;

                    case "unregister":
                        if(!parkingCollections.ContainsKey(username))
                        { 
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{username} unregistered successfully");
                            parkingCollections.Remove(username);
                        }
                        break;
                }
            }
            foreach(var kvp in parkingCollections )
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}