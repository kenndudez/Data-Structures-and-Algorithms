using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList02
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Marcin", Country = CountryEnum.PL, Age = 29 });
            people.Add(new Person() { Name = "Sabine", Country = CountryEnum.DE, Age = 25 });
            people.Add(new Person() { Name = "Caroline", Country = CountryEnum.UK, Age = 21 });
            people.Add(new Person() { Name = "John", Country = CountryEnum.UK, Age = 21 });
            people.Add(new Person() { Name = "Nick", Country = CountryEnum.DE, Age = 28 });
            people.Add(new Person() { Name = "Ann", Country = CountryEnum.PL, Age = 31 });

            List<Person> results = people.OrderBy(p => p.Name).ToList();
            foreach (Person person in results)
            {
                Console.WriteLine($"{person.Name} ({person.Age} years) from {person.Country}.");

            }
            Console.ReadLine();
        }
    }
    
}
