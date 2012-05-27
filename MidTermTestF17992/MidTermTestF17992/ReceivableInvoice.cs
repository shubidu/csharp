using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidTermTestF17992
{
    public class ReceivableInvoice : Invoice
    {
        //general purpose constructor
        public ReceivableInvoice(InvoiceDetail[] items)
            : base(items)
        {
        }
        //default constructor
        public ReceivableInvoice()
            : this(new InvoiceDetail[]{new InvoiceDetail()})
        {
        }
    }
}
