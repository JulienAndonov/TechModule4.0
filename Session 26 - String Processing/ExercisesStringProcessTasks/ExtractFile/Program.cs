using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine().Split('\\');
            string[] fileDesc = file[file.Length - 1].Split('.');


            Console.WriteLine($"File name: {fileDesc[0]}");
            Console.WriteLine($"File extension: {fileDesc[1]}");






        }
    }
}
