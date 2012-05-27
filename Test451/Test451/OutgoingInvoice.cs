using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test451
{
    public class OutgoingInvoice : Invoice
    { 
        public OutgoingInvoice(InvoiceDetail[] items)
            : base(items)
        { }
        
        public OutgoingInvoice()
            : this(new InvoiceDetail[] { new InvoiceDetail() })
        { }

    }
}
