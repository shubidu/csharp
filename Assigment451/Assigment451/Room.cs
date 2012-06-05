using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment451
{
    public abstract class Room
    {
        //data members
        private int roomNumber;
        private int daysOccupied;

        //general purpose constructor
        public Room(int number, int days)
        {
            RoomNumber = number;
            DaysOccupied = days;
        }
        //copy constructor
        public Room(Room r)
            : this(r.RoomNumber, r.DaysOccupied)
        {

        }


        //public properties
        public int RoomNumber
        {
            get { return roomNumber; }
            set
            {
                if (value > 0)
                    roomNumber = value;
                else
                    roomNumber = 0;
            }
        }

        public int DaysOccupied
        {
            get { return daysOccupied; }
            set
            {
                if (value > 0)
                    daysOccupied = value;
                else
                    daysOccupied = 0;
            }
        }

        public abstract double CalculateBill();

        public override string ToString()
        {
            return String.Format("Room Number: {0}, Days Occupied:{1}, ", RoomNumber, DaysOccupied);
        }

    }
}
