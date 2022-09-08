using System;
using System.Collections.Generic;
using System.Linq;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split(" ");
                Student student = new Student(token[0], token[1], token[2]);
                list.Add(student);
            }
            list.OrderByDescending((t) => t.Grade).ThenBy((t) => t.FirstName).ToList();
            List<Student> sorted = list.OrderByDescending((t) => t.Grade).ThenBy((t) => t.FirstName).ThenBy((t)=>t.LastName).ToList();
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
        public Student(string firstName, string lastName, string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
