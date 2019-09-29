using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Vlad",
                "Dasha",
                "Mimimi",
                "Dasha",
            };
            List<int> ages1 = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
            };
            List<int> ages2 = new List<int>
            {
                3,
                4,
                5,
            };
            int i = 1;
            var newAges1 = ages1.Where(x => x < 4).Reverse().Union(ages2).Select(x => Convert.ToString($"{i++}. {x}")).Union(names).Skip(1).Distinct().OrderByDescending(x => x.Contains("a")).ThenBy(x => x);
            //Console.WriteLine(string.Join(Environment.NewLine, newAges1));
            var newAges2 = ages1.Where(x => x < 4); // newAges2 is IEnuberable, that have all elements in ages1 that < 4
            var newAges3 = ages1.Where(x => x < 4).Reverse(); // And reverse (change to the opposite)
            var newAges4 = ages1.Where(x => x < 4).Reverse().Union(ages2); // And add ages2 without repetition
            var newAges5 = ages1.Where(x => x < 4).Reverse().Union(ages2).Select(x=>Convert.ToString($"{i++}. {x}")); // And Convert to string and add numbering
            var newAges6 = ages1.Where(x => x < 4).Reverse().Union(ages2).Select(x=>Convert.ToString($"{i++}. {x}")).Skip(1); // And skip first element
            var newAges7 = ages1.Where(x => x < 4).Reverse().Union(ages2).Select(x=>Convert.ToString($"{i++}. {x}")).Skip(1).Distinct(); // And delete all distinction
            var newAges8 = ages1.Where(x => x < 4).Reverse().Union(ages2).Select(x=>Convert.ToString($"{i++}. {x}")).Skip(1).Distinct().OrderByDescending(x => x.Contains("1")); // And first all elements, that have 1
            var newAges9 = ages1.Where(x => x < 4).Reverse().Union(ages2).Select(x=>Convert.ToString($"{i++}. {x}")).Skip(1).Distinct().OrderByDescending(x => x.Contains("1")).ThenBy(x => x); // And to alphabetically
            var newAges10 = ages1.Count(); // Count all elements
            var newAges11 = ages1.Sum(); // Sum all elements
            var newAges12 = ages1.Take(6); // Take 6 elements, if elements are small than 6, take all elements 
            var newAges13 = ages1.Aggregate((x, y) => y > x ? y : x); // If y > x, x = y, else x = x
            var newAges14 = ages1.Aggregate(10, (x, y) => y > x ? y : x); // x = 10, if y > x, x = y, else x = x, return x
            var newAges15 = ages1.All(x => x == 5); // If all elements have 5 return true, else - return false
            var newAges16 = ages1.Any(x => x == 2); // If any elements have 2 return true, else - return false
            var newAges17 = ages1.Append(4); // Add 4
            var newAges18 = ages1.AsEnumerable(); // Convert to IEnumerable
            var newAges19 = ages1.AsParallel(); // 
            var newAges20 = ages1.AsQueryable(); // Convert to Queryable
            var newAges21 = ages1.Average(); // Return average (середнє значення)
            var newAges22 = ages1.Cast<long>(); // Casts the elements of an IEnumerable to the long type
            var newAges23 = ages1.Concat(ages2); // Add IEnumerable<T> to IEnumerable<t> (ages2 to ages1)
            var newAges24 = ages1.ElementAt(0); // Take 1 element 
            var newAges25 = ages1.ElementAtOrDefault(50); // Take some element by the index, if index is OutOfRange - element is equal null/0
            var newAges26 = ages1.First(); // Take first element
            var newAges27 = ages1.FirstOrDefault(); // Take first element, if element is OutOfRange - element is equal null/0
            var newAges28 = ages1.Last(); // Take last element
            var newAges29 = ages1.LastOrDefault(); // Take last element, if last element is OutOfRange - element is equal null/0
            var newAges30 = ages1.Except(ages2); // All elements ages1, except ages2
            //var newAges31 = ages1.GroupJoin(); // 
            var newAges32 = ages1.Intersect(ages2); // Is intersect ages1 and ages2
            //var newAges33 = ages1.Join(ages2, x => x, p => p, (x,p) => Convert.ToString($"{x} + {p} = {x+p}")); // If element ages1 = elevement ages2 return their sum
            var newAges34 = ages1.LongCount(); // Return count elements in long
            var newAges35 = ages1.Max(); // Max element
            var newAges36 = ages1.Max<int>(); // Max element
            var newAges37 = ages1.Min(); // Min element
            var newAges38 = ages1.Min<int>(); // Min element
            //var newAges39 = ages1.OfType<long>(); // 
            var newAges40 = ages1.Prepend(2); // Adds element to the beginning IEnumerable
            //var newAges41 = ages1.Reverse(); // 
            var newAges42 = ages1.Select(x => Convert.ToString($"Element - {x}")); // 
            //var newAges43 = ages1.SelectMany(); // 
            var newAges44 = ages1.SequenceEqual(ages2); // 
            var newAges45 = ages1.Single(x => x == 5); // If IEnumerable has 1 element "5", return 5. If IEnumerable has't element 5, return InvalidOperationException. If IEnumerable has 2 element 5, return InvalidOperationException: 
            var newAges46 = ages1.SingleOrDefault(x => x == 5); // If IEnumerable has 1 element "5", return 5. If IEnumerable has't element 5, return null/0. If IEnumerable has 2 element 5, return InvalidOperationException: 
            var newAges47 = ages1.Skip(5); // Skip 5 element
            var newAges48 = ages1.SkipWhile(x => x*x < 7); // Skip all elements that, when raised to a degree less than 7
            var newAges50 = ages1.Sum(); // Sum all elements
            var newAges51 = ages1.Take(3); // Take first 3 elements
            var newAges52 = ages1.TakeWhile(x => x*x < 7); // Take first elements that, when raised to a degree less than 7
            var newAges53 = ages1.Union(ages2); // Sum all elements ages1 and ages2 without repetition
            var newAges54 = ages1.Where(x => x == 3); // Return all elements are equal 3
            var newAges55 = ages1.Zip(ages2,  (x,y) => x + y); // Add element x to element y

            Console.WriteLine(string.Join(Environment.NewLine, newAges55));

            Console.WriteLine();

            List<int> agees = new List<int>
            {
                54,
                12,
                23,
                12,
            };
            var test = agees.GroupBy(g => g).Where(g => g.Count() > 1).Select(g => g.Key); // test is Enumerable, that have all elements, that are more 1 in agees
            Console.WriteLine(string.Join(Environment.NewLine, test));

            Console.ReadKey();
        }
    }
}
