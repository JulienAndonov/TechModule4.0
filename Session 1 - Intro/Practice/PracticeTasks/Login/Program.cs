using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] password = username.ToCharArray();
            Array.Reverse(password);
            int counter = 0;

            string passString = String.Join("",password);
            string trypassword = Console.ReadLine();
            
            while (passString != trypassword && counter < 3)
            {
                counter++;
                Console.WriteLine("Incorrect password. Try again.");
                trypassword = Console.ReadLine();
                
             }

            if (counter >= 3)
            {
                Console.WriteLine($"User {username} blocked!");

            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
