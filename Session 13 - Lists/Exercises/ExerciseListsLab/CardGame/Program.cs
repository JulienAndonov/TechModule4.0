using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cardsPlayerOne = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            List<int> cardsPlayerTwo = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            



            while (true)
            {
                if (cardsPlayerOne.Count == 0 || cardsPlayerTwo.Count == 0)
                {
                    break;
                }
                
                    if (cardsPlayerOne.First() > cardsPlayerTwo.First())
                    {
                        cardsPlayerOne.Add(cardsPlayerOne.First());
                        cardsPlayerOne.Add(cardsPlayerTwo.First());
                        cardsPlayerOne.RemoveAt(0);
                        cardsPlayerTwo.RemoveAt(0);
                
                    }
                    else if (cardsPlayerOne.First() < cardsPlayerTwo.First())
                    {
                        cardsPlayerTwo.Add(cardsPlayerTwo.First());
                        cardsPlayerTwo.Add(cardsPlayerOne.First());
                        cardsPlayerTwo.RemoveAt(0);
                        cardsPlayerOne.RemoveAt(0);
                        
                    }else if (cardsPlayerOne.First() == cardsPlayerTwo.First())
                    {
                        cardsPlayerOne.RemoveAt(0);
                        cardsPlayerTwo.RemoveAt(0);
                    }
                }
            
            Console.WriteLine($"{(cardsPlayerOne.Count >0 ? "First": "Second")} player wins! Sum: {(cardsPlayerOne.Sum() > cardsPlayerTwo.Sum() ? cardsPlayerOne.Sum() : cardsPlayerTwo.Sum())}");
        }
    }
}