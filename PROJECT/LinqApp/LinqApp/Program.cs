using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Invoice[] arr = {
                               new Invoice(1, "Electric sander" , 1, 1m),
                               new Invoice(2, "Power waw" , 23, 2m),
                               new Invoice(3, "Hammer" , 22, 3m),
                               new Invoice(4, "Lawn mower" , 24, 4m),
                               new Invoice(5, "ScrewDriver" , 42, 5m),
                               new Invoice(6, "Jig saw" , 27, 6m),
                               new Invoice(7, "Wrech" , 21, 8m),
                               new Invoice(8, "Tesla" , 28, 7m),
                           };

            var sortedInvoice = arr.OrderBy(part => part.PartDescription).Select(product => product.PartDescription);
            var sortedPrice = arr.OrderBy(part => part.Price).Select(product => product.Price);

            foreach( var e in sortedInvoice )
            {
                Console.WriteLine(e);
            }

            var sortedQuantity = arr.OrderBy(quant => quant.Quantity).Select(product => product.Quantity + " " + product.PartDescription);

            foreach (var e in sortedQuantity)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            var priceGroups = arr.GroupBy(inv => GroupName(inv.Price));

            foreach (var group in priceGroups)
            {
                Console.WriteLine(group.Key);

                foreach (var element in group)
                {
                    Console.WriteLine("Price: {0}, Descriptuion: {1}", element.Price, element.PartDescription);
                }
            }

        }

        public static string GroupName(decimal price)
        {
            return price > 5 ? "Price above fifty" : "Price equal or below fifty";
        }

    }
}
