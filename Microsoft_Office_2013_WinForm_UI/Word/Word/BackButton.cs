using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
namespace Word
{
    public class BackButton : System.Windows.Forms.Button
    {
        Color clr1;
        private Color color = Color.White;
        private Color m_hovercolor = Color.FromArgb(0, 0, 140);

        public Color MouseHoverColor
        {
            get { return m_hovercolor; }
            set { m_hovercolor = value; Invalidate(); }
        }


        public BackButton()
        {
            this.Size = new System.Drawing.Size(50, 45);
            this.ForeColor = Color.White;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            color = m_hovercolor;
        }
        
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            color = this.ForeColor;
        }

        Point[] arrro_points = {new Point(18,20), new Point(32, 20),
                                new Point(18,21), new Point(32, 21),
                                new Point(18,22), new Point(32, 22),

                                new Point(17,22), new Point(25, 14),
                                new Point(18,22), new Point(26, 14),
                                new Point(19,22), new Point(27, 14),

                                new Point(17,22), new Point(25, 30),
                                new Point(18,22), new Point(26, 30),
                                new Point(19,22), new Point(27, 30)};


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(45, 85, 155)), ClientRectangle);
            pe.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(45, 85, 155)), 8, 4, 35, 35);
            pe.Graphics.DrawEllipse(new Pen(new SolidBrush(color)), 8, 4, 34, 34);
            pe.Graphics.DrawEllipse(new Pen(new SolidBrush(color)), 9, 5, 33, 33);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[0], arrro_points[1]);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[2], arrro_points[3]);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[4], arrro_points[5]);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[6], arrro_points[7]);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[8], arrro_points[9]);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[10], arrro_points[11]);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[12], arrro_points[13]);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[14], arrro_points[15]);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(color)), arrro_points[16], arrro_points[17]);
            
        }

    }
}