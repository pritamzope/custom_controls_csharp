using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace LabelZ
{
   public class LabelZ : System.Windows.Forms.Label
    {
        private Color color1 = Color.LightGreen;
        private Color color2 = Color.DarkBlue;
        private int color1Transparent = 150;
        private int color2Transparent = 150;
        private int angle = 90;
        private String text = "MyLabelX";

       //Create Properties
        public String DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }

        public Color StartColor
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }

        public Color EndColor
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }

        public int Transparent1
        {
            get { return color1Transparent; }
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int Transparent2
        {
            get { return color2Transparent; }
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int GradientAngle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }

        public LabelZ()
        {
            this.ForeColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Text = text;
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);
            //draw a string of text label
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, 50, 50), c1, c2, angle);
            e.Graphics.DrawString(this.Text, this.Font, b, new Point(0, 0));
        }
    }
}
