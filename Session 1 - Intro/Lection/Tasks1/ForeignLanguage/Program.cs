using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();


            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Mexico":
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
