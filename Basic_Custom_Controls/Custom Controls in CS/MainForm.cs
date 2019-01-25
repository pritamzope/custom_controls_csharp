using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Custom_Controls_in_CS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        bool isTopPanelDragged = false;
        Point offset;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        private void WindowTextLabel_MouseDown(object sender, MouseEventArgs e)
        {
            TopPanel_MouseDown(sender, e);
        }

        private void WindowTextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            TopPanel_MouseMove(sender, e);
        }

        private void WindowTextLabel_MouseUp(object sender, MouseEventArgs e)
        {
            TopPanel_MouseUp(sender, e);
        }

        private void FMinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buttonZ1_Click(object sender, EventArgs e)
        {
            new ButtonsDemo().ShowDialog();
        }

        private void buttonZ2_Click(object sender, EventArgs e)
        {
            new LabelsDemo().ShowDialog();
        }

        private void buttonZ3_Click(object sender, EventArgs e)
        {
            new TabControlDemo().ShowDialog();
        }

        private void exitbuttonZ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
