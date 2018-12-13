using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{

    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public string toString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();


            string command = Console.ReadLine();

            while (command != "End")
            {
                List<String> entries = command.Split().ToList();
                string name = entries[0];
                int id = int.Parse(entries[1]);
                int age = int.Parse(entries[2]);


                persons.Add(new Person()
                {
                    Name = name,
                    Id = id,
                    Age = age
                });

                command = Console.ReadLine();
            }

            persons = persons.OrderBy(x => x.Age).ToList();


            foreach (var person in persons)
            {
                Console.WriteLine(person.toString());
            }

        }
    }
}
