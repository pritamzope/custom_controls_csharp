using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Custom_Controls_in_CS
{
    public partial class LabelsDemo : Form
    {
        public LabelsDemo()
        {
            InitializeComponent();
        }

        bool isBackPanelDragged = false;
        Point offset;

        private void BackPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBackPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isBackPanelDragged = false;
            }
        }

        private void BackPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBackPanelDragged)
            {
                Point newPoint = BackPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void BackPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBackPanelDragged = false;
        }


        private void cfButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
