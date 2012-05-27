using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class Lab2
    {

        static void Main()
        {

            String input = Console.ReadLine();
            //var linq =
            //    from element in input.Split()
            //    let word = element.ToLower()
            //    orderby word
            //    select word;

            var linq =
               from element in input.Split()
               orderby element
               select element.ToLower();

            foreach (var word in linq.Distinct())
                Console.Write("{0} ", word);
        }
    }
}
