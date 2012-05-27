using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test451
{
    public class ReceivableInvoice : Invoice
    {
        public ReceivableInvoice(InvoiceDetail[] items)
            : base(items)
        { }
        
        public ReceivableInvoice()
            : this(new InvoiceDetail[] { new InvoiceDetail() })
        { }
    }
}
