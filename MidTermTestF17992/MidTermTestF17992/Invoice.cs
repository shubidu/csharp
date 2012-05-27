using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidTermTestF17992 
{

    public class Invoice : ITaxable
    {
        private readonly long invoiceNumber;
        private static long sequence_id = 0;
        public static double vat = 20;

        private InvoiceDetail[] invoiceItems;

        public long InvoiceNumber { get; set; }
        
        public InvoiceDetail[] InvoiceItems
        {
            get
            {
                return invoiceItems;
            }
            set
            {
                if (value != null)
                    invoiceItems = value;
            }
        }

	    public double Vat
	    {
		    get { return Vat;}
		    set 
            {
                if (Vat >= 0)
                    Vat = value;
                else
                    Vat = 0;
            }
    	}
	 
        //general purpose constructor
        public Invoice(InvoiceDetail[] items)
        {
            InvoiceNumber = sequence_id++;
            InvoiceItems = items;
        }

        //default constructor
        public Invoice()
            : this(new InvoiceDetail[]{ new InvoiceDetail() })
        {
        }

        //copy constructor
        public Invoice(Invoice inv)
            : this(inv.InvoiceItems)
        {
        }

        public double InvoiceTotal(InvoiceDetail[] items)
        {
            double total = 0;

            foreach (var i in items)
            {
                total += i.DblLineTotal;
            }

            return total;
        }

        public override string ToString()
        {

            StringBuilder myString = new StringBuilder();
            myString.AppendFormat("Invoice No. {0:D4}\n", InvoiceNumber);

            for (int i = 0; i < InvoiceItems.Length; i++)
            {
                myString.AppendFormat("Item {0}. {1}", i + 1, InvoiceItems[i].DblLineTotal);
            }

            return myString.ToString();
        }

        public decimal Tax
        {
            get 
            {

                double myTotal;
                myTotal = InvoiceTotal(InvoiceItems) * (Vat / 100);

                return (decimal)myTotal;
            
            }
        }

        public static Invoice Add(Invoice[] invoices)
        {
            double total = 0;

            foreach (var details in invoices)
            {
                for(int i = 0; i < details.InvoiceItems.Length; i++)
                {
                    if (details is ReceivableInvoice)
                        total += details.InvoiceItems[i].DblLineTotal;
                    else if (details is OutgoingInvoice)
                        total -= details.InvoiceItems[i].DblLineTotal;
                }
            }

            return new Invoice(new InvoiceDetail[] { new InvoiceDetail(total) });
        }
    }
}
