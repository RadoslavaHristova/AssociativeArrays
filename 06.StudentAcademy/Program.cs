using System.Xml.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        class Students
        {
            public Students(string name)
            {
                Name = name;
                Grades = new List<double>();
            }
            public string Name { get; set; }
            public List<double> Grades { get; set; }

            

            public override string ToString()
            {
               string result = $"{Name} -> {Grades.Average():f2}";
               return result ;
            }
        }
        static void Main(string[] args)
        {
         var studentsCollection=new Dictionary<string, Students>();
            
            int inputs=int.Parse(Console.ReadLine());
            string name = "";
            double grade = 0;
            for(int i=0; i<inputs; i++) 
            {
                name=Console.ReadLine();
                grade= double.Parse(Console.ReadLine());

                if (!studentsCollection.ContainsKey(name) )
                {
                    studentsCollection.Add(name, new Students(name));
                }
                studentsCollection[name].Grades.Add(grade);


            }
                var filteredStudents = studentsCollection.Where(s => s.Value.Grades.Average() >= 4.50);
            foreach(var kvp in filteredStudents)
            { Console.WriteLine(kvp.Value); }
        }
    }
}