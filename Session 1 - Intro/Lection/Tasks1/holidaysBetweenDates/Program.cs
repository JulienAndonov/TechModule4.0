using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holidaysBetweenDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);


            var holiday = CountHolidaysBetween(startDate,endDate);
            

            Console.WriteLine(holiday);



        }


        public static int CountHolidaysBetween(DateTime start, DateTime end)
        {
            DateTime current = start.Date;
            int count = 0;
            while (current <= end.Date)
            {
                if (current.DayOfWeek == DayOfWeek.Sunday || current.DayOfWeek == DayOfWeek.Saturday)
                {
                    count++;
                }
                current = current.AddDays(1);
            }
            return count;
        }
    }
}
