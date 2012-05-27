using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generics
{
    public partial class Form1 : Form
    {
        private enum Types { INTS, DOUBLES, NO_TYPE };
        private  Types type = Types.NO_TYPE;
        int[] arrInt;
        double[] arrDbl;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblKey_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateInt_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
            int[] arr = Utility.CreateArray();
            StringBuilder strbld = new StringBuilder(100);
            strbld.AppendFormat("{0,-12}{1,-12}\n","Index", "Value");
            for (int i = 0; i < arr.Length; ++i)
                strbld.AppendFormat("{0,-12}{1,-12}\n", i, arr[i]);
            rtbText.Text = strbld.ToString();
            arrInt = arr;
            type = Types.INTS;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch(type){
                case Types.INTS:
                int x = Utility.Search(arrInt,Convert.ToInt32(txtKey.Text));
                lblResult.Text = String.Format("{0}", ((x != -1) ?  x.ToString() : "Key not found"));
                break;
                case Types.DOUBLES:

                    break;
            }



        }

        private void btnCreateDbl_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
            double[] arr = Utility.CreateArrayDbl();
            StringBuilder strbld = new StringBuilder(100);
            strbld.AppendFormat("{0,-11}{1,12}\n", "Index", "Value");
            for (int i = 0; i < arr.Length; ++i)
                strbld.AppendFormat("{0,-12}{1,}\n", i, arr[i]);
            rtbText.Text = strbld.ToString();
            arrDbl = arr;
            type = Types.DOUBLES;

        }
    }
}
