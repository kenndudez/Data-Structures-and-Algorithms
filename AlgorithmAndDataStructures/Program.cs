using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months= new string[12];

            for(int month= 1; month<=12; month++)
            {
                DateTime FirstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = FirstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                months[month - 1] = name;
            }

            foreach (string month in months)
            {
                Console.WriteLine($"-> {month}");

            }

            Console.ReadLine();
        }
    }
}
