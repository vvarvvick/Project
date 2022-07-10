
namespace Program.forms.calendar.works
{
    partial class calendarWorksForm
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
            this.labelData = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelData.Location = new System.Drawing.Point(296, 96);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(298, 29);
            this.labelData.TabIndex = 23;
            this.labelData.Text = "Month Year Day";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daycontainer
            // 
            this.daycontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.daycontainer.Location = new System.Drawing.Point(12, 160);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(859, 350);
            this.daycontainer.TabIndex = 13;
            // 
            // calendarWorksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 575);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.daycontainer);
            this.Name = "calendarWorksForm";
            this.Text = "calendarWorksForm";
            this.Load += new System.EventHandler(this.calendarWorksForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
    }
}