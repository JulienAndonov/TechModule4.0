using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passed
{
    public class Program
    {
      public static void Main()
      {
          double grade = double.Parse(Console.ReadLine());


          if (grade >= 3)
          {
              Console.WriteLine("Passed!");
          }
      }
    }
}
