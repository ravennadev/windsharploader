namespace AIMWARE_Client
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.chbox_savecredentials = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_motd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_footer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.label_footer);
            this.panel1.Location = new System.Drawing.Point(0, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Location = new System.Drawing.Point(0, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 40);
            this.panel2.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(204, 8);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 24);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(78, 8);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 24);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_login.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(176, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(78, 66);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(383, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbox_name
            // 
            this.tbox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tbox_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbox_name.Location = new System.Drawing.Point(102, 148);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(256, 23);
            this.tbox_name.TabIndex = 0;
            this.tbox_name.TextChanged += new System.EventHandler(this.tbox_name_TextChanged);
            // 
            // tbox_pass
            // 
            this.tbox_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tbox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbox_pass.Location = new System.Drawing.Point(102, 184);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.PasswordChar = '●';
            this.tbox_pass.Size = new System.Drawing.Size(256, 23);
            this.tbox_pass.TabIndex = 1;
            this.tbox_pass.UseSystemPasswordChar = true;
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(40, 148);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(60, 20);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_pass
            // 
            this.label_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pass.ForeColor = System.Drawing.Color.White;
            this.label_pass.Location = new System.Drawing.Point(40, 184);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(60, 22);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "Password";
            this.label_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbox_savecredentials
            // 
            this.chbox_savecredentials.AutoSize = true;
            this.chbox_savecredentials.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_savecredentials.ForeColor = System.Drawing.Color.White;
            this.chbox_savecredentials.Location = new System.Drawing.Point(102, 216);
            this.chbox_savecredentials.Name = "chbox_savecredentials";
            this.chbox_savecredentials.Size = new System.Drawing.Size(84, 19);
            this.chbox_savecredentials.TabIndex = 5;
            this.chbox_savecredentials.Text = "Save Login";
            this.chbox_savecredentials.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "?";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Discord - Ravenna#6982";
            // 
            // label_motd
            // 
            this.label_motd.BackColor = System.Drawing.Color.Transparent;
            this.label_motd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_motd.ForeColor = System.Drawing.Color.White;
            this.label_motd.Location = new System.Drawing.Point(3, 5);
            this.label_motd.Name = "label_motd";
            this.label_motd.Size = new System.Drawing.Size(396, 20);
            this.label_motd.TabIndex = 5;
            this.label_motd.Text = "Login using your forum credentials";
            this.label_motd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label_motd);
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 30);
            this.panel3.TabIndex = 2;
            // 
            // label_footer
            // 
            this.label_footer.AutoSize = true;
            this.label_footer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label_footer.Location = new System.Drawing.Point(112, 5);
            this.label_footer.Name = "label_footer";
            this.label_footer.Size = new System.Drawing.Size(210, 15);
            this.label_footer.TabIndex = 7;
            this.label_footer.Text = "Ⓒ 2020 RAVENNADEV | WINDSHARP";
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbox_savecredentials);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.tbox_pass);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.CheckBox chbox_savecredentials;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_footer;
        private System.Windows.Forms.Label label_motd;
        private System.Windows.Forms.Panel panel3;
    }
}