using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleTest461
{
    public partial class FrmEncDecrypt : Form
    {
        public FrmEncDecrypt()
        {
            
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            TransCipher one = new TransCipher(txtKey.Text);
            txtCipherText.Text = ((IEncryptable)one).GetMyEncode(txtPlainText.Text);
            //txtKey.Clear();

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            TransCipher one = new TransCipher(txtKey.Text);
            txtPlainText.Text = ((IEncryptable)one).GetMyDecode(txtCipherText.Text);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCipherText.Clear();
            txtKey.Clear();
            txtPlainText.Clear();
        }
    }
}
