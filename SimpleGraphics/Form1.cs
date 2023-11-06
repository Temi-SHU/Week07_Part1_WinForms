using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimpleGraphics
{
    public partial class Form1 : Form
    {
        Point previousMousePos = new Point(-1, -1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (previousMousePos.X == -1 && previousMousePos.Y == -1) previousMousePos = e.Location;

                // Need a graphics object to do paint on the form as a canvas
                Graphics g = ((Control)sender).CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rectangle = this.ClientRectangle;

                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Empty, 45))
                {
                    using (Pen pen = new Pen(brush, 1))
                    {
                        g.DrawLine(pen, previousMousePos, e.Location);
                        previousMousePos = e.Location;
                    }
                }
            }

        }
    }
}