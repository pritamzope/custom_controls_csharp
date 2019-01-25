using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkWord
{
    public partial class Share_OptionControl : UserControl
    {
        public Share_OptionControl()
        {
            InitializeComponent();
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            optionButton1.BZBackColor = Color.FromArgb(80, 80, 80);
            optionButton1.ChangeColorMouseHC = false;
            optionButton2.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton3.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton4.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton2.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
            optionButton4.ChangeColorMouseHC = true;
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            optionButton2.BZBackColor = Color.FromArgb(80, 80, 80);
            optionButton2.ChangeColorMouseHC = false;
            optionButton1.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton3.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton4.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton1.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
            optionButton4.ChangeColorMouseHC = true;
        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
            optionButton3.BZBackColor = Color.FromArgb(80, 80, 80);
            optionButton3.ChangeColorMouseHC = false;
            optionButton1.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton2.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton4.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton1.ChangeColorMouseHC = true;
            optionButton2.ChangeColorMouseHC = true;
            optionButton4.ChangeColorMouseHC = true;
        }

        private void optionButton4_Click(object sender, EventArgs e)
        {
            optionButton4.BZBackColor = Color.FromArgb(80, 80, 80);
            optionButton4.ChangeColorMouseHC = false;
            optionButton1.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton2.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton3.BZBackColor = Color.FromArgb(30, 30, 30);
            optionButton1.ChangeColorMouseHC = true;
            optionButton2.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
        }
    }
}
