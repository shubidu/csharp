using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Assignment461
{
    public partial class DrawingBoard : Form
    {
        bool paintNow = false;
        public static int diameter = 2;
        Point position = new Point();
        
        public static Color userColor = Color.Black;
        

        public DrawingBoard()
        {
            InitializeComponent();
        }


        private void DrawingBoard_Load(object sender, EventArgs e)
        {
            //setting the default background color to white
            pnlDraw.BackColor = Color.White;
          
        }
        


        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (paintNow && (e.Location != position))
            {
                
                Graphics g = pnlDraw.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                Pen p = new Pen(userColor, diameter);
                p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(p, position, e.Location);
                position = e.Location;
                g.Dispose();

            }
            
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            paintNow = true;
            position = e.Location;
        }

        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            paintNow = false;
        }

    }
}
