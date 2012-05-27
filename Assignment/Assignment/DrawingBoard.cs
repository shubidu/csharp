using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Assignment
{
    public partial class DrawingBoard : Form
    {
        bool paintNow = false;
        public static int penWidth = 2;
        public static int penHeight = 2;
        
        public static Color userColor = Color.Black;
        

        public DrawingBoard()
        {
            InitializeComponent();
        }


        private void DrawingBoard_Load(object sender, EventArgs e)
        {
            //setting the default background color to white
            this.BackColor = Color.White;
          
        }
        

        //should paint when mouse button is pressed
        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            paintNow = true;
        }

        //shoud stop painting when mouse button is released
        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            paintNow = false;
        }

        //draw circles whenever mouse is being dragged
        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (paintNow)
            {
                
                Graphics g = pnlDraw.CreateGraphics();
                g.FillEllipse(new SolidBrush(userColor), e.X, e.Y, penWidth, penHeight);
                g.Dispose();
            }
        }

    }
}
