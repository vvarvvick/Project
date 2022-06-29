
namespace Program.forms
{
    partial class bmiForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKlatka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBiodra = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWzrost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWaga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelIBorca = new System.Windows.Forms.Label();
            this.checkBoxIBorca = new System.Windows.Forms.CheckBox();
            this.labelBorc = new System.Windows.Forms.Label();
            this.checkBoxBorc = new System.Windows.Forms.CheckBox();
            this.labelWThR = new System.Windows.Forms.Label();
            this.checkBoxWThR = new System.Windows.Forms.CheckBox();
            this.labelWskazanie = new System.Windows.Forms.Label();
            this.labelWagaNalezna = new System.Windows.Forms.Label();
            this.labelZawTlu = new System.Windows.Forms.Label();
            this.label_BMIPrmie = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.checkBoxWagaNalezna = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox_BMIPrmie = new System.Windows.Forms.CheckBox();
            this.checkBox_BMI = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz płeć";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.checkBoxFemale);
            this.groupBox1.Controls.Add(this.checkBoxMale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(117, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Płeć";
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Enabled = false;
            this.checkBoxFemale.Location = new System.Drawing.Point(181, 81);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(62, 17);
            this.checkBoxFemale.TabIndex = 4;
            this.checkBoxFemale.Text = "Kobieta";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Enabled = false;
            this.checkBoxMale.Location = new System.Drawing.Point(38, 81);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(79, 17);
            this.checkBoxMale.TabIndex = 3;
            this.checkBoxMale.Text = "Mężczyzna";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.buttonOblicz);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxKlatka);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxBiodra);
            this.groupBox2.Controls.Add(this.textBoxWiek);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxWzrost);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxWaga);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(43, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 212);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paramatrey";
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Enabled = false;
            this.buttonOblicz.Location = new System.Drawing.Point(330, 154);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(90, 30);
            this.buttonOblicz.TabIndex = 12;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Obwód klatki piersiowej";
            // 
            // textBoxKlatka
            // 
            this.textBoxKlatka.Enabled = false;
            this.textBoxKlatka.Location = new System.Drawing.Point(169, 126);
            this.textBoxKlatka.Name = "textBoxKlatka";
            this.textBoxKlatka.Size = new System.Drawing.Size(100, 20);
            this.textBoxKlatka.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Obwód bioder (Centymetry)";
            // 
            // textBoxBiodra
            // 
            this.textBoxBiodra.Enabled = false;
            this.textBoxBiodra.Location = new System.Drawing.Point(18, 126);
            this.textBoxBiodra.Name = "textBoxBiodra";
            this.textBoxBiodra.Size = new System.Drawing.Size(100, 20);
            this.textBoxBiodra.TabIndex = 8;
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Enabled = false;
            this.textBoxWiek.Location = new System.Drawing.Point(320, 57);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiek.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Podaj wiek";
            // 
            // textBoxWzrost
            // 
            this.textBoxWzrost.Enabled = false;
            this.textBoxWzrost.Location = new System.Drawing.Point(169, 57);
            this.textBoxWzrost.Name = "textBoxWzrost";
            this.textBoxWzrost.Size = new System.Drawing.Size(100, 20);
            this.textBoxWzrost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Podaj wzrost (centymetry)";
            // 
            // textBoxWaga
            // 
            this.textBoxWaga.Enabled = false;
            this.textBoxWaga.Location = new System.Drawing.Point(18, 57);
            this.textBoxWaga.Name = "textBoxWaga";
            this.textBoxWaga.Size = new System.Drawing.Size(100, 20);
            this.textBoxWaga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj wagę (kilogramy)";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Controls.Add(this.labelIBorca);
            this.groupBox3.Controls.Add(this.checkBoxIBorca);
            this.groupBox3.Controls.Add(this.labelBorc);
            this.groupBox3.Controls.Add(this.checkBoxBorc);
            this.groupBox3.Controls.Add(this.labelWThR);
            this.groupBox3.Controls.Add(this.checkBoxWThR);
            this.groupBox3.Controls.Add(this.labelWskazanie);
            this.groupBox3.Controls.Add(this.labelWagaNalezna);
            this.groupBox3.Controls.Add(this.labelZawTlu);
            this.groupBox3.Controls.Add(this.label_BMIPrmie);
            this.groupBox3.Controls.Add(this.labelBMI);
            this.groupBox3.Controls.Add(this.checkBoxWagaNalezna);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox_BMIPrmie);
            this.groupBox3.Controls.Add(this.checkBox_BMI);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(546, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 657);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 298);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Zapisz dane";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelIBorca
            // 
            this.labelIBorca.AutoSize = true;
            this.labelIBorca.Location = new System.Drawing.Point(243, 212);
            this.labelIBorca.Name = "labelIBorca";
            this.labelIBorca.Size = new System.Drawing.Size(0, 13);
            this.labelIBorca.TabIndex = 15;
            // 
            // checkBoxIBorca
            // 
            this.checkBoxIBorca.AutoSize = true;
            this.checkBoxIBorca.Location = new System.Drawing.Point(18, 211);
            this.checkBoxIBorca.Name = "checkBoxIBorca";
            this.checkBoxIBorca.Size = new System.Drawing.Size(201, 17);
            this.checkBoxIBorca.TabIndex = 14;
            this.checkBoxIBorca.Text = "Idealna Masa Ciała (wzór Broca) (kg)";
            this.checkBoxIBorca.UseVisualStyleBackColor = true;
            this.checkBoxIBorca.CheckedChanged += new System.EventHandler(this.checkBoxIBorca_CheckedChanged);
            // 
            // labelBorc
            // 
            this.labelBorc.AutoSize = true;
            this.labelBorc.Location = new System.Drawing.Point(243, 190);
            this.labelBorc.Name = "labelBorc";
            this.labelBorc.Size = new System.Drawing.Size(0, 13);
            this.labelBorc.TabIndex = 13;
            // 
            // checkBoxBorc
            // 
            this.checkBoxBorc.AutoSize = true;
            this.checkBoxBorc.Location = new System.Drawing.Point(18, 189);
            this.checkBoxBorc.Name = "checkBoxBorc";
            this.checkBoxBorc.Size = new System.Drawing.Size(205, 17);
            this.checkBoxBorc.TabIndex = 12;
            this.checkBoxBorc.Text = "Należna Masa Ciała (wzór Broca) (kg)";
            this.checkBoxBorc.UseVisualStyleBackColor = true;
            this.checkBoxBorc.CheckedChanged += new System.EventHandler(this.checkBoxBorc_CheckedChanged);
            // 
            // labelWThR
            // 
            this.labelWThR.AutoSize = true;
            this.labelWThR.Location = new System.Drawing.Point(175, 168);
            this.labelWThR.Name = "labelWThR";
            this.labelWThR.Size = new System.Drawing.Size(0, 13);
            this.labelWThR.TabIndex = 11;
            // 
            // checkBoxWThR
            // 
            this.checkBoxWThR.AutoSize = true;
            this.checkBoxWThR.Location = new System.Drawing.Point(18, 167);
            this.checkBoxWThR.Name = "checkBoxWThR";
            this.checkBoxWThR.Size = new System.Drawing.Size(120, 17);
            this.checkBoxWThR.TabIndex = 10;
            this.checkBoxWThR.Text = "Wskaźnik WThr (%)";
            this.checkBoxWThR.UseVisualStyleBackColor = true;
            this.checkBoxWThR.CheckedChanged += new System.EventHandler(this.checkBoxWThR_CheckedChanged);
            // 
            // labelWskazanie
            // 
            this.labelWskazanie.AutoSize = true;
            this.labelWskazanie.Location = new System.Drawing.Point(219, 73);
            this.labelWskazanie.Name = "labelWskazanie";
            this.labelWskazanie.Size = new System.Drawing.Size(0, 13);
            this.labelWskazanie.TabIndex = 9;
            // 
            // labelWagaNalezna
            // 
            this.labelWagaNalezna.AutoSize = true;
            this.labelWagaNalezna.Location = new System.Drawing.Point(175, 145);
            this.labelWagaNalezna.Name = "labelWagaNalezna";
            this.labelWagaNalezna.Size = new System.Drawing.Size(0, 13);
            this.labelWagaNalezna.TabIndex = 8;
            // 
            // labelZawTlu
            // 
            this.labelZawTlu.AutoSize = true;
            this.labelZawTlu.Location = new System.Drawing.Point(175, 122);
            this.labelZawTlu.Name = "labelZawTlu";
            this.labelZawTlu.Size = new System.Drawing.Size(0, 13);
            this.labelZawTlu.TabIndex = 7;
            // 
            // label_BMIPrmie
            // 
            this.label_BMIPrmie.AutoSize = true;
            this.label_BMIPrmie.Location = new System.Drawing.Point(175, 99);
            this.label_BMIPrmie.Name = "label_BMIPrmie";
            this.label_BMIPrmie.Size = new System.Drawing.Size(0, 13);
            this.label_BMIPrmie.TabIndex = 6;
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Location = new System.Drawing.Point(175, 73);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(0, 13);
            this.labelBMI.TabIndex = 5;
            // 
            // checkBoxWagaNalezna
            // 
            this.checkBoxWagaNalezna.AutoSize = true;
            this.checkBoxWagaNalezna.Location = new System.Drawing.Point(18, 144);
            this.checkBoxWagaNalezna.Name = "checkBoxWagaNalezna";
            this.checkBoxWagaNalezna.Size = new System.Drawing.Size(116, 17);
            this.checkBoxWagaNalezna.TabIndex = 4;
            this.checkBoxWagaNalezna.Text = "Waga należna (kg)";
            this.checkBoxWagaNalezna.UseVisualStyleBackColor = true;
            this.checkBoxWagaNalezna.CheckedChanged += new System.EventHandler(this.checkBoxWagaNalezna_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 121);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(136, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Zawartość tłuszczu (%)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox_BMIPrmie
            // 
            this.checkBox_BMIPrmie.AutoSize = true;
            this.checkBox_BMIPrmie.Location = new System.Drawing.Point(18, 98);
            this.checkBox_BMIPrmie.Name = "checkBox_BMIPrmie";
            this.checkBox_BMIPrmie.Size = new System.Drawing.Size(74, 17);
            this.checkBox_BMIPrmie.TabIndex = 2;
            this.checkBox_BMIPrmie.Text = "BMI Prmie";
            this.checkBox_BMIPrmie.UseVisualStyleBackColor = true;
            this.checkBox_BMIPrmie.CheckedChanged += new System.EventHandler(this.checkBox_BMIPrmie_CheckedChanged);
            // 
            // checkBox_BMI
            // 
            this.checkBox_BMI.AutoSize = true;
            this.checkBox_BMI.Location = new System.Drawing.Point(18, 72);
            this.checkBox_BMI.Name = "checkBox_BMI";
            this.checkBox_BMI.Size = new System.Drawing.Size(91, 17);
            this.checkBox_BMI.TabIndex = 1;
            this.checkBox_BMI.Text = "BMI (kg/m^2)";
            this.checkBox_BMI.UseVisualStyleBackColor = true;
            this.checkBox_BMI.CheckedChanged += new System.EventHandler(this.checkBox_BMI_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Wybierz interesujące Cie miary";
            // 
            // bmiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 759);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "bmiForm";
            this.Text = "bmiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWaga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKlatka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBiodra;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWzrost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWagaNalezna;
        private System.Windows.Forms.Label labelZawTlu;
        private System.Windows.Forms.Label label_BMIPrmie;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.CheckBox checkBoxWagaNalezna;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox_BMIPrmie;
        private System.Windows.Forms.CheckBox checkBox_BMI;
        private System.Windows.Forms.Label labelWskazanie;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.Label labelWThR;
        private System.Windows.Forms.CheckBox checkBoxWThR;
        private System.Windows.Forms.Label labelBorc;
        private System.Windows.Forms.CheckBox checkBoxBorc;
        private System.Windows.Forms.Label labelIBorca;
        private System.Windows.Forms.CheckBox checkBoxIBorca;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.Button buttonSave;
    }
}