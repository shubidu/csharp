using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<char> chars = new List<char>();
            for (int alpha = 0; alpha < 30; alpha++)
            {
                
                chars.Add((char) ('A' + rand.Next(26)));
            }

            var sorted =
                from e in chars
                orderby e
                select e;

            var sortedDesc =
                from e in chars
                orderby e descending
                select e;
            var sortedDistinct = sorted.Distinct();
            foreach (var element in sortedDistinct)
            {
                Console.Write(" {0}, ", element);
            }

            Console.ReadLine();
        }

    }
}
