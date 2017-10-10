using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private int N => (int) this.numericUpDownN.Value;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.richTextBoxHow.Font = new Font(FontFamily.GenericMonospace, this.richTextBoxHow.Font.Size);
            this.Regenerate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Regenerate();
        }

        private void buttonGenerateP_Click(object sender, EventArgs e)
        {
            this.Regenerate();
        }

        private void Regenerate()
        {
            this.textBoxK.Text = Extensions.Factorial(this.N).ToString();
            var arr = new List<int>();

            while (true)
            {
                var item = random.Next(1, this.N + 1);
                if (!arr.Contains(item))
                {
                    arr.Add(item);
                }

                if (arr.Count == this.N)
                {
                    break;
                }
            }

            textBoxP2.Text = string.Join(" ", arr);
        }

        private IEnumerable<string> GetStrinArray()
        {
            return this.textBoxP2.Text.Split(' ');
        }

        private IEnumerable<int> GetIntArray()
        {
            var arr = this.GetStrinArray();
            var converted = new List<int>();

            foreach (var item in arr)
            {
                converted.Add(Convert.ToInt32(item));
            }

            return converted;
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            var p = this.GetIntArray();
            var pStr = string.Join("", this.GetStrinArray());
            var text = this.richTextBoxFrom.Text;
            var processSb = new StringBuilder();
            var encodedText = new StringBuilder();

            while (text.Length % this.N != 0)
            {
                text = text + " ";
            }

            for (int i = 0; i < text.Length / this.N; i++)
            {
                var subStr = text.Substring(this.N * i, this.N);
                processSb.Append(subStr).AppendNewLine();
                processSb.Append(pStr).AppendNewLine();

                var dic = new Dictionary<int, char>();

                for (int j = 0; j < N; j++)
                {
                    dic.Add(p.ElementAt(j), subStr[j]);
                }

                var encoded = string.Join("", dic.OrderBy(x => x.Key).Select(x => x.Value).ToArray());

                encodedText.Append(encoded);
                processSb.Append(encoded).AppendLine().AppendNewLine();
            }

            this.richTextBoxResult.Text = encodedText.ToString();
            this.richTextBoxHow.Text = processSb.ToString();

            //// Код дешифрування
            var decodeDic = new Dictionary<int, int>();
            for (int i = 0; i < this.N; i++)
            {
                decodeDic.Add(p.ElementAt(i), i +1);
            }

            var decodeCode = string.Join(" ", decodeDic.OrderBy(x => x.Key).Select(x => x.Value).ToArray());
            this.textBoxDecode.Text = decodeCode;
        }

        private IEnumerable<string> GetDecodeStrinArray()
        {
            return this.textBoxDecode.Text.Split(' ');
        }

        private IEnumerable<int> GetDecodeIntArray()
        {
            var arr = this.GetDecodeStrinArray();
            var converted = new List<int>();

            foreach (var item in arr)
            {
                converted.Add(Convert.ToInt32(item));
            }

            return converted;
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            var p = this.GetDecodeIntArray();
            var pStr = string.Join("", this.GetDecodeStrinArray());
            var text = this.richTextBoxFrom.Text;
            var processSb = new StringBuilder();
            var dcodedText = new StringBuilder();

            for (int i = 0; i < text.Length / this.N; i++)
            {
                var subStr = text.Substring(this.N * i, this.N);
                processSb.Append(subStr).AppendNewLine();
                processSb.Append(pStr).AppendNewLine();

                var dic = new Dictionary<int, char>();

                for (int j = 0; j < N; j++)
                {
                    dic.Add(p.ElementAt(j), subStr[j]);
                }

                var encoded = string.Join("", dic.OrderBy(x => x.Key).Select(x => x.Value).ToArray());

                dcodedText.Append(encoded);
                processSb.Append(encoded).AppendLine().AppendNewLine();
            }

            this.richTextBoxResult.Text = dcodedText.ToString();
            this.richTextBoxHow.Text = processSb.ToString();
        }
    }
}
