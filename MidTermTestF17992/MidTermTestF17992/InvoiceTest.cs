using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidTermTestF17992
{
    public delegate void Print(Invoice[] i);

    public class InvoiceTest
    {
        public static void PrintGroupedInvoices(Invoice[] invs)
        {
            Console.WriteLine(">>>>>>>>>>>> Print grouped invoices >");
            //todo get the class property..
            var grouppedInv = invs.GroupBy(type => type);

        }

        public static void PrintSortedInvoices(Invoice[] invs)
        {
            var sorted = invs.OrderBy(number => number.InvoiceNumber).Select(inv => inv);

            Console.WriteLine(">>>>>>>>>>>> Print sorted invoices >");

            foreach (var inv in sorted)
            {
                Console.WriteLine(inv.ToString());
            }

            
        }

        //Print myPrintDelegate = PrintGroupedInvoices + PrintSortedInvoices;
    }
}
