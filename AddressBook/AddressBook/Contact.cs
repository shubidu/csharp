using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    public class Contact
    {
        public String Name { get; set; }
        public String Telephone { get; set; }
        public String Email { get; set; }

        public Contact(String n, String t, String e)
        {
            Name = n;
            Telephone = t;
            Email = e;
        }
    }
}
