using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private readonly string Dictionary = @"абвгґдеєжзиіїйклмнопрстуфхцчшщьюяАБВГҐДЕЄЖЗИІЇКЛМОПРСТУФЧЦШЩЬЮЯ 123456789";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            var text = this.richTextBox.Text;
            var dic = this.Dictionary.Clone().ToString();
            var set = new Dictionary<char, long>();

            // Fill dictionary
            foreach (var c in text)
            {
                if (!dic.Contains(c))
                {
                    dic += c;
                }
            }

            // Create set
            foreach (var c in dic)
            {
                set.Add(c, 0);
            }

            // Find count
            foreach (var c in text)
            {
                set[c] += 1;
            }

            // Fill dataset and chart
            decimal n = set.Sum(x => x.Value);
            this.dataGridView.Rows.Clear();
            this.chart1.Series.Clear();

            //chart1.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            //chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            
            foreach (var item in dic)
            {
                var val = set[item];
                var pi = GetPi(item, set, n);
                // grid
                DataGridViewRow row = (DataGridViewRow)this.dataGridView.Rows[0].Clone();
                row.Cells[0].Value = item;
                row.Cells[1].Value = val;
                row.Cells[2].Value = pi;
                this.dataGridView.Rows.Add(row);

                // chart
                var series = this.chart1.Series.Add(item.ToString());
                series.Points.AddY(pi);
                series.ToolTip = item.ToString();
                //series.Points[0].AxisLabel = item.ToString();
            }

            this.chart1.Refresh();
            this.dataGridView.Refresh();

            // Min
            if (set.Count(x => x.Value == 0) > 3)
            {
                var strMin = string.Join(", ", set.Where(x => x.Value == 0).Select(x => $"{x.Key}({x.Value})"));
                this.richTextBoxResult.Text = "Min: " + strMin + "\r\n";
            }
            else
            {
                var strMin = string.Join(", ", set.OrderBy(x => x.Value).Take(3).Select(x => $"{x.Key}({x.Value})"));
                this.richTextBoxResult.Text = "Min: " + strMin + "\r\n";
            }

            // Max
            var strMax = string.Join(", ", set.OrderByDescending(x => x.Value).Take(3).Select(x => $"\"{x.Key}\"({x.Value})"));
            this.richTextBoxResult.Text += "Max: " + strMax + "\r\n";
        }

        private string GetPi(char item, Dictionary<char, long> dic, decimal n)
        {
            return string.Format("{0:0.0000}", ((decimal)dic[item]) / n);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
