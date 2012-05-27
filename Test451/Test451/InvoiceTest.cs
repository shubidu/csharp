using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test451
{
    public delegate void Print(Invoice[] invoices);
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            InvoiceDetail id1, id2;
            id1 = new InvoiceDetail(20D);
            id2 = new InvoiceDetail(40D);
            OutgoingInvoice in1 = new OutgoingInvoice(new InvoiceDetail[] {id1 });
            ReceivableInvoice in2 = new ReceivableInvoice(new InvoiceDetail[] { id2, id1 });
            Invoice[] arr = new Invoice[] { in1, in2 };
            Invoice in3 = Invoice.Add(arr);
            Invoice.Vat = 20;
            Invoice[] MyInvoices = new Invoice[] { in1, in3, in2 };
            Print action = InvoiceTest.PrintSortedInvoices;
            action(MyInvoices);
            action = InvoiceTest.PrintGroupedInvoices;
            action(MyInvoices);
            Console.ReadLine();
           

            
        }

        
        public static void PrintGroupedInvoices(Invoice[] inv)
        {
            var grouped = inv.GroupBy(type => type.GetType().Name);
            Console.WriteLine(">>>>>>>>>>>>>>> GROUPED INVOICES <<<<<<<<<<<<<<<<<");
            foreach (var item in grouped)
            {
                Console.WriteLine("Key : {0}\n", item.Key);
                    foreach( var x in item)
                        Console.WriteLine(x);
                //if (item.Key.Equals("ReceivableInvoice"))
                //{
                //    Console.WriteLine("Group Receivable Invoice");
                //    foreach (var x in item)
                //    {
                //        Console.WriteLine(x);
                //        continue;
                //    }
                   
                    
                //}
                //Console.WriteLine("Group Outgoing Invoices");
                //foreach (var z in item)
                //{
                //    Console.WriteLine(z);
                //}
               
            }
        }

        public static void PrintSortedInvoices(Invoice[] inv)
        {
            var sorted =
                from value in inv
                orderby value.InvoiceNumber
                select value;
            Console.WriteLine(">>>>>>>>>>>>>>>>>> SORTED INVOICES <<<<<<<<<<<<<<<<");
            foreach (var x in sorted)
                Console.WriteLine(x);

        }

    }
}
