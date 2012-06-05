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
        private void newMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard newMDIChild = new DrawingBoard();
            //Set the parent Form of the Child window
            newMDIChild.MdiParent = this;
            //Display the new form
            newMDIChild.Show();
        }

        //'Close' menu
        private void closeMenu_Click(object sender, EventArgs e)
        {   
            //check is there an active child form and close it
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }



        //'Color' menu 
        private void colorMenu_Click(object sender, EventArgs e)
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
        private void verticalArrangeMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //'Horizontal' menu 
        private void horizontalArrangeMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //'Cascade' menu 
        private void cascadeArrangeMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }


        //'Exit' menu 
        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {

        }
        //'PenSize' menu
        private void penSizeMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.diameter = Convert.ToInt32(((ToolStripMenuItem)sender).Text);
        }

    }
}
