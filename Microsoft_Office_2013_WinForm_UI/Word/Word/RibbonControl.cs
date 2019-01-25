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
    public partial class RibbonControl : UserControl
    {
        public RibbonControl()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeButton.ChangeColorMouseHC = false;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            PageLayoutButton.ChangeColorMouseHC = true;
            ReferencesButton.ChangeColorMouseHC = true;
            MailingsButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            HomeButton.ForeColor = Color.FromArgb(45, 85, 155);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            PageLayoutButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReferencesButton.ForeColor = Color.FromArgb(30, 30, 30);
            MailingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            HomeButton.ShowBorder = true;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            PageLayoutButton.ShowBorder = false;
            ReferencesButton.ShowBorder = false;
            MailingsButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(HomeButton.Location.X, 
                                            HomeButton.Location.X + HomeButton.Width);

            
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            PageLayoutButton.ChangeColorMouseHC = true;
            ReferencesButton.ChangeColorMouseHC = true;
            MailingsButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            InsertButton.ForeColor = Color.FromArgb(45, 85, 155);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            PageLayoutButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReferencesButton.ForeColor = Color.FromArgb(30, 30, 30);
            MailingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            InsertButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            PageLayoutButton.ShowBorder = false;
            ReferencesButton.ShowBorder = false;
            MailingsButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(InsertButton.Location.X,
                                            InsertButton.Location.X + InsertButton.Width);
        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            DesignButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            PageLayoutButton.ChangeColorMouseHC = true;
            ReferencesButton.ChangeColorMouseHC = true;
            MailingsButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            DesignButton.ForeColor = Color.FromArgb(45, 85, 155);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            PageLayoutButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReferencesButton.ForeColor = Color.FromArgb(30, 30, 30);
            MailingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            DesignButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            PageLayoutButton.ShowBorder = false;
            ReferencesButton.ShowBorder = false;
            MailingsButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(DesignButton.Location.X,
                                            DesignButton.Location.X + DesignButton.Width);
        }

        private void PageLayoutButton_Click(object sender, EventArgs e)
        {
            PageLayoutButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            ReferencesButton.ChangeColorMouseHC = true;
            MailingsButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            PageLayoutButton.ForeColor = Color.FromArgb(45, 85, 155);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReferencesButton.ForeColor = Color.FromArgb(30, 30, 30);
            MailingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            PageLayoutButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            ReferencesButton.ShowBorder = false;
            MailingsButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(PageLayoutButton.Location.X,
                                                        PageLayoutButton.Location.X + PageLayoutButton.Width);
        }

        private void ReferencesButton_Click(object sender, EventArgs e)
        {
            ReferencesButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            PageLayoutButton.ChangeColorMouseHC = true;
            MailingsButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            ReferencesButton.ForeColor = Color.FromArgb(45, 85, 155);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            PageLayoutButton.ForeColor = Color.FromArgb(30, 30, 30);
            MailingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            ReferencesButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            PageLayoutButton.ShowBorder = false;
            MailingsButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(ReferencesButton.Location.X,
                                            ReferencesButton.Location.X + ReferencesButton.Width);
        }

        private void MailingsButton_Click(object sender, EventArgs e)
        {
            MailingsButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            PageLayoutButton.ChangeColorMouseHC = true;
            ReferencesButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            MailingsButton.ForeColor = Color.FromArgb(45, 85, 155);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            PageLayoutButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReferencesButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            MailingsButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            PageLayoutButton.ShowBorder = false;
            ReferencesButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(MailingsButton.Location.X,
                                            MailingsButton.Location.X + MailingsButton.Width);
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            ReviewButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            PageLayoutButton.ChangeColorMouseHC = true;
            ReferencesButton.ChangeColorMouseHC = true;
            MailingsButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            ReviewButton.ForeColor = Color.FromArgb(45, 85, 155);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            PageLayoutButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReferencesButton.ForeColor = Color.FromArgb(30, 30, 30);
            MailingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            ReviewButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            PageLayoutButton.ShowBorder = false;
            ReferencesButton.ShowBorder = false;
            MailingsButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(ReviewButton.Location.X,
                                            ReviewButton.Location.X + ReviewButton.Width);
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            PageLayoutButton.ChangeColorMouseHC = true;
            ReferencesButton.ChangeColorMouseHC = true;
            MailingsButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;

            ViewButton.ForeColor = Color.FromArgb(45, 85, 155);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            PageLayoutButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReferencesButton.ForeColor = Color.FromArgb(30, 30, 30);
            MailingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);

            ViewButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            PageLayoutButton.ShowBorder = false;
            ReferencesButton.ShowBorder = false;
            MailingsButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(ViewButton.Location.X,
                                            ViewButton.Location.X + ViewButton.Width);
            
        }

        private void WordabControl_Load(object sender, EventArgs e)
        {
            HomeButton_Click(sender, e);
        }
    }
}
