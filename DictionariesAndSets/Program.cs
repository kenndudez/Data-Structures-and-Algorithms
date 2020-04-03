using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesAndSets
{
    class Program
    {
        

            static void Main(string[] args)
            {



            // SORTED DICTIONARIES
            SortedDictionary<string, string> definitions = new SortedDictionary<string, string>();
            do
            {
                Console.Write("Choose an option ([a] - add, [l] - list): ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();
                if (keyInfo.Key == ConsoleKey.A)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Enter the name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the explanation: ");
                    string explanation = Console.ReadLine();
                    definitions[name] = explanation;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (keyInfo.Key == ConsoleKey.L)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (KeyValuePair<string, string> definition in definitions)
                    {
                        Console.WriteLine($"{definition.Key}: {definition.Value}");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Do you want to exit the program? Press [y] (yes) or [n] (no).");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        break;
                    }
                }
            }
            while (true);
        }


        // DICTIONARIES
        //Dictionary<string, string> products = new Dictionary<string, string>
        //    {
        //        { "5900000000000", "A1" },
        //        { "5901111111111", "B5" },
        //        { "5902222222222", "C9" }
        //    };

            //    products["5903333333333"] = "D7";

            //    try
            //    {
            //        products.Add("5904444444444", "A3");
            //    }
            //    catch (ArgumentException)
            //    {
            //        Console.WriteLine("The entry already exists.");
            //    }

            //    Console.WriteLine("All products:");
            //    if (products.Count == 0)
            //    {
            //        Console.WriteLine("Empty");
            //    }
            //    else
            //    {
            //        foreach (KeyValuePair<string, string> product in products)
            //        {
            //            Console.WriteLine($" - {product.Key}: {product.Value}");
            //        }
            //    }

            //    Console.WriteLine();
            //    Console.Write("Search by barcode: ");
            //    string barcode = Console.ReadLine();
            //    if (products.TryGetValue(barcode, out string location))
            //    {
            //        Console.WriteLine($"The product is in the area {location}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The product does not exist.");
            //    }
            //    Console.ReadLine();
            //}

            // HASH TABLE

            //Hashtable phoneBook = new Hashtable()
            //{
            //    { "Marcin Jamro", "000-000-000" },
            //    { "John Smith", "111-111-111" }
            //};

            //phoneBook["Lily Smith"] = "333-333-333";

            //try
            //{
            //    phoneBook.Add("Mary Fox", "222-222-222");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("The entry already exists.");
            //}

            //Console.WriteLine("Phone numbers:");
            //if (phoneBook.Count == 0)
            //{
            //    Console.WriteLine("Empty");
            //}
            //else
            //{
            //    foreach (DictionaryEntry entry in phoneBook)
            //    {
            //        Console.WriteLine($" - {entry.Key}: {entry.Value}");
            //    }
            //}

            //Console.WriteLine();
            //Console.Write("Search by name: ");
            //string name = Console.ReadLine();
            //if (phoneBook.Contains(name))
            //{
            //    string number = (string)phoneBook[name];
            //    Console.WriteLine($"Found phone number: {number}");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("The number does not exist.");
            //    Console.ReadLine();
            //}
        
    }
}
