
namespace Program
{
    partial class menuUserForm
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.labelCurrentTitle = new System.Windows.Forms.Label();
            this.iconPictureBoxCurrentIcon = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonLogout = new FontAwesome.Sharp.IconButton();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonMessage = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdmin = new FontAwesome.Sharp.IconButton();
            this.iconButtonBase = new FontAwesome.Sharp.IconButton();
            this.iconButtonLogin = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentIcon)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.iconButton4);
            this.panelTop.Controls.Add(this.labelCurrentTitle);
            this.panelTop.Controls.Add(this.iconPictureBoxCurrentIcon);
            this.panelTop.Controls.Add(this.iconButtonLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(882, 90);
            this.panelTop.TabIndex = 1;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 22;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(764, 9);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(118, 40);
            this.iconButton4.TabIndex = 13;
            this.iconButton4.Text = "Settings";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // labelCurrentTitle
            // 
            this.labelCurrentTitle.AutoSize = true;
            this.labelCurrentTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentTitle.Location = new System.Drawing.Point(107, 32);
            this.labelCurrentTitle.Name = "labelCurrentTitle";
            this.labelCurrentTitle.Size = new System.Drawing.Size(73, 24);
            this.labelCurrentTitle.TabIndex = 1;
            this.labelCurrentTitle.Text = "Home";
            // 
            // iconPictureBoxCurrentIcon
            // 
            this.iconPictureBoxCurrentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.iconPictureBoxCurrentIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBoxCurrentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxCurrentIcon.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBoxCurrentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCurrentIcon.IconSize = 59;
            this.iconPictureBoxCurrentIcon.Location = new System.Drawing.Point(42, 21);
            this.iconPictureBoxCurrentIcon.Name = "iconPictureBoxCurrentIcon";
            this.iconPictureBoxCurrentIcon.Size = new System.Drawing.Size(59, 63);
            this.iconPictureBoxCurrentIcon.TabIndex = 0;
            this.iconPictureBoxCurrentIcon.TabStop = false;
            // 
            // iconButtonLogout
            // 
            this.iconButtonLogout.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.iconButtonLogout.FlatAppearance.BorderSize = 0;
            this.iconButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonLogout.ForeColor = System.Drawing.Color.White;
            this.iconButtonLogout.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.iconButtonLogout.IconColor = System.Drawing.Color.White;
            this.iconButtonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogout.IconSize = 22;
            this.iconButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogout.Location = new System.Drawing.Point(764, 44);
            this.iconButtonLogout.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonLogout.Name = "iconButtonLogout";
            this.iconButtonLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonLogout.Size = new System.Drawing.Size(120, 40);
            this.iconButtonLogout.TabIndex = 8;
            this.iconButtonLogout.Text = "Wyloguj";
            this.iconButtonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogout.UseVisualStyleBackColor = false;
            this.iconButtonLogout.Click += new System.EventHandler(this.iconButtonLogout_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelCenter.BackgroundImage = global::Program.Properties.Resources.gym;
            this.panelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCenter.Controls.Add(this.textBox1);
            this.panelCenter.Controls.Add(this.label2);
            this.panelCenter.Controls.Add(this.label1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelCenter.Location = new System.Drawing.Point(250, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(882, 574);
            this.panelCenter.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(92, 244);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(704, 177);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(88, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Twoja motywacja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witamy w Twoim panelu użytkownika poświęconemu dbaniu o sylwetkę i zdrowie";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImage = global::Program.Properties.Resources.backMenu;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.iconButtonMessage);
            this.panelMenu.Controls.Add(this.iconButtonAdmin);
            this.panelMenu.Controls.Add(this.iconButtonBase);
            this.panelMenu.Controls.Add(this.iconButtonLogin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 574);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 199);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(250, 40);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.Text = "Calendar Wroks";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 138);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(250, 40);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Calendar Diet";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButtonMessage
            // 
            this.iconButtonMessage.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonMessage.FlatAppearance.BorderSize = 0;
            this.iconButtonMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMessage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonMessage.ForeColor = System.Drawing.Color.White;
            this.iconButtonMessage.IconChar = FontAwesome.Sharp.IconChar.Weixin;
            this.iconButtonMessage.IconColor = System.Drawing.Color.White;
            this.iconButtonMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMessage.IconSize = 30;
            this.iconButtonMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMessage.Location = new System.Drawing.Point(0, 260);
            this.iconButtonMessage.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonMessage.Name = "iconButtonMessage";
            this.iconButtonMessage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMessage.Size = new System.Drawing.Size(250, 40);
            this.iconButtonMessage.TabIndex = 9;
            this.iconButtonMessage.Text = "Message";
            this.iconButtonMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMessage.UseVisualStyleBackColor = false;
            this.iconButtonMessage.Click += new System.EventHandler(this.iconButtonMessage_Click);
            // 
            // iconButtonAdmin
            // 
            this.iconButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.iconButtonAdmin.FlatAppearance.BorderSize = 0;
            this.iconButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.iconButtonAdmin.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonAdmin.IconColor = System.Drawing.Color.White;
            this.iconButtonAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdmin.IconSize = 30;
            this.iconButtonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdmin.Location = new System.Drawing.Point(0, 500);
            this.iconButtonAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAdmin.Name = "iconButtonAdmin";
            this.iconButtonAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAdmin.Size = new System.Drawing.Size(250, 40);
            this.iconButtonAdmin.TabIndex = 6;
            this.iconButtonAdmin.Text = "Home";
            this.iconButtonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdmin.UseVisualStyleBackColor = false;
            this.iconButtonAdmin.Click += new System.EventHandler(this.iconButtonAdmin_Click);
            // 
            // iconButtonBase
            // 
            this.iconButtonBase.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonBase.FlatAppearance.BorderSize = 0;
            this.iconButtonBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonBase.ForeColor = System.Drawing.Color.White;
            this.iconButtonBase.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.iconButtonBase.IconColor = System.Drawing.Color.White;
            this.iconButtonBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBase.IconSize = 30;
            this.iconButtonBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBase.Location = new System.Drawing.Point(0, 77);
            this.iconButtonBase.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonBase.Name = "iconButtonBase";
            this.iconButtonBase.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonBase.Size = new System.Drawing.Size(250, 40);
            this.iconButtonBase.TabIndex = 3;
            this.iconButtonBase.Text = "Creator Menu";
            this.iconButtonBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBase.UseVisualStyleBackColor = false;
            this.iconButtonBase.Click += new System.EventHandler(this.iconButtonBase_Click);
            // 
            // iconButtonLogin
            // 
            this.iconButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonLogin.FlatAppearance.BorderSize = 0;
            this.iconButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonLogin.ForeColor = System.Drawing.Color.White;
            this.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconButtonLogin.IconColor = System.Drawing.Color.White;
            this.iconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogin.IconSize = 30;
            this.iconButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogin.Location = new System.Drawing.Point(0, 16);
            this.iconButtonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonLogin.Name = "iconButtonLogin";
            this.iconButtonLogin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonLogin.Size = new System.Drawing.Size(250, 40);
            this.iconButtonLogin.TabIndex = 1;
            this.iconButtonLogin.Text = "Personal Data";
            this.iconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogin.UseVisualStyleBackColor = false;
            this.iconButtonLogin.Click += new System.EventHandler(this.IconButtonLogin_Click);
            // 
            // menuUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 574);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelMenu);
            this.Name = "menuUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentIcon)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label labelCurrentTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCurrentIcon;
        public FontAwesome.Sharp.IconButton iconButtonLogin;
        private FontAwesome.Sharp.IconButton iconButtonAdmin;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
        private FontAwesome.Sharp.IconButton iconButtonMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonBase;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}

