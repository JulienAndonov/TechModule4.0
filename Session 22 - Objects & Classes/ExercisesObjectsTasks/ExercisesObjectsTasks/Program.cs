using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesObjectsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<String> phrases = new List<string>() { "Excellent product", "Such a great product", "I always use that product", "Best product of its category", "Exceptional product", "I can’t live without this product" };
            List<String> events = new List<string>() { "Now I feel good", "I have succeeded with this product", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome", "Try it yourself, I am very satisfied", "I feel great!" };
            List<String> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<String> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfRecords = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfRecords; i++)
            {
                string randomPhrase = phrases[random.Next(0, phrases.Count - 1)];
                string randomEvent = events[random.Next(0, events.Count - 1)];
                string randomAuthor = authors[random.Next(0, authors.Count - 1)];
                string randomCity = cities[random.Next(0, cities.Count - 1)];


                Console.WriteLine($"{randomPhrase}. {randomEvent}. {randomAuthor} - {randomCity}");
            }
        }
    }
}
