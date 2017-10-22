namespace Lab4
{
    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private long A => Convert.ToInt64(this.numericUpDownA.Value);
        private long B => Convert.ToInt64(this.numericUpDownB.Value);
        private long M => Convert.ToInt64(this.numericUpDownM.Value);

        public Form1()
        {
            this.InitializeComponent();
            this.UpdateValues();
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateValues();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateValues();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateValues();
        }

        private void UpdateValues()
        {
            // a+b
            var res1 = (this.A + this.B) % this.M;
            this.textBox1.Text = res1.ToString();

            // a-b
            var res2 = (this.A + (this.M - this.B)) % this.M;
            this.textBox2.Text = res2.ToString();

            // a^b
            var res3 = Math.Pow(this.A, this.B) % this.M;
            this.textBox3.Text = res3.ToString();

            // a*b
            var res4 = (this.A * this.B) % this.M;
            this.textBox4.Text = res4.ToString();

            // -a
            var res5 = (this.M - this.A) % this.M;
            this.textBox5.Text = res5.ToString();

            // a==b
            this.textBox6.Text = this.EqualsByModule(this.A, this.B, this.M) ? "Так" : "Ні";

            // a - is simple
            var res7 = Math.Pow(this.B, this.A - 1);
            this.textBox7.Text = (res7 % this.A) == 1 ? "Так" : "Ні";

            // NOD
            decimal a = this.A;
            decimal b = this.B;
            decimal g = a / b;
            decimal r = ((decimal)a) % ((decimal)b);
            var sb = new StringBuilder();
            sb.Append("a\tb\tG\tR\r\n");
            sb.Append($"{System.Math.Round(a, 2)}\t{System.Math.Round(b, 2)}\t{System.Math.Round(g, 2)}\t{System.Math.Round(r, 2)}\r\n");

            while (g != 0)
            {
                a = b;
                b = r;
                g = b == 0 ? 0 : a / b;
                r = g == 0 ? 0 : ((decimal)a % (decimal)b);
                sb.Append($"{System.Math.Round(a, 2)}\t{System.Math.Round(b, 2)}\t{System.Math.Round(g, 2)}\t{System.Math.Round(r, 2)}\r\n");
            }

            this.textBox8.Text = sb.ToString();

            // Ejlera
            this.textBox9.Text = this.EjleraFunction(this.A).ToString();
        }

        private bool EqualsByModule(long a, long b, long m)
        {
            return (a % m) == (b % m);
        }

        private long EjleraFunction(long n)
        {
            long result = n;
            for (long i = 2; i * i <= n; ++i)
                if (n % i == 0)
                {
                    while (n % i == 0)
                        n /= i;
                    result -= result / i;
                }
            if (n > 1)
                result -= result / n;
            return result;
        }
    }
}