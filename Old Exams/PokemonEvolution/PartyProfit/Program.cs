using System;

namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int gain = 50 * days;


            for (int i = 1; i <= days; i++)

            {
                if (i % 15 == 0)
                {
                    partySize = partySize + 5;

                }

                if (i % 10 == 0)
                {
                    partySize = partySize - 2;

                }

                if (i % 3 == 0)
                {
                    gain = gain - 3 * partySize;
                }



                if (i % 5 == 0)
                {
                    gain = gain + 20 * partySize;

                    if (i % 3 == 0)
                    {
                        gain = gain - 2 * partySize;
                    }

                }




                gain = gain - 2 * partySize;



            }
            Console.WriteLine("{0} companions received {1} coins each.", partySize, (gain) / partySize);
        }
    }
}