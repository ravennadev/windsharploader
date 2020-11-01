using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMWARE_Client
{
    public partial class error : Form
    {
        public int errorLevel; // 1 = incorrect credentials
        Color startColor = Color.FromArgb(255, 172, 25, 22);
        Color EndColor = Color.FromArgb(255, 157, 22, 19);

        public error()
        {
            InitializeComponent();
        }

        private void error_Load(object sender, EventArgs e)
        {
            if (errorLevel == 1)
            {
                label_title.Text = "ERROR";
                label_error.Text = "USERNAME OR PASSWORD INVALID! \n PLEASE CHECK.";
            }
            else if (errorLevel == 2)
            {
                label_title.Text = "Error";
                label_error.Text = "Steam has been closed for security reasons.\n\nLoad cheat before loading Steam.";
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* style */
        private void btn_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //fill the button with color gradient rectangle and draw a string in it
            g.FillRectangle(
                new LinearGradientBrush(PointF.Empty, new PointF(0, btn.Height), startColor, EndColor),
                new RectangleF(PointF.Empty, btn.Size));

            g.DrawString(
                "Cancel",
                new Font("Segoe UI Semibold", 9F), Brushes.White, new Point(39, 5));
            g.DrawLine(Pens.White, btn.Left, btn.Top, btn.Right, btn.Bottom);
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

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }
        /* style */
    }
}
