using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidTermTestF17992
{
    public class OutgoingInvoice : Invoice
    {
        //general purpose constructor
        public OutgoingInvoice(InvoiceDetail[] items)
            : base(items)
        {
        }

        //default constructor
        public OutgoingInvoice()
            : this(new InvoiceDetail[]{new InvoiceDetail()})
        {
        }
    }
}
