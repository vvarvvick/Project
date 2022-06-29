
namespace Program.forms
{
    partial class calculatorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Bmr = new System.Windows.Forms.Button();
            this.label_Waga = new System.Windows.Forms.Label();
            this.textBox_Waga = new System.Windows.Forms.TextBox();
            this.label_Wiek = new System.Windows.Forms.Label();
            this.textBox_Wiek = new System.Windows.Forms.TextBox();
            this.label_Wzrost = new System.Windows.Forms.Label();
            this.textBox_Wzrost = new System.Windows.Forms.TextBox();
            this.label_Bmr = new System.Windows.Forms.Label();
            this.textBox_Bmr = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Amr = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_M = new System.Windows.Forms.TextBox();
            this.textBox_U = new System.Windows.Forms.TextBox();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.textBox_Bd = new System.Windows.Forms.TextBox();
            this.textBox_Bm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Amr = new System.Windows.Forms.TextBox();
            this.Wyniki = new System.Windows.Forms.GroupBox();
            this.button_Tmr = new System.Windows.Forms.Button();
            this.textBox_Tmr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Wyniki.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.radioButton_Female);
            this.groupBox1.Controls.Add(this.radioButton_Male);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_Bmr);
            this.groupBox1.Controls.Add(this.label_Waga);
            this.groupBox1.Controls.Add(this.textBox_Waga);
            this.groupBox1.Controls.Add(this.label_Wiek);
            this.groupBox1.Controls.Add(this.textBox_Wiek);
            this.groupBox1.Controls.Add(this.label_Wzrost);
            this.groupBox1.Controls.Add(this.textBox_Wzrost);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMR";
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(241, 35);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Female.TabIndex = 13;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Kobieta";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(3, 35);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(78, 17);
            this.radioButton_Male.TabIndex = 12;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Mężczyzna";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Płeć";
            // 
            // button_Bmr
            // 
            this.button_Bmr.Location = new System.Drawing.Point(187, 146);
            this.button_Bmr.Name = "button_Bmr";
            this.button_Bmr.Size = new System.Drawing.Size(75, 23);
            this.button_Bmr.TabIndex = 8;
            this.button_Bmr.Text = "Oblicz";
            this.button_Bmr.UseVisualStyleBackColor = true;
            this.button_Bmr.Click += new System.EventHandler(this.button_Bmr_Click);
            // 
            // label_Waga
            // 
            this.label_Waga.AutoSize = true;
            this.label_Waga.Location = new System.Drawing.Point(241, 76);
            this.label_Waga.Name = "label_Waga";
            this.label_Waga.Size = new System.Drawing.Size(89, 13);
            this.label_Waga.TabIndex = 5;
            this.label_Waga.Text = "Waga (kilogramy)";
            // 
            // textBox_Waga
            // 
            this.textBox_Waga.Location = new System.Drawing.Point(244, 92);
            this.textBox_Waga.Name = "textBox_Waga";
            this.textBox_Waga.Size = new System.Drawing.Size(75, 20);
            this.textBox_Waga.TabIndex = 4;
            // 
            // label_Wiek
            // 
            this.label_Wiek.AutoSize = true;
            this.label_Wiek.Location = new System.Drawing.Point(122, 76);
            this.label_Wiek.Name = "label_Wiek";
            this.label_Wiek.Size = new System.Drawing.Size(32, 13);
            this.label_Wiek.TabIndex = 3;
            this.label_Wiek.Text = "Wiek";
            // 
            // textBox_Wiek
            // 
            this.textBox_Wiek.Location = new System.Drawing.Point(125, 92);
            this.textBox_Wiek.Name = "textBox_Wiek";
            this.textBox_Wiek.Size = new System.Drawing.Size(75, 20);
            this.textBox_Wiek.TabIndex = 2;
            // 
            // label_Wzrost
            // 
            this.label_Wzrost.AutoSize = true;
            this.label_Wzrost.Location = new System.Drawing.Point(6, 76);
            this.label_Wzrost.Name = "label_Wzrost";
            this.label_Wzrost.Size = new System.Drawing.Size(100, 13);
            this.label_Wzrost.TabIndex = 1;
            this.label_Wzrost.Text = "Wzrost (centymetry)";
            // 
            // textBox_Wzrost
            // 
            this.textBox_Wzrost.Location = new System.Drawing.Point(6, 92);
            this.textBox_Wzrost.Name = "textBox_Wzrost";
            this.textBox_Wzrost.Size = new System.Drawing.Size(75, 20);
            this.textBox_Wzrost.TabIndex = 0;
            // 
            // label_Bmr
            // 
            this.label_Bmr.AutoSize = true;
            this.label_Bmr.Location = new System.Drawing.Point(15, 39);
            this.label_Bmr.Name = "label_Bmr";
            this.label_Bmr.Size = new System.Drawing.Size(66, 13);
            this.label_Bmr.TabIndex = 6;
            this.label_Bmr.Text = "BMR wynosi";
            // 
            // textBox_Bmr
            // 
            this.textBox_Bmr.Enabled = false;
            this.textBox_Bmr.Location = new System.Drawing.Point(98, 36);
            this.textBox_Bmr.Name = "textBox_Bmr";
            this.textBox_Bmr.Size = new System.Drawing.Size(102, 20);
            this.textBox_Bmr.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.button_Amr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_M);
            this.groupBox2.Controls.Add(this.textBox_U);
            this.groupBox2.Controls.Add(this.textBox_D);
            this.groupBox2.Controls.Add(this.textBox_Bd);
            this.groupBox2.Controls.Add(this.textBox_Bm);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(367, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AMR";
            // 
            // button_Amr
            // 
            this.button_Amr.Location = new System.Drawing.Point(112, 252);
            this.button_Amr.Name = "button_Amr";
            this.button_Amr.Size = new System.Drawing.Size(75, 23);
            this.button_Amr.TabIndex = 11;
            this.button_Amr.Text = "Oblicz";
            this.button_Amr.UseVisualStyleBackColor = true;
            this.button_Amr.Click += new System.EventHandler(this.button_Amr_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bardzo duża";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Duża";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Umiarkowana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mała";
            // 
            // textBox_M
            // 
            this.textBox_M.Location = new System.Drawing.Point(99, 93);
            this.textBox_M.Name = "textBox_M";
            this.textBox_M.Size = new System.Drawing.Size(100, 20);
            this.textBox_M.TabIndex = 6;
            // 
            // textBox_U
            // 
            this.textBox_U.Location = new System.Drawing.Point(99, 133);
            this.textBox_U.Name = "textBox_U";
            this.textBox_U.Size = new System.Drawing.Size(100, 20);
            this.textBox_U.TabIndex = 5;
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(99, 173);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(100, 20);
            this.textBox_D.TabIndex = 4;
            // 
            // textBox_Bd
            // 
            this.textBox_Bd.Location = new System.Drawing.Point(99, 213);
            this.textBox_Bd.Name = "textBox_Bd";
            this.textBox_Bd.Size = new System.Drawing.Size(100, 20);
            this.textBox_Bd.TabIndex = 3;
            // 
            // textBox_Bm
            // 
            this.textBox_Bm.Location = new System.Drawing.Point(99, 53);
            this.textBox_Bm.Name = "textBox_Bm";
            this.textBox_Bm.Size = new System.Drawing.Size(100, 20);
            this.textBox_Bm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bardzo mała";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dzienna aktywność (minuty)";
            // 
            // textBox_Amr
            // 
            this.textBox_Amr.Enabled = false;
            this.textBox_Amr.Location = new System.Drawing.Point(98, 67);
            this.textBox_Amr.Name = "textBox_Amr";
            this.textBox_Amr.Size = new System.Drawing.Size(102, 20);
            this.textBox_Amr.TabIndex = 12;
            // 
            // Wyniki
            // 
            this.Wyniki.BackColor = System.Drawing.Color.Silver;
            this.Wyniki.Controls.Add(this.button_Tmr);
            this.Wyniki.Controls.Add(this.textBox_Tmr);
            this.Wyniki.Controls.Add(this.label9);
            this.Wyniki.Controls.Add(this.label8);
            this.Wyniki.Controls.Add(this.textBox_Amr);
            this.Wyniki.Controls.Add(this.textBox_Bmr);
            this.Wyniki.Controls.Add(this.label_Bmr);
            this.Wyniki.Location = new System.Drawing.Point(66, 359);
            this.Wyniki.Name = "Wyniki";
            this.Wyniki.Size = new System.Drawing.Size(278, 148);
            this.Wyniki.TabIndex = 2;
            this.Wyniki.TabStop = false;
            this.Wyniki.Text = "Wyniki";
            // 
            // button_Tmr
            // 
            this.button_Tmr.Location = new System.Drawing.Point(213, 96);
            this.button_Tmr.Name = "button_Tmr";
            this.button_Tmr.Size = new System.Drawing.Size(59, 22);
            this.button_Tmr.TabIndex = 16;
            this.button_Tmr.Text = "Oblicz";
            this.button_Tmr.UseVisualStyleBackColor = true;
            this.button_Tmr.Click += new System.EventHandler(this.button_Tmr_Click);
            // 
            // textBox_Tmr
            // 
            this.textBox_Tmr.Enabled = false;
            this.textBox_Tmr.Location = new System.Drawing.Point(98, 98);
            this.textBox_Tmr.Name = "textBox_Tmr";
            this.textBox_Tmr.Size = new System.Drawing.Size(102, 20);
            this.textBox_Tmr.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "TER wynosi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "AMR wynosi";
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 576);
            this.Controls.Add(this.Wyniki);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "calculatorForm";
            this.Text = "calculatorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Wyniki.ResumeLayout(false);
            this.Wyniki.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Waga;
        private System.Windows.Forms.TextBox textBox_Waga;
        private System.Windows.Forms.Label label_Wiek;
        private System.Windows.Forms.TextBox textBox_Wiek;
        private System.Windows.Forms.Label label_Wzrost;
        private System.Windows.Forms.TextBox textBox_Wzrost;
        private System.Windows.Forms.Button button_Bmr;
        private System.Windows.Forms.TextBox textBox_Bmr;
        private System.Windows.Forms.Label label_Bmr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_M;
        private System.Windows.Forms.TextBox textBox_U;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.TextBox textBox_Bd;
        private System.Windows.Forms.TextBox textBox_Bm;
        private System.Windows.Forms.TextBox textBox_Amr;
        private System.Windows.Forms.Button button_Amr;
        private System.Windows.Forms.GroupBox Wyniki;
        private System.Windows.Forms.TextBox textBox_Tmr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Tmr;
    }
}