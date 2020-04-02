using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationDetailsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string tableNumber = "A100";
            int peopleCount = 4;
            DateTime reservationDateTime = new DateTime(2017, 10, 28, 11, 0, 0);
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Console.WriteLine("Table {0} has been blocked for {1} people on {2} at {3}", tableNumber, peopleCount, reservationDateTime.ToString("M/d/yyyy", cultureInfo),
            reservationDateTime.ToString("HH:mm", cultureInfo));

            Console.ReadLine();

        }
    }
}
