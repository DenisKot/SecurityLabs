namespace Lab2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aCtrl = new System.Windows.Forms.NumericUpDown();
            this.bCtrl = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.mCtrl = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.xCtrl = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.cryptBtn = new System.Windows.Forms.Button();
            this.rezultBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCtrl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 59);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "a:";
            // 
            // aCtrl
            // 
            this.aCtrl.Location = new System.Drawing.Point(30, 19);
            this.aCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.aCtrl.Name = "aCtrl";
            this.aCtrl.Size = new System.Drawing.Size(55, 20);
            this.aCtrl.TabIndex = 11;
            this.aCtrl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bCtrl
            // 
            this.bCtrl.Location = new System.Drawing.Point(124, 19);
            this.bCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bCtrl.Name = "bCtrl";
            this.bCtrl.Size = new System.Drawing.Size(55, 20);
            this.bCtrl.TabIndex = 14;
            this.bCtrl.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "b:";
            // 
            // mCtrl
            // 
            this.mCtrl.Location = new System.Drawing.Point(217, 19);
            this.mCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mCtrl.Name = "mCtrl";
            this.mCtrl.Size = new System.Drawing.Size(55, 20);
            this.mCtrl.TabIndex = 16;
            this.mCtrl.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "m:";
            // 
            // xCtrl
            // 
            this.xCtrl.Location = new System.Drawing.Point(313, 19);
            this.xCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xCtrl.Name = "xCtrl";
            this.xCtrl.Size = new System.Drawing.Size(55, 20);
            this.xCtrl.TabIndex = 18;
            this.xCtrl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "x0:";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(392, 18);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(90, 23);
            this.generateBtn.TabIndex = 19;
            this.generateBtn.Text = "Згенерувати";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // cryptBtn
            // 
            this.cryptBtn.Location = new System.Drawing.Point(12, 162);
            this.cryptBtn.Name = "cryptBtn";
            this.cryptBtn.Size = new System.Drawing.Size(241, 30);
            this.cryptBtn.TabIndex = 20;
            this.cryptBtn.Text = "Зашифрувати";
            this.cryptBtn.UseVisualStyleBackColor = true;
            this.cryptBtn.Click += new System.EventHandler(this.cryptBtn_Click);
            // 
            // rezultBox
            // 
            this.rezultBox.Location = new System.Drawing.Point(12, 198);
            this.rezultBox.Name = "rezultBox";
            this.rezultBox.Size = new System.Drawing.Size(482, 101);
            this.rezultBox.TabIndex = 21;
            this.rezultBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aCtrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bCtrl);
            this.groupBox1.Controls.Add(this.generateBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.xCtrl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mCtrl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 61);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметри";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(259, 162);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(235, 30);
            this.decryptBtn.TabIndex = 23;
            this.decryptBtn.Text = "Дешифрувати";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 308);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rezultBox);
            this.Controls.Add(this.cryptBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab2 © Котенко Денис №415 ";
            ((System.ComponentModel.ISupportInitialize)(this.aCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCtrl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown aCtrl;
        private System.Windows.Forms.NumericUpDown bCtrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mCtrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown xCtrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button cryptBtn;
        private System.Windows.Forms.RichTextBox rezultBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button decryptBtn;
    }
}

