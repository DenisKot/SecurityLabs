namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonGenerateP = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.richTextBoxFrom = new System.Windows.Forms.RichTextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxHow = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDecode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N (Кількість елементів):";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(145, 16);
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownN.TabIndex = 1;
            this.numericUpDownN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(128, 43);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(222, 20);
            this.textBoxP2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Другий ряд матриці:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "k:";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(250, 16);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.ReadOnly = true;
            this.textBoxK.Size = new System.Drawing.Size(100, 20);
            this.textBoxK.TabIndex = 5;
            // 
            // buttonGenerateP
            // 
            this.buttonGenerateP.Location = new System.Drawing.Point(365, 41);
            this.buttonGenerateP.Name = "buttonGenerateP";
            this.buttonGenerateP.Size = new System.Drawing.Size(108, 23);
            this.buttonGenerateP.TabIndex = 6;
            this.buttonGenerateP.Text = "Згенерувати";
            this.buttonGenerateP.UseVisualStyleBackColor = true;
            this.buttonGenerateP.Click += new System.EventHandler(this.buttonGenerateP_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(15, 184);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(229, 33);
            this.buttonEncode.TabIndex = 7;
            this.buttonEncode.Text = "Шифрувати";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // richTextBoxFrom
            // 
            this.richTextBoxFrom.Location = new System.Drawing.Point(15, 98);
            this.richTextBoxFrom.Name = "richTextBoxFrom";
            this.richTextBoxFrom.Size = new System.Drawing.Size(458, 80);
            this.richTextBoxFrom.TabIndex = 8;
            this.richTextBoxFrom.Text = "";
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(250, 184);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(223, 33);
            this.buttonDecode.TabIndex = 9;
            this.buttonDecode.Text = "Дешифрувати";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(15, 242);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(458, 90);
            this.richTextBoxResult.TabIndex = 10;
            this.richTextBoxResult.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Результат:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Хід виконання:";
            // 
            // richTextBoxHow
            // 
            this.richTextBoxHow.Location = new System.Drawing.Point(15, 356);
            this.richTextBoxHow.Name = "richTextBoxHow";
            this.richTextBoxHow.Size = new System.Drawing.Size(458, 90);
            this.richTextBoxHow.TabIndex = 12;
            this.richTextBoxHow.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ключ дешефрування:";
            // 
            // textBoxDecode
            // 
            this.textBoxDecode.Location = new System.Drawing.Point(128, 70);
            this.textBoxDecode.Name = "textBoxDecode";
            this.textBoxDecode.Size = new System.Drawing.Size(222, 20);
            this.textBoxDecode.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDecode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBoxHow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.richTextBoxFrom);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonGenerateP);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab3 © Котенко Денис №415 ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Button buttonGenerateP;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.RichTextBox richTextBoxFrom;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxHow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDecode;
    }
}

