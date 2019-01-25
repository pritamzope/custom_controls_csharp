using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            SetAndStartTimer();
        }


        Point offset;
        bool isMainPanelDragged = false;

        Timer timer = new Timer();

        private void SetAndStartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        static int count = 0;

        void timer_Tick(object sender, EventArgs e)
        {
            count += 2;
            label3.Text = "Processing...  (" + count + "%)";

            if (count == 100)
            {
                timer.Stop();
                this.Close();
            }
        }


        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMainPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isMainPanelDragged = false;
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMainPanelDragged)
            {
                Point newPoint = mainPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isMainPanelDragged = false;
        }

        private void buttonZ1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonZ2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Program.isMinimize = true;
        }

        private void LoadingForm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void LoadingForm_Activated(object sender, EventArgs e)
        {
            if (Program.isMinimize)
            {
                Program.isMinimize = false;
            }
        }
    }
}
