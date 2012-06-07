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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        //'New' menu 
        private void mnuNew_Click(object sender, EventArgs e)
        {
            DrawingBoard newMDIChild = new DrawingBoard();
            //Set the parent Form of the Child window
            newMDIChild.MdiParent = this;
            //Display the new form
            newMDIChild.Show();
        }

        //'Close' menu
        private void mnuClose_Click(object sender, EventArgs e)
        {   
            //check is there an active child form and close it
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }



        //'Color' menu 
        private void mnuColor_Click(object sender, EventArgs e)
        {
           //creating a Color Dialog at run-time
            ColorDialog colorDlg = new ColorDialog();                   

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                //assigning the color of the drawing board to the color the user picks
                DrawingBoard.userColor = colorDlg.Color;
            }
        }


        //'Vertical' menu 
        private void mnuVerLayout_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //'Horizontal' menu 
        private void mnuHorLayout_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //'Cascade' menu 
        private void mnuCasLayout_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }


        //'Exit' menu 
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //'PenSize' menu
        private void mnuPenSize_Click(object sender, EventArgs e)
        {
            DrawingBoard.diameter = Convert.ToInt32(((ToolStripMenuItem)sender).Text);
        }

    }
}
