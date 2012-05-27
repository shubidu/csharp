using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Point
    {
        private int[] coordinates;

        public Point(int[] coordinates)
        {
            Coordinates = coordinates;

        }
        public Point()
            : this(new[] { 0, 0 })
        {

        }
        public Point(Point point):this(point.coordinates)
        {

        }
        public int[] Coordinates
        {
            get
            {
                //int[] temp = new int[coordinates.Length];
                //for (int i = 0; i < temp.Length; i++)
                //    temp[i] = coordinates[i];
                //return temp;
                return coordinates;
            }
             set
            {
                if (value != null && value.Length == 2)
                {
                    coordinates = new int[value.Length];
                    for (int i = 0; i < coordinates.Length; i++)
                        coordinates[i] = value[i];
                }
                else
                    coordinates = new int[] { 0, 0 };
            }
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", coordinates[0], coordinates[1]);
        }
    }
}
