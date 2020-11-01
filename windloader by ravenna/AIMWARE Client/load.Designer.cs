namespace AIMWARE_Client
{
    partial class load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(load));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.btn = new System.Windows.Forms.Button();
            this.label_loadtext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.panel1.Location = new System.Drawing.Point(-1, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 10);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pbar);
            this.panel2.Controls.Add(this.btn);
            this.panel2.Location = new System.Drawing.Point(-1, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 51);
            this.panel2.TabIndex = 2;
            // 
            // pbar
            // 
            this.pbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(24)))), ((int)(((byte)(21)))));
            this.pbar.Location = new System.Drawing.Point(18, 10);
            this.pbar.MarqueeAnimationSpeed = 32;
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(184, 26);
            this.pbar.Step = 100;
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar.TabIndex = 1;
            this.pbar.Value = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(210, 10);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(121, 26);
            this.btn.TabIndex = 0;
            this.btn.Text = "Cancel";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            this.btn.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            this.btn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // label_loadtext
            // 
            this.label_loadtext.AutoSize = true;
            this.label_loadtext.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_loadtext.ForeColor = System.Drawing.Color.White;
            this.label_loadtext.Location = new System.Drawing.Point(103, 19);
            this.label_loadtext.Name = "label_loadtext";
            this.label_loadtext.Size = new System.Drawing.Size(157, 15);
            this.label_loadtext.TabIndex = 4;
            this.label_loadtext.Text = "MemoryHackers.org Login...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(334, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            // 
            // t
            // 
            this.t.Interval = 1600;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // t2
            // 
            this.t2.Interval = 1600;
            this.t2.Tick += new System.EventHandler(this.t2_Tick);
            // 
            // load
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(348, 104);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_loadtext);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "load";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.messagebox_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer t;
        public System.Windows.Forms.Label label_loadtext;
        public System.Windows.Forms.Timer t2;
    }
}