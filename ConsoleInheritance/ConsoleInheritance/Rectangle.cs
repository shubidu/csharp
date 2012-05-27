using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Rectangle:Point
    {
        private Point lowerLeft;

        public Rectangle(Point upper, Point lower)
            : base(upper)
        {
            lowerLeft = lower;
        }
        public Rectangle()
            : this(new Point(), new Point())
        {
         
        }

        public Rectangle(Rectangle rectangle)
            : this(rectangle.UpperLeft, rectangle.lowerLeft)
        {

        }


        public Point UpperLeft
        {
            get
            {
                return new Point(this.Coordinates);
            }
            set
            {
                if (lowerLeft != null)
                {
                    this.Coordinates = value.Coordinates;
                }
                else
                {
                    this.Coordinates = new int[2];
                }

            }
        }



        public Point LowerLeft
        {
            get
            {
                return new Point(lowerLeft);
            }
            set
            {
                if (lowerLeft != null)
                {
                    lowerLeft = new Point(value);
                }
                else
                {
                    lowerLeft = new Point();
                }

            }
        }

    }
}
