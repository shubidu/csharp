using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

 
        private void loginControl1_Login(object sender, SampleForm.LoginEventArgs args)
        {
            MessageBox.Show(args.UserName + args.UserPwd);
        }
    }
}
