
namespace Program.forms.calendar.works
{
    partial class UserControlWorksBlankAdmin
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.UserControlWorksBlank_Click);
            this.label2.MouseLeave += new System.EventHandler(this.UserControlWorksBlank_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.UserControlWorksBlank_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.UserControlWorksBlank_Click);
            this.label1.MouseLeave += new System.EventHandler(this.UserControlWorksBlank_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.UserControlWorksBlank_MouseHover);
            // 
            // labelDays
            // 
            this.labelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDays.Location = new System.Drawing.Point(-2, 9);
            this.labelDays.Margin = new System.Windows.Forms.Padding(0);
            this.labelDays.Name = "labelDays";
            this.labelDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDays.Size = new System.Drawing.Size(47, 28);
            this.labelDays.TabIndex = 11;
            this.labelDays.Text = "00";
            this.labelDays.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDays.Click += new System.EventHandler(this.UserControlWorksBlank_Click);
            this.labelDays.MouseLeave += new System.EventHandler(this.UserControlWorksBlank_MouseLeave);
            this.labelDays.MouseHover += new System.EventHandler(this.UserControlWorksBlank_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(4, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 165);
            this.textBox1.TabIndex = 15;
            this.textBox1.Click += new System.EventHandler(this.UserControlWorksBlank_Click);
            this.textBox1.MouseLeave += new System.EventHandler(this.UserControlWorksBlank_MouseLeave);
            this.textBox1.MouseHover += new System.EventHandler(this.UserControlWorksBlank_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 14;
            this.label3.Click += new System.EventHandler(this.UserControlWorksBlank_Click);
            this.label3.MouseLeave += new System.EventHandler(this.UserControlWorksBlank_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.UserControlWorksBlank_MouseHover);
            // 
            // UserControlWorksBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDays);
            this.Name = "UserControlWorksBlank";
            this.Size = new System.Drawing.Size(185, 287);
            this.Click += new System.EventHandler(this.UserControlWorksBlank_Click);
            this.MouseLeave += new System.EventHandler(this.UserControlWorksBlank_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserControlWorksBlank_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}
