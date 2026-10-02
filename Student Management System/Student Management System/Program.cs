namespace Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student defaultConst = new Student();
                Console.WriteLine("Enter name:");
                defaultConst.Name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                defaultConst.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter GPA:");
                defaultConst.GPA = double.Parse(Console.ReadLine());

                Student firstparamStudent = new Student("John Doe", 25, 3.5);

                Student secondParamStudent = new Student("Jane Smith", 22, 3.8);

                Student copyStudent = new Student(firstparamStudent);
                copyStudent.Name = "John Doe Copy";

                List<Person> students = new List<Person>
                {
                    new Person("Alice", 20),
                    defaultConst,
                    firstparamStudent,
                    secondParamStudent,
                    copyStudent

                };
                foreach(Person person in students) {
                    person.PrintInfo();
                }
                Console.WriteLine();
                Console.WriteLine($"Total students: {Student.StudentCount}");
                Console.WriteLine('\n');
                firstparamStudent.PrintInfo();// Original student
                copyStudent.PrintInfo();// Copied student

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
