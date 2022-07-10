
namespace Program.forms
{
    partial class UserControlDaysAdmin
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
            this.labelDays = new System.Windows.Forms.Label();
            this.label_Event = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDays.Location = new System.Drawing.Point(12, 9);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(24, 18);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "00";
            this.labelDays.Click += new System.EventHandler(this.UserControlDays_Click);
            this.labelDays.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            this.labelDays.MouseHover += new System.EventHandler(this.UserControlDays_MouseHover);
            // 
            // label_Event
            // 
            this.label_Event.Location = new System.Drawing.Point(3, 27);
            this.label_Event.Name = "label_Event";
            this.label_Event.Size = new System.Drawing.Size(111, 19);
            this.label_Event.TabIndex = 1;
            this.label_Event.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Event.Click += new System.EventHandler(this.label_Event_Click);
            this.label_Event.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            this.label_Event.MouseHover += new System.EventHandler(this.UserControlDays_MouseHover);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_Event);
            this.Controls.Add(this.labelDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(117, 62);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserControlDays_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label label_Event;
    }
}
