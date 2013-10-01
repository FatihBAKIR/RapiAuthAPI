using RapiAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RapiAuth_API
{
    public partial class Form1 : Form
    {
        Authenticator auth = new Authenticator("c4ca4238a0b923820dcc509a6f75849b");
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auth.KontrolEt(token.Text, kod.Text) ? "Doğru" : "Yanlış");
        }

        private void token_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) button1_Click(button1, null);
        }
    }
}
