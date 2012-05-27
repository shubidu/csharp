using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test451
{
    public class InvoiceDetail
    {
        private double dblLineTotal;

        public InvoiceDetail(double dbl)
        {
            DblLineTotal = dbl;
        }
        
        public InvoiceDetail()
            : this(0)
        { }

        public InvoiceDetail(InvoiceDetail inv)
            : this(inv.DblLineTotal)
        { }

        public double DblLineTotal
        {
            get { return dblLineTotal; }
            private set
            {
                if (value >= 0)
                    dblLineTotal = value;
                else
                    dblLineTotal = 0;
            }
        }


        public override string ToString()
        {
            return String.Format("Total: ${0}", DblLineTotal);
        }
    }
}
