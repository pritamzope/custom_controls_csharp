using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word
{
    public partial class ControlBox : UserControl
    {
        Form form;
        public ControlBox(Form frm)
        {
            form = frm;
            InitializeComponent();
        }

        bool isWindowMaximized = false;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;

        public Size NormalWindowSize
        {
            get { return _normalWindowSize;}
            set { _normalWindowSize = value; }
        }

        public Point NormalWindowLocation
        {
            get { return _normalWindowLocation; }
            set { _normalWindowLocation = value; }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void minMaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                form.Location = _normalWindowLocation;
                form.Size = _normalWindowSize;
                toolTip1.SetToolTip(minMaxButton, "Maximize");
                minMaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = form.Size;
                _normalWindowLocation = form.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                form.Location = new Point(0, 0);
                form.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(minMaxButton, "Restore Down");
                minMaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
