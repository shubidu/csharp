using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assigment451
{
    public partial class Form1 : Form
    {
        ICapacity[] rooms = new ICapacity[50];
        int index = 0;
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCreateTourist_Click(object sender, EventArgs e)
        {
            if (index <= rooms.Length)
            {
                rooms[index++] = new TouristRoom(rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 4));

            }
        }

        private void btnCreateConference_Click(object sender, EventArgs e)
        {
            if (index <= rooms.Length)
            {
                rooms[index++] = new ConferenceRoom(rnd.Next(1, 101), rnd.Next(1, 11), rnd.Next(50, 101));
            }
        }

        private void btnBillRooms_Click(object sender, EventArgs e)
        {
            double total = 0;
            lbxView.Items.Clear();
            foreach (ICapacity item in rooms)
            {
                if (item != null)
                {
                    lbxView.Items.Add(item);
                    total += item.Bill;
                }
            }
            lbxView.Items.Add(String.Format("TOTAL: {0:C}", total));
        }

        private void btnCapacityRooms_Click(object sender, EventArgs e)
        {
            lbxView.Items.Clear();
            foreach (ICapacity item in rooms)
            {
                if (item != null)
                {
                    if (item is TouristRoom)
                    { 
                        lbxView.Items.Add(String.Format("Tourist Room, Number: {1}, Capacity: {0}", item.Capacity,(item as Room).RoomNumber)); 
                    }
                    else if (item is ConferenceRoom)
                    {
                        lbxView.Items.Add(String.Format("Conference Room, Number: {1}, Capacity: {0}", item.Capacity, (item as Room).RoomNumber)); 
                    }
                }
            }
        }
    }
}
