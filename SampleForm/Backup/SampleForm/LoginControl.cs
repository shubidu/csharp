using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleForm
{
    public partial class LoginControl : UserControl
    {
        public event LoginHandler Login; // custom event

        public LoginControl()
        {
            InitializeComponent();
        }

        public string UserName { get;  set; }



        private void btnOK_Click(object sender, EventArgs e) // OnLogin execution
        {
           if (Login != null)
                Login(this, new LoginEventArgs(txtUserName.Text, txtPassword.Text));
        }
    }
}
