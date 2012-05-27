using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test451
{
    public class Invoice : ITaxable
    {
        #region Fields
        private static long unique_ID = 0;
        private static double vat;
        public readonly long invoiceNumber;
        private InvoiceDetail[] invoiceItems; 
        #endregion

        #region Constructors
        public Invoice(InvoiceDetail[] items)
        {
            invoiceItems = items;
            invoiceNumber = unique_ID++;
        }

        public Invoice()
            : this(new InvoiceDetail[] { new InvoiceDetail() })
        {

        }
        public Invoice(Invoice inv)
            : this(inv.InvoiceItems)
        {
        } 
        #endregion

        #region Functions
        public static Invoice Add(Invoice[] invoice)
        {
            Invoice inv;
            double sum = 0.0;
            foreach (var item in invoice)
                if (item is ReceivableInvoice)
                {
                    sum += item.InvoiceTotal();
                }
                else
                {
                    sum -= item.InvoiceTotal();
                }

            InvoiceDetail[] details = new InvoiceDetail[] { new InvoiceDetail(sum) };
            inv = new Invoice(details);
            return inv;

        }

        public double InvoiceTotal()
        {
            double total = 0D;
            foreach (var x in invoiceItems)
            {
                total += x.DblLineTotal;
            }

            return total;
        } 
        #endregion

        #region Properties
        public InvoiceDetail[] InvoiceItems
        {
            get
            {
                InvoiceDetail[] temp = new InvoiceDetail[invoiceItems.Length];
                for (int i = 0; i < invoiceItems.Length; ++i)
                {
                    temp[i] = invoiceItems[i];
                }
                return temp;
            }
        }

        public long InvoiceNumber
        {
            get { return invoiceNumber; }
        }

        public static double Vat
        {
            get { return vat; }
            set
            {
                if (value > 0)
                    vat = value / 100.0;
                else
                    vat = 0.0;
            }
        }

        public decimal Tax
        {
            get { return (decimal)InvoiceTotal() * Tax; }
        }
        #endregion

        public override string ToString()
        {
            int index = 0;
            StringBuilder str = new StringBuilder();
            foreach (var x in InvoiceItems)
                str.AppendFormat("Item {0}: {1}\n", index++, x.DblLineTotal);
            return String.Format("Invoice No: {0}\n{1}", InvoiceNumber, str);
        }
      
    }

}
