using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleForm
{
    public class LoginEventArgs :EventArgs

    {
        public string UserName { get; private set; }
        public string UserPwd { get; private set; }

        public LoginEventArgs(string u, string p)
        {
            UserName = u;
            UserPwd = p;
        }
    }

    public delegate void LoginHandler(object sender, LoginEventArgs args);

}
