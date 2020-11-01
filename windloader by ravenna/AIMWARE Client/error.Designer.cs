namespace AIMWARE_Client
{
    partial class error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(error));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn);
            this.panel2.Location = new System.Drawing.Point(-1, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 45);
            this.panel2.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(96, 10);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(121, 26);
            this.btn.TabIndex = 1;
            this.btn.Text = "Cancel";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            this.btn.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            this.btn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.panel1.Location = new System.Drawing.Point(-1, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 10);
            this.panel1.TabIndex = 4;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(141, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(32, 15);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Error";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // label_error
            // 
            this.label_error.BackColor = System.Drawing.Color.Transparent;
            this.label_error.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_error.ForeColor = System.Drawing.Color.White;
            this.label_error.Location = new System.Drawing.Point(26, 35);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(254, 55);
            this.label_error.TabIndex = 6;
            this.label_error.Text = "Error";
            this.label_error.Click += new System.EventHandler(this.label_error_Click);
            // 
            // error
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(306, 163);
            this.ControlBox = false;
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "error";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.error_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_title;
        public System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button btn;
    }
}