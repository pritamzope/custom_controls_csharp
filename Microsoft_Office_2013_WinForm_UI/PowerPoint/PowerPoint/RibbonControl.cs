using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPoint
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
            TransitionsButton.ChangeColorMouseHC = true;
            AnimationsButton.ChangeColorMouseHC = true;
            SlideShowButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            HomeButton.ForeColor = Color.FromArgb(220, 70, 40);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            TransitionsButton.ForeColor = Color.FromArgb(30, 30, 30);
            AnimationsButton.ForeColor = Color.FromArgb(30, 30, 30);
            SlideShowButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            HomeButton.ShowBorder = true;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            TransitionsButton.ShowBorder = false;
            AnimationsButton.ShowBorder = false;
            SlideShowButton.ShowBorder = false;
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
            TransitionsButton.ChangeColorMouseHC = true;
            AnimationsButton.ChangeColorMouseHC = true;
            SlideShowButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            InsertButton.ForeColor = Color.FromArgb(220, 70, 40);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            TransitionsButton.ForeColor = Color.FromArgb(30, 30, 30);
            AnimationsButton.ForeColor = Color.FromArgb(30, 30, 30);
            SlideShowButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            InsertButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            TransitionsButton.ShowBorder = false;
            AnimationsButton.ShowBorder = false;
            SlideShowButton.ShowBorder = false;
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
            TransitionsButton.ChangeColorMouseHC = true;
            AnimationsButton.ChangeColorMouseHC = true;
            SlideShowButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            DesignButton.ForeColor = Color.FromArgb(220, 70, 40);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            TransitionsButton.ForeColor = Color.FromArgb(30, 30, 30);
            AnimationsButton.ForeColor = Color.FromArgb(30, 30, 30);
            SlideShowButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            DesignButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            TransitionsButton.ShowBorder = false;
            AnimationsButton.ShowBorder = false;
            SlideShowButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(DesignButton.Location.X,
                                            DesignButton.Location.X + DesignButton.Width);
        }

        private void TransitionsButton_Click(object sender, EventArgs e)
        {
            TransitionsButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            AnimationsButton.ChangeColorMouseHC = true;
            SlideShowButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            TransitionsButton.ForeColor = Color.FromArgb(220, 70, 40);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            AnimationsButton.ForeColor = Color.FromArgb(30, 30, 30);
            SlideShowButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            TransitionsButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            AnimationsButton.ShowBorder = false;
            SlideShowButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TransitionsButton.Location.X,
                                                        TransitionsButton.Location.X + TransitionsButton.Width);
        }

        private void AnimationsButton_Click(object sender, EventArgs e)
        {
            AnimationsButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            TransitionsButton.ChangeColorMouseHC = true;
            SlideShowButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            AnimationsButton.ForeColor = Color.FromArgb(220, 70, 40);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            TransitionsButton.ForeColor = Color.FromArgb(30, 30, 30);
            SlideShowButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            AnimationsButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            TransitionsButton.ShowBorder = false;
            SlideShowButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(AnimationsButton.Location.X,
                                            AnimationsButton.Location.X + AnimationsButton.Width);
        }

        private void SlideShowButton_Click(object sender, EventArgs e)
        {
            SlideShowButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            TransitionsButton.ChangeColorMouseHC = true;
            AnimationsButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            SlideShowButton.ForeColor = Color.FromArgb(220, 70, 40);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            TransitionsButton.ForeColor = Color.FromArgb(30, 30, 30);
            AnimationsButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            SlideShowButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            TransitionsButton.ShowBorder = false;
            AnimationsButton.ShowBorder = false;
            ReviewButton.ShowBorder = false;
            ViewButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(SlideShowButton.Location.X,
                                            SlideShowButton.Location.X + SlideShowButton.Width);
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            ReviewButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            InsertButton.ChangeColorMouseHC = true;
            DesignButton.ChangeColorMouseHC = true;
            TransitionsButton.ChangeColorMouseHC = true;
            AnimationsButton.ChangeColorMouseHC = true;
            SlideShowButton.ChangeColorMouseHC = true;
            ViewButton.ChangeColorMouseHC = true;

            ReviewButton.ForeColor = Color.FromArgb(220, 70, 40);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            TransitionsButton.ForeColor = Color.FromArgb(30, 30, 30);
            AnimationsButton.ForeColor = Color.FromArgb(30, 30, 30);
            SlideShowButton.ForeColor = Color.FromArgb(30, 30, 30);
            ViewButton.ForeColor = Color.FromArgb(30, 30, 30);

            ReviewButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            TransitionsButton.ShowBorder = false;
            AnimationsButton.ShowBorder = false;
            SlideShowButton.ShowBorder = false;
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
            TransitionsButton.ChangeColorMouseHC = true;
            AnimationsButton.ChangeColorMouseHC = true;
            SlideShowButton.ChangeColorMouseHC = true;
            ReviewButton.ChangeColorMouseHC = true;

            ViewButton.ForeColor = Color.FromArgb(220, 70, 40);
            InsertButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            DesignButton.ForeColor = Color.FromArgb(30, 30, 30);
            TransitionsButton.ForeColor = Color.FromArgb(30, 30, 30);
            AnimationsButton.ForeColor = Color.FromArgb(30, 30, 30);
            SlideShowButton.ForeColor = Color.FromArgb(30, 30, 30);
            ReviewButton.ForeColor = Color.FromArgb(30, 30, 30);

            ViewButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            InsertButton.ShowBorder = false;
            DesignButton.ShowBorder = false;
            TransitionsButton.ShowBorder = false;
            AnimationsButton.ShowBorder = false;
            SlideShowButton.ShowBorder = false;
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
