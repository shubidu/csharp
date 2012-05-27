using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidTermTestF17992
{
    public class InvoiceDetail
    {
        private double dblLineTotal;

        public double DblLineTotal 
        { 
            get 
            {
                return dblLineTotal;
            }
            set
            {
                if (value >= 0)
                    dblLineTotal = value;
            }
        }

        //general purpose constructor
        public InvoiceDetail(double d)
        {
            DblLineTotal = d;
        }

        //default constructor
        public InvoiceDetail()
            : this(0)
        {
        }

        //copy constructor
        public InvoiceDetail(InvoiceDetail i)
            : this(i.DblLineTotal)
        {
        }

        public override string ToString()
        {
            return String.Format("DbLineTotal: {0}", DblLineTotal);
        }

    }
}
