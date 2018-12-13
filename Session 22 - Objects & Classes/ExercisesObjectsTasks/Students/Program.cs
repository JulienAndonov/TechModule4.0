using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }


        public string toString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";



        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();



            int numberOfStudents = int.Parse(Console.ReadLine());



            for (int i = 0; i < numberOfStudents; i++)
            {
                List<string> entries = Console.ReadLine().Split().ToList();

                string firstName = entries[0];
                string lastName = entries[1];
                double grade = double.Parse(entries[2]);

                students.Add(new Student()
                {

                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                });
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.toString());
            }



        }
    }
}
