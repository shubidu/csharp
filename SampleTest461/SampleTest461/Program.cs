using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleTest461
{
    class Program
    {
        static void Main(string[] args)
        {
            //TransCipher cipher = new TransCipher("BEAUTY");
            //string str = cipher.Encrypt("THISISTHEPLAIN");
            ////Console.WriteLine(((IEncryptable) cipher).GetMyEncode("THISISTHEPLAIN"));
            //str = cipher.Decrypt("TTIHHNIE SP IL SA ");
            //Console.WriteLine(str);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEncDecrypt());
            
        }
    }
}
