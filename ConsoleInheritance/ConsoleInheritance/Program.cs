using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coors = new int[2]{10,44};
            Point p = new Point(coors);
            Console.WriteLine(p);

            Point p1 = new Point(p.Coordinates);
            Console.WriteLine(p1);
            coors = p.Coordinates;
            coors[0] = 99;

            p1.Coordinates[0] = 77;
            Console.WriteLine(p);


        }
    }
}
