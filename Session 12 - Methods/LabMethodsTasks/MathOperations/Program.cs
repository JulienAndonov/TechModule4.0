using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            performOperation(firstNumber, @operator, secondNumber);

        }

        public static void performOperation(int firstNumber, char op, int secondNumber)
        {
            switch (op)
            {
                case '/':
                {
                    Console.WriteLine(firstNumber/secondNumber);
                }
                    break;
                case '*':
                {
                    Console.WriteLine(firstNumber * secondNumber);
                }
                    break;
                case '+':
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }
                    break;
                case '-':
                {
                    Console.WriteLine(firstNumber - secondNumber);
                }
                    break;
            }
        }
    }
}
