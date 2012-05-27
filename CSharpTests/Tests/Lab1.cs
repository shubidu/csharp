using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class Lab1
    {
        static void Main()
        {
            List<char> chars = new List<char>(30);
            Random rnd = new Random();

            for (int i = 0; i < 30; ++i)
            {
                chars.Add((char) ('a' + rnd.Next(26)));
            }

            var sorted =
                from el in chars
                orderby el
                select el;
            //chars.Sort();
            foreach (var character in chars)
                Console.Write("{0} ", character);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            foreach (var element in sorted)
            {
                Console.Write("{0} ", element);
            }

            Console.WriteLine();
            Console.WriteLine();
            
        }
    }
}
