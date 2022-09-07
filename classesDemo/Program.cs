using System;

namespace classesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); 
            int age = int.Parse(Console.ReadLine());
            string lastName = Console.ReadLine();
            Student student = new Student();

            student.Name = name;
            student.Age = age;
            student.LastName = lastName;

            Console.WriteLine($" Name:{student.Name} \n Age: {student.Age} \n Last name: {student.LastName}");
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }

    }
}
