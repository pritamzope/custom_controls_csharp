using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Excel
{
    public class PanelX : System.Windows.Forms.Panel
    {
        private Color color1 = Color.FromArgb(40, 110, 70);
        private Color color2 = Color.White;
        private int separator = 350;

        public Color Color1
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }

        public Color Color2
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }

        public int Separator
        {
            get{return separator;}
            set{separator = value; Invalidate();}
        }

        public PanelX()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(color1), new Rectangle(0, 0, 
                                     separator, ClientRectangle.Height));
            e.Graphics.FillRectangle(new SolidBrush(color2), new Rectangle(separator, 0, 
                                     ClientRectangle.Width, ClientRectangle.Height));
        }
    }
}
