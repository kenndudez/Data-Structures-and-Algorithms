using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {

            Dictionary<PoolTypeEnum, HashSet<int>> tickets = new Dictionary<PoolTypeEnum, HashSet<int>>()
            {
                { PoolTypeEnum.RECREATION, new HashSet<int>() },
                { PoolTypeEnum.COMPETITION, new HashSet<int>() },
                { PoolTypeEnum.THERMAL, new HashSet<int>() },
                { PoolTypeEnum.KIDS, new HashSet<int>() }
            };

            for (int i = 1; i < 100; i++)
            {
                foreach (KeyValuePair<PoolTypeEnum, HashSet<int>> type in tickets)
                {
                    if (GetRandomBoolean())
                    {
                        type.Value.Add(i);
                    }
                }
            }

            Console.WriteLine("Number of visitors by a pool type:");
            foreach (KeyValuePair<PoolTypeEnum, HashSet<int>> type in tickets)
            {
                Console.WriteLine($" - {type.Key.ToString().ToLower()}: {type.Value.Count}");
                Console.ReadLine();
            }

            PoolTypeEnum maxVisitors = tickets
                .OrderByDescending(t => t.Value.Count)
                .Select(t => t.Key)
                .FirstOrDefault();
            Console.WriteLine($"Pool '{maxVisitors.ToString().ToLower()}' was the most popular.");
            Console.ReadLine();

            HashSet<int> any = new HashSet<int>(tickets[PoolTypeEnum.RECREATION]);
            any.UnionWith(tickets[PoolTypeEnum.COMPETITION]);
            any.UnionWith(tickets[PoolTypeEnum.THERMAL]);
            any.UnionWith(tickets[PoolTypeEnum.KIDS]);
            Console.WriteLine($"{any.Count} people visited at least one pool.");
            Console.ReadLine();

            HashSet<int> all = new HashSet<int>(tickets[PoolTypeEnum.RECREATION]);
            all.IntersectWith(tickets[PoolTypeEnum.COMPETITION]);
            all.IntersectWith(tickets[PoolTypeEnum.THERMAL]);
            all.IntersectWith(tickets[PoolTypeEnum.KIDS]);
            Console.WriteLine($"{all.Count} people visited all pools.");
            Console.ReadLine();

            Console.WriteLine("RECREATION: " + string.Join(" ", tickets[PoolTypeEnum.RECREATION]));
            Console.WriteLine("COMPETITION: " + string.Join(" ", tickets[PoolTypeEnum.COMPETITION]));
            Console.WriteLine("THERMAL: " + string.Join(" ", tickets[PoolTypeEnum.THERMAL]));
            Console.WriteLine("KIDS: " + string.Join(" ", tickets[PoolTypeEnum.KIDS]));

           

        }
            private static bool GetRandomBoolean()
            {
                return random.Next(2) == 1;


                // Example One on Set (Coupons)
                //HashSet<int> usedCoupons = new HashSet<int>();
                //do
                //{
                //    Console.Write("Enter the coupon number: ");
                //    string couponString = Console.ReadLine();
                //    if (int.TryParse(couponString, out int coupon))
                //    {
                //        if (usedCoupons.Contains(coupon))
                //        {
                //            Console.ForegroundColor = ConsoleColor.Red;
                //            Console.WriteLine("The coupon has been already used :-(");
                //            Console.ForegroundColor = ConsoleColor.Gray;
                //        }
                //        else
                //        {
                //            usedCoupons.Add(coupon);
                //            Console.ForegroundColor = ConsoleColor.Green;
                //            Console.WriteLine("Thank you! :-)");
                //            Console.ForegroundColor = ConsoleColor.Gray;
                //        }
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}
                //while (true);

                //Console.WriteLine();
                //Console.WriteLine("A list of used coupons:");
                //foreach (int coupon in usedCoupons)
                //{
                //    Console.WriteLine(coupon);
                //}
            }
        }
    }
