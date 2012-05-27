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

        //set the size of the pen to size 1
        private void penSizeOneMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 2;
            DrawingBoard.penHeight = 2;
        }
        //set the size of the pen to size 2
        private void penSizeTwoMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 3;
            DrawingBoard.penHeight = 3;
        }
        //set the size of the pen to size 3
        private void penSizeThreeMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 4;
            DrawingBoard.penHeight = 4; ;
        }
        //set the size of the pen to size 4
        private void penSizeFourMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 5;
            DrawingBoard.penHeight = 5;
        }
        //set the size of the pen to size 5
        private void penSizeFiveMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 6;
            DrawingBoard.penHeight = 6;
        }
        //set the size of the pen to size 6
        private void penSizeSixMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 7;
            DrawingBoard.penHeight = 7;
        }
        //set the size of the pen to size 7
        private void penSizeSevenMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 8;
            DrawingBoard.penHeight = 8;
        }
        //set the size of the pen to size 8
        private void penSizeEightMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 9;
            DrawingBoard.penHeight = 9;
        }
        //set the size of the pen to size 9
        private void penSizeNineMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 10;
            DrawingBoard.penHeight = 10;
        }
        //set the size of the pen to size 10
        private void penSizeTenMenu_Click(object sender, EventArgs e)
        {
            DrawingBoard.penWidth = 11;
            DrawingBoard.penHeight = 11;
        }
        
       
      

      
       
    }
}
