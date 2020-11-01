using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMWARE_Client
{

    public partial class login : Form
    {
        string dir_client_login = "C:\\NahAQBKFLx\\credentials.aimware";
        Color startColor = Color.FromArgb(255, 172, 25, 22);
        Color EndColor = Color.FromArgb(255, 157, 22, 19);

        /*requirements for our dragable logo */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /*requirements for our dragable logo */

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            string dir_client_login = "C:\\NahAQBKFLx\\credentials.aimware";
            if (File.Exists(dir_client_login) && dir_client_login.Length != 0)
            {
                try
                {
                    if (File.ReadLines(dir_client_login).Skip(0).Take(1).First() == "1")
                    {
                        tbox_name.Text = File.ReadLines(dir_client_login).Skip(1).Take(1).First();
                        tbox_pass.Text = File.ReadLines(dir_client_login).Skip(2).Take(1).First();
                        chbox_savecredentials.Checked = true;
                    }
                }
                catch (Exception ex)
                {
                    File.Delete(dir_client_login);
                    Application.Restart();
                  //  throw ex;
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var load = new load();
            if (tbox_name.Text == "admin" && tbox_pass.Text == "admin")
            {
                try
                {
                    TextWriter tw = new StreamWriter(dir_client_login);

                    if (chbox_savecredentials.Checked == true)
                    {
                        if (File.Exists(dir_client_login))
                        {
                            tw.WriteLine("1" + "\n" + tbox_name.Text + "\n" + tbox_pass.Text);
                            tw.Close();
                        }
                    }
                    else if (chbox_savecredentials.Checked == false)
                    {
                        if (File.Exists(dir_client_login))
                        {
                            tw.WriteLine("0" + "\n" + tbox_name.Text + "\n" + tbox_pass.Text);
                            tw.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                this.Hide();
                load.Show();
                load.t.Start();
            }
            else
            {
                var error = new error();
                error.errorLevel = 1;
                error.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_footer2_Click(object sender, EventArgs e)
        {
            Process.Start("https://aimware.net");
        }

        /* drag the window */
        private void logo_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /* drag the window */

        /* style */
        private void btn_cancel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //fill the button with color gradient rectangle and draw a string in it
            g.FillRectangle(
                new LinearGradientBrush(PointF.Empty, new PointF(0, btn_cancel.Height), startColor, EndColor),
                new RectangleF(PointF.Empty, btn_cancel.Size));

            g.DrawString(
                "Cancel",
                new Font("Segoe UI Semibold", 9F), Brushes.White, new Point(41, 3));
            g.DrawLine(Pens.White, btn_cancel.Left, btn_cancel.Top, btn_cancel.Right, btn_cancel.Bottom);
        }

        private void btn_login_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //fill the button with color gradient rectangle and draw a string in it
            g.FillRectangle(
                new LinearGradientBrush(PointF.Empty, new PointF(0, btn_cancel.Height), startColor, EndColor),
                new RectangleF(PointF.Empty, btn_cancel.Size));

            g.DrawString(
                "Login",
                new Font("Segoe UI Semibold", 9F),Brushes.White, new Point(41, 3));
            g.DrawLine(Pens.White, btn_cancel.Left, btn_cancel.Top, btn_cancel.Right, btn_cancel.Bottom);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            startColor = Color.FromArgb(255, 191, 28, 25);
            EndColor = Color.FromArgb(255, 174, 25, 22);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            startColor = Color.FromArgb(255, 172, 25, 22);
            EndColor = Color.FromArgb(255, 157, 22, 19);
        }

        // unfinished custom colors
        private void label1_Click(object sender, EventArgs e)
        {
            ColorDialog cdia = new ColorDialog();
            cdia.ShowDialog();
            Color clr = cdia.Color;

            this.BackColor = clr;

        }

        private void tbox_name_TextChanged(object sender, EventArgs e)
        {

        }
        /* style */
    }
}
