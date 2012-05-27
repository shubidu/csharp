using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class LINQ
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 11, 14, 15, 18, 22, 29, 55, 72 };
            Student[] students = new Student[]
            {
                new Student("Ivan Petrov", 29, 1300),
                new Student("Petur Petrov", 22, 2200),
                new Student("Gerogi Zhelqzkov", 26, 1600),
                new Student("Matei Kaziiski", 23, 1800),
                new Student("Teodor Salparov", 23, 1500),
                new Student("Vladimir Nikolov", 24, 1400)
            };

            var addresses = new[]{ 
                new { CompanyName="Bike Shop", City="Sofia", Country = "Bulgaria"},
                new { CompanyName="Pnachev i Sie", City="Sofia", Country = "Bulgaria"},
                new { CompanyName="Brannes", City="Tel Aviv", Country = "Israel"},
                new { CompanyName="Harolds", City="London", Country = "UK"},
                new { CompanyName="London Mall", City="London", Country = "UK"},
                new { CompanyName="La Redoute", City="Paris", Country = "France"},
                new { CompanyName="Bolangerie", City="Nant", Country = "France"}};


            #region LINQ1
        //    IEnumerable<int> filter =
        //from g in array
        //where g <= 29
        //select g;

        //    var ordered =
        //        from z in filter
        //        orderby z descending
        //        select z;

        //    var orderedquery =
        //        from g in array
        //        where g <= 29 
        //        orderby g ascending
        //        select g;


        //    Displayresults(ordered);
        //    Console.WriteLine();
        //    Displayresults(orderedquery); 
            #endregion

            var GroupedByCities = addresses.GroupBy(grad => grad.City);
            foreach (var city in GroupedByCities)
            {
                Console.WriteLine("In {0} there is/are {1} ",city.Key, city.Count());
            }

            //var over23 =
            //    from el in students
            //    where el.Age > 22 
            //    orderby el.Age descending , el.Fee 
            //    select el.Age;
            //var anonimen =
            //    from el in students
            //    where el.Age > 23
            //    select new { el.Name, Tax = el.Fee };
            //Console.WriteLine(over23.Any());
            //Display(anonimen);
        }
        public static void Display<T>(IEnumerable<T> results)
        {
            foreach (T element in results)
                Console.WriteLine(element.ToString());
        }
        private static void Displayresults(IEnumerable<int> results)
        {
            foreach (int x in results)
                Console.WriteLine(x);
        }

    }
}
