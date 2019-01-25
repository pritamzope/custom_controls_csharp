using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace PowerPoint
{
    public class TabPanel : System.Windows.Forms.Panel
    {
        private Color border_color = Color.FromArgb(100, 100, 100);
        private Point skip_point = new Point(0, 0);

        public Color BorderColor
        {
            get { return border_color; }
            set { border_color = value; Invalidate(); }
        }

        public Point SkipXRange
        {
            get { return skip_point; }
            set { skip_point = value; Invalidate(); }
        }

        public TabPanel()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), ClientRectangle);
            e.Graphics.DrawLine(new Pen(border_color), 0, 0, skip_point.X, 0);
            e.Graphics.DrawLine(new Pen(border_color), skip_point.Y, 0, this.Width, 0);
            e.Graphics.DrawLine(new Pen(border_color), 0, this.Height - 1, this.Width, this.Height - 1);
        }
    }
}
