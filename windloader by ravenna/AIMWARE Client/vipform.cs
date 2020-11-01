using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMWARE_Client
{
    public partial class vipform : Form
    {
        Color startColor = Color.FromArgb(255, 172, 25, 22);
        Color EndColor = Color.FromArgb(255, 157, 22, 19);
        private object label7;

        /*requirements for our dragable logo */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const string FileName = "https://ui.memoryhackers.org/game/league-of-legends";

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /*requirements for our dragable logo */

        public vipform()
        {
            InitializeComponent();
        }

        private void vipform_Load(object sender, EventArgs e)
        {
            lstbox_cheats.SelectedItem = "UPDATE: 10.22 patch";
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.lstbox_cheats.Invalidate();
        }

        void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            int index = e.Index;
            Graphics g = e.Graphics;
            foreach (int selectedIndex in this.lstbox_cheats.SelectedIndices)
            {
                if (index == selectedIndex)
                {
                    // Draw the new background colour
                    e.DrawBackground();
                    g.FillRectangle(new SolidBrush(Color.DarkGray), e.Bounds);
                }
            }

            // Get the item details
            Font font = lstbox_cheats.Font;
            Color colour = lstbox_cheats.ForeColor;
            string text = lstbox_cheats.Items[index].ToString();

            // Print the text
            g.DrawString(text, new Font("Segoe UI Semibold", 9F), new SolidBrush(Color.Black), (float)e.Bounds.X, (float)e.Bounds.Y);
            e.DrawFocusRectangle();
        }

        private void btn_cancel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //fill the button with color gradient rectangle and draw a string in it
            g.FillRectangle(
                new LinearGradientBrush(PointF.Empty, new PointF(0, btn_cancel.Height), startColor, EndColor),
                new RectangleF(PointF.Empty, btn_cancel.Size));

            g.DrawString(
                "Cancel",
                new Font("Segoe UI Semibold", 9F), Brushes.White, new Point(115, 3));
            g.DrawLine(Pens.White, btn_cancel.Left, btn_cancel.Top, btn_cancel.Right, btn_cancel.Bottom);
        }

        private void btn_load_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //fill the button with color gradient rectangle and draw a string in it
            g.FillRectangle(
                new LinearGradientBrush(PointF.Empty, new PointF(0, btn_cancel.Height), startColor, EndColor),
                new RectangleF(PointF.Empty, btn_cancel.Size));

            g.DrawString(
                "Load",
                new Font("Segoe UI Semibold", 9F), Brushes.White, new Point(115, 3));
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
        /* style */

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_footer2_Click(object sender, EventArgs e)
        {
            Process.Start(FileName);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = lstbox_cheats.SelectedItem.ToString();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            var load = new load();
            load.Show();
            load.label_loadtext.Text = "Legue Of Legends.exe Searching to inject...";
            load.t2.Start();
            this.Close();
        }

        private void label_motd_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
