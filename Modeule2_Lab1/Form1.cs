using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeule2_Lab1
{
    using System.Text.RegularExpressions;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var arr = new List<int>();
            arr.Add(Convert.ToInt32(dataGridView.Rows[0].Cells[0].Value));
            arr.Add(Convert.ToInt32(dataGridView.Rows[0].Cells[1].Value));
            arr.Add(Convert.ToInt32(dataGridView.Rows[0].Cells[2].Value));
            arr.Add(Convert.ToInt32(dataGridView.Rows[0].Cells[3].Value));

            var stringBuilder = new StringBuilder();
            //sb.Append("Результат:\r\n");
            //sb.Append("a1|a2|a3|a4|k1|k2|a3\r\n");

            var k1 = (arr[1] + arr[2] + arr[3]) % 2;
            var k2 = (arr[0] + arr[2] + arr[3]) % 2;
            var k3 = (arr[0] + arr[1] + arr[3]) % 2;
            stringBuilder.Append(string.Join("", arr));
            stringBuilder.Append(k1);
            stringBuilder.Append(k2);
            stringBuilder.Append(k3);
            var res = stringBuilder.ToString();

            for (int i = 0; i < res.Length; i++)
            {
                this.dataGridViewResult1.Rows[0].Cells[i].Value = res[i];
            }
            
            this.textBoxResult1.Text = stringBuilder.ToString();

            ////
            var sb = new StringBuilder();
            sb.Append("k1 = a2 + a3 + a4 (MOD 2)\r\n");
            sb.Append("k2 = a1 + a3 + a4 (MOD 2)\r\n");
            sb.Append("k3 = a1 + a2 + a4 (MOD 2)\r\n");

            sb.Append($"k1 = {arr[1]} + {arr[2]} + {arr[3]} = " + k1 + "\r\n");
            sb.Append($"k2 = {arr[0]} + {arr[2]} + {arr[3]} = " + k2 + "\r\n");
            sb.Append($"k3 = {arr[0]} + {arr[1]} + {arr[3]} = " + k3 + "\r\n");

            this.richTextBoxResult1.Text = sb.ToString();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            var arr = new List<int>();
            arr.Add(Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value));
            arr.Add(Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value));
            arr.Add(Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value));
            arr.Add(Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value));
            arr.Add(Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value));
            arr.Add(Convert.ToInt32(dataGridView2.Rows[0].Cells[5].Value));
            arr.Add(Convert.ToInt32(dataGridView2.Rows[0].Cells[6].Value));

            var sb = new StringBuilder();
            sb.Append("S1 = a4 + a5 + a6 + a7 (MOD 2)\r\n");
            sb.Append("S2 = a2 + a3 + a6 + a7 (MOD 2)\r\n");
            sb.Append("S3 = a1 + a3 + a5 + a7 (MOD 2)\r\n");

            var s1 = GetNum(arr, 4, 5, 6, 7);
            var s2 = GetNum(arr, 2, 3, 6, 7);
            var s3 = GetNum(arr, 1, 3, 5, 7);

            sb.Append($"S1 = {arr[3]} + {arr[4]} + {arr[5]} + {arr[6]} = " + s1 + "\r\n");
            sb.Append($"S2 = {arr[1]} + {arr[2]} + {arr[5]} + {arr[6]} = " + s2 + "\r\n");
            sb.Append($"S3 = {arr[0]} + {arr[2]} + {arr[4]} + {arr[6]} = " + s3 + "\r\n");

            var s = ConvertToInt($"{s1}{s2}{s3}");
            sb.Append($"S3 = {s1}{s2}{s3} = {s}\r\n");
            sb.Append(s == 0 ? "Пакет цілісний!" : "В пакеті помилка. Елемент: а" + s);

            richTextBoxResult2.Text = sb.ToString();
        }

        private int GetNum(IList<int> arr, params int[] p)
        {
            var res = 0;
            foreach (var item in p)
            {
                res += arr[item - 1];
            }

            return res % 2;
        }

        static readonly Regex binary = new Regex("^[01]{1,32}$", RegexOptions.Compiled);
        private int ConvertToInt(string s)
        {
            if (binary.IsMatch(s))
            {
                return Convert.ToInt32(s, 2);
            }
            else
            {
                throw  new ArgumentException();
            }
        }
    }
}
