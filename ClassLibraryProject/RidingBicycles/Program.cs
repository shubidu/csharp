using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryProject;

namespace RidingBicycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle b = new Bicycle(15, "Renault");
            b.MaxSpeed();
        }
    }
}
