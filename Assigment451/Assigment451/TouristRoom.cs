using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment451
{
    public class TouristRoom : Room, ICapacity
    {
        //data member
        private int numOfBeds;

        //general purpose constructor
        public TouristRoom(int num, int days, int beds)
            : base(num, days)
        {
            NumOfBeds = beds;
        }
        //copy constructor
        public TouristRoom(TouristRoom t)
            : this(t.RoomNumber, t.DaysOccupied, t.NumOfBeds)
        { }

        //Properties
        public int NumOfBeds
        {
            get { return numOfBeds; }
            set { numOfBeds = value; }
        }

        //override abstract method from Room
        public override double CalculateBill()
        {
            double total = DaysOccupied * NumOfBeds * 50.00;
            return total;
        }

        public override string ToString()
        {
            return String.Format("Tourist {0}Beds: {1}, Bill: {2:C}", base.ToString(), NumOfBeds, CalculateBill());
        }
        
        //Implement from ICapacity
        public int Capacity
        {
            get { return NumOfBeds; }
        }

        public double Bill
        {
            get { return CalculateBill(); }
        }
    }
}
