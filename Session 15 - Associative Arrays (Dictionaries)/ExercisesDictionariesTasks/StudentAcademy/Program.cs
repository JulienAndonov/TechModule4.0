using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRecords = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            

            for (int i = 0; i < numberOfRecords; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }


            students = students
                .Where(x => x.Value.Sum() / x.Value.Count >= 4.50)
                .OrderByDescending(x => x.Value.Sum() / x.Value.Count)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var student in students)
            {
                double avarage = student.Value.Sum() / student.Value.Count;
                Console.WriteLine($"{student.Key} -> {avarage:F2}");
            }
        }
    }
}
