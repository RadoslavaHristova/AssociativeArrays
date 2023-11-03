namespace _05.Courses
{
    internal class Program
    {
        class Course
        {
            public Course(string name)
            {
                Name = name;
                StudentsNames = new List<string>();
            }
            public string Name { get; set; }
            public List<string> StudentsNames { get; set; }

            public override string ToString()
            {
                string result = $"{Name}: {StudentsNames.Count}\n";

                for (int i = 0; i < StudentsNames.Count; i++)
                {
                    result += $"-- {StudentsNames[i]}\n";
                }
                return result.Trim();
            }
        }
        static void Main(string[] args)
        {
            var courseCollection = new Dictionary<string, Course>();

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" : ");
                string courseName = tokens[0], studentName = tokens[1];

                if (!courseCollection.ContainsKey(courseName))
                {
                    Course nCourse = new Course(courseName);
                    courseCollection.Add(courseName, nCourse);
                }
                courseCollection[courseName].StudentsNames.Add(studentName);
            }
            foreach (var kvp in courseCollection)
            { Console.WriteLine(kvp.Value); }

        }
    }
}
/*
Programming Fundamentals : John Smith
Programming Fundamentals : Linda Johnson
JS Core : Will Wilson
Java Advanced : Harrison White
end

 */