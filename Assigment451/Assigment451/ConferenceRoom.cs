using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment451
{
    public class ConferenceRoom : Room, ICapacity
    {
        //data member
        private int area;
        
        //general purpose constructor
        public ConferenceRoom(int num, int days, int roomArea)
            : base(num, days)
        {
            Area = roomArea;
        }
        //copy constructor
        public ConferenceRoom(ConferenceRoom c)
            : this(c.RoomNumber, c.DaysOccupied, c.Area)
        { }
        
        //Properties
        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public override double CalculateBill()
        {
            double total = DaysOccupied * Area * 500.00;
            return total;
        }

        public override string ToString()
        {
            return String.Format("Conference {0}Area: {1}, Bill: {2:C}", base.ToString(), Area, CalculateBill());
        }
        
        //implement from ICapacity
        public int Capacity
        {
            get { return Area; }
        }

        public double Bill
        {
            get { return CalculateBill(); }
        }
    }
}
