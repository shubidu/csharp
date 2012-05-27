using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var unique =
                from e in input.Split().Distinct()
                let lowercase = e.ToLower()
                orderby lowercase
                select lowercase;

            //var sortedDistinct = unique.Distinct();
            foreach (var element in unique)
            {
                Console.Write(" {0} ", element);
            }

            Console.ReadLine();

        }
    }
}
