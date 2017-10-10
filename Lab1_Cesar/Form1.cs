using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            int key;
            var isInt = int.TryParse(textBox1.Text, out key);

            string encrypted = isInt && !isStringCtrl.Checked
                ? CasarEncryptor.Encrypt(this.richTextBox1.Text, key)
                : CasarEncryptor.Encrypt(this.richTextBox1.Text, this.textBox1.Text);

            this.richTextBox2.Text = encrypted;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            int key;
            var isInt = int.TryParse(textBox1.Text, out key);

            string decrypted = isInt && !isStringCtrl.Checked
                ? CasarEncryptor.Decrypt(this.richTextBox1.Text, key)
                : CasarEncryptor.Decrypt(this.richTextBox1.Text, this.textBox1.Text);
            
            this.richTextBox2.Text = decrypted;
        }
    }
}
