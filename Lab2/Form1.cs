using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly Encrypt encrypt = new Encrypt();

        public Form1()
        {
            InitializeComponent();
        }

        private int A => (int) this.aCtrl.Value;
        private int B => (int)this.bCtrl.Value;
        private int M => (int)this.mCtrl.Value;
        private int Xz => (int)this.xCtrl.Value;

        private void generateBtn_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            var m = rand.Next(100) + 100;
            var a = rand.Next(10) * 4 + 1;
            var b = rand.Next(100);
            if (b % 2 == 0)
                b++;

            var xz = rand.Next(100);

            this.aCtrl.Value = a;
            this.bCtrl.Value = b;
            this.mCtrl.Value = m;
            this.xCtrl.Value = xz;

            this.Validate();
        }

        private void Validate()
        {
            if (this.A > 0 && this.A % 4 != 1) MessageBox.Show("Validation error: a mod 4 = 4");
            if (this.A < 0) MessageBox.Show("Validation error: a >= 0");
            if (this.A >= this.M) MessageBox.Show("Validation error: a < m");

            if (this.B < 0) MessageBox.Show("Validation error: b >=0");
            if (this.B > this.M) MessageBox.Show("Validation error: b < m");
            if (this.B % 2 == 0) MessageBox.Show("Validation error: b % 2 == 1");
            if (Extension.FindGreatestCommonDivision(this.B, this.M) != 1) MessageBox.Show("Validation error: b < m");

            if (this.Xz < 0) MessageBox.Show("Validation error: x >= 0");
            if (this.Xz >= this.M) MessageBox.Show("Validation error: x < m");

            if (this.M < 2) MessageBox.Show("Validation error: m >= 2");
        }

        private void cryptBtn_Click(object sender, EventArgs e)
        {
            this.Validate();

            var sb = new StringBuilder();
            var cryptKey = new List<int>();
            var text = this.richTextBox1.Text;
            var encrypted = encrypt.EncrypteByLineralMethod(this.richTextBox1.Text, A, B, Xz, M, ref cryptKey);

            sb.Append($"G: ");
            foreach (var k in cryptKey)
            {
                sb.Append($"{k},");
            }
            sb.Append("\r\n");

            for (int i = 0; i < text.Length; i++)
            {
                sb.Append($"{text[i]}\t{cryptKey[(i % cryptKey.Count)]}\t{encrypt.GetIndex(encrypted[i])}\t{encrypted[i]}\r\n");
            }
            sb.Append("\r\nРезультат:" + encrypted);

            this.rezultBox.Text = sb.ToString();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            this.Validate();

            var decrypted = encrypt.DecryptByLineralMethod(this.richTextBox1.Text, A, B, Xz, M);
            this.rezultBox.Text = decrypted;
        }
    }
}
