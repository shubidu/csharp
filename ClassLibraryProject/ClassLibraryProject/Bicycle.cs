using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryProject
{
    public class Bicycle
    {
        private int gears;
        private string brand;

        public Bicycle(int numberOfGears, string bicycleBrand)
        {
            Gears = numberOfGears;
            Brand = bicycleBrand;
        }

        public Bicycle()
            : this(0, "default")
        { }

        public Bicycle(Bicycle b)
            : this(b.Gears, b.Brand)
        { }


        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        
        public int Gears
        {
            get { return gears; }
            set { gears = value; }
        }

        public void MaxSpeed()
        {
            Console.WriteLine("Maximum Speed is {0} km/h ", gears * 5);
        }

    }
}
