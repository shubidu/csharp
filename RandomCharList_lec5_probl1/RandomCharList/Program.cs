using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomCharList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List <char> chars = new List<char>();
            for (int alpha = 0; alpha < 30; alpha++)
            {
                char randChar = (char) ('A' + rand.Next(26));
                chars.Add(randChar);                
            }

            var sortedDesc =
                from mychar in chars
                orderby mychar descending
                select mychar;
            
            var sortedAsc =
                from mychar in chars
                orderby mychar ascending
                select mychar;

            Display(sortedDesc);
            Console.WriteLine();
            Display(sortedAsc);
            Console.ReadLine();
        }

        public static void Display<T>(IEnumerable<T> results)
        {
            foreach (T element in results) Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
