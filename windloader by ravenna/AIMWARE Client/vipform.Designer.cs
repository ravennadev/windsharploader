namespace AIMWARE_Client
{
    partial class vipform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vipform));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_footer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.lstbox_cheats = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.label_motd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(584, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.label_footer);
            this.panel1.Location = new System.Drawing.Point(-1, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 27);
            this.panel1.TabIndex = 9;
            // 
            // label_footer
            // 
            this.label_footer.AutoSize = true;
            this.label_footer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label_footer.Location = new System.Drawing.Point(195, 6);
            this.label_footer.Name = "label_footer";
            this.label_footer.Size = new System.Drawing.Size(210, 15);
            this.label_footer.TabIndex = 8;
            this.label_footer.Text = "Ⓒ 2020 RAVENNADEV | WINDSHARP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "when clicking on LOAD, your adblock and all its protection systems will be disabl" +
    "ed\r\nso that the windsharp can open the injection console.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_load);
            this.panel2.Location = new System.Drawing.Point(-1, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 40);
            this.panel2.TabIndex = 11;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(310, 8);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(268, 24);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Update Script";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_load_Click);
            this.btn_cancel.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_cancel_Paint);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(22, 8);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(268, 24);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Inject WindSharp";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            this.btn_load.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_load_Paint);
            this.btn_load.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_load.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // lstbox_cheats
            // 
            this.lstbox_cheats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lstbox_cheats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbox_cheats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstbox_cheats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstbox_cheats.FormattingEnabled = true;
            this.lstbox_cheats.ItemHeight = 18;
            this.lstbox_cheats.Items.AddRange(new object[] {
            "UPDATE: 10.22 patch",
            "BUGFIX: seraphine crash console fixed"});
            this.lstbox_cheats.Location = new System.Drawing.Point(21, 156);
            this.lstbox_cheats.Name = "lstbox_cheats";
            this.lstbox_cheats.ScrollAlwaysVisible = true;
            this.lstbox_cheats.Size = new System.Drawing.Size(268, 198);
            this.lstbox_cheats.TabIndex = 14;
            this.lstbox_cheats.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.lstbox_cheats.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Annoucements & Updates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(306, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Informations";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(309, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 60);
            this.panel4.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Version: Updated 10.22";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(306, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Features WindSharp";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(309, 244);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 110);
            this.panel5.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 105);
            this.label1.TabIndex = 19;
            this.label1.Text = "Orbwalk\r\nComboLogic\r\nPredLibs (common,wind,oktw)\r\nAllinOne Champs\r\nTarget Selecto" +
    "r x2\r\nBaseUlt\r\n\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(184, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(258, 67);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDown);
            // 
            // label_motd
            // 
            this.label_motd.BackColor = System.Drawing.Color.Transparent;
            this.label_motd.Font = new System.Drawing.Font("Amboqia Boriango", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_motd.ForeColor = System.Drawing.Color.White;
            this.label_motd.Location = new System.Drawing.Point(0, 92);
            this.label_motd.Name = "label_motd";
            this.label_motd.Size = new System.Drawing.Size(600, 30);
            this.label_motd.TabIndex = 5;
            this.label_motd.Text = "WINDSHARP LOADER BY: RAVENNA";
            this.label_motd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_motd.Click += new System.EventHandler(this.label_motd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "UNDETECTED";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // vipform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(598, 458);
            this.ControlBox = false;
            this.Controls.Add(this.label_motd);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstbox_cheats);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vipform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.vipform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ListBox lstbox_cheats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label_motd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_footer;
        private System.Windows.Forms.Label label2;
    }
}