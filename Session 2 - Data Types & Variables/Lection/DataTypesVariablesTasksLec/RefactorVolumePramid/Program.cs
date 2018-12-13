using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumePramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double leght, wight, height,volume = 0;
            Console.Write("Length: ");
            leght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            wight = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            volume = (leght * wight * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);


        }
    }
}
