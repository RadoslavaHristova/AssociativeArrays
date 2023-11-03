namespace _07.CompanyUsers
{
    internal class Program
    {
        public class Company
        {
            public Company(string name)
            {
                Name = name;
                EmployeeId = new List<string>();
            }
            public string Name { get; set; }
            public List<string> EmployeeId { get; set; }

            public override string ToString()
            {
               string result =$"{Name}\n";
                for (int i = 0; i < EmployeeId.Count; i++) 
                {
                    result += $"-- {EmployeeId[i]}\n"; 
                }
                return result.Trim();
            }
            public void AddEmployee(string id)
            { if (!EmployeeId.Contains(id))
                { EmployeeId.Add(id); }
            }
        }
        static void Main(string[] args)
        {
            var collection=new Dictionary<string, Company>();

            string command = "";

            while ((command = Console.ReadLine()) !="End")
            {
                string[]tokens=command.Split(" -> ").ToArray();
                string companyName = tokens[0], id = tokens[1];

                if(!collection.ContainsKey(companyName))
                {
                    collection.Add(companyName, new Company(companyName));
                }

                collection[companyName].AddEmployee(id);
                
            }
            foreach(var  kvp in collection)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
/*
SoftUni -> AA12345
SoftUni -> BB12345
Microsoft -> CC12345
HP -> BB12345
End

SoftUni -> AA12345
SoftUni -> CC12344
Lenovo -> XX23456
SoftUni -> AA12345
Movement -> DD11111
End
 */