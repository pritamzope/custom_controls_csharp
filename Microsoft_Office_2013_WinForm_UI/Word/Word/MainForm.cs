using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;

        bool isRightBottomPanelDragged = false;
        bool isLeftBottomPanelDragged = false;
        bool isRightTopPanelDragged = false;
        bool isLeftTopPanelDragged = false;

        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;

        
        //********************************************************************
        // TopBorderPanel
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }
        }

        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }


        //********************************************************************
        // TopPanel
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
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                minMaxButton_Click(sender, e);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                        toolTip1.SetToolTip(minMaxButton, "Maximize");
                        minMaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    toolTip1.SetToolTip(minMaxButton, "Restore Down");
                    minMaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }


        //********************************************************************
        // LeftPanel
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                    }
                }
            }
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }


        //********************************************************************
        // RightPanel
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                    FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                }
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }


        //********************************************************************
        // BottomPanel
        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }


        //********************************************************************
        // RightBottomPanel 1
        private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = true;
        }

        private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightBottomPanelDragged)
            {
                if (this.Width < 100 || this.Height < 50)
                {
                    this.Width = 100;
                    this.Height = 50;
                    isRightBottomPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                    this.Height = this.Height + e.Y;
                    FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                }
            }
        }

        private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = false;
        }

        //********************************************************************
        // RightBottomPanel 2
        private void RightBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseDown(sender, e);
        }

        private void RightBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseMove(sender, e);
        }

        private void RightBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseUp(sender, e);
        }


        //********************************************************************
        // LeftBottomPanel 1
        private void LeftBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = true;
        }

        private void LeftBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftBottomPanelDragged || this.Height < 50)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        this.Height = 50;
                        isLeftBottomPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Height = this.Height + e.Y;
                        FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                    }
                }
            }
        }

        private void LeftBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = false;
        }


        //********************************************************************
        // LeftBottomPanel 2
        private void LeftBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseDown(sender, e);
        }

        private void LeftBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseMove(sender, e);
        }

        private void LeftBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseUp(sender, e);
        }



        //********************************************************************
        // RightTopPanel 1
        private void RightTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = true;
        }

        private void RightTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y || e.X < this.Location.X)
            {
                if (isRightTopPanelDragged)
                {
                    if (this.Height < 50 || this.Width < 100)
                    {
                        this.Height = 50;
                        this.Width = 100;
                        isRightTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                        this.Width = this.Width + e.X;
                        FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                    }
                }
            }
        }

        private void RightTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = false;
        }

        //********************************************************************
        // RightTopPanel 2
        private void RightTopPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseDown(sender, e);
        }

        private void RightTopPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseMove(sender, e);
        }

        private void RightTopPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseUp(sender, e);
        }


        //********************************************************************
        // LeftTopPanel 1
        private void LeftTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = true;
        }

        private void LeftTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X || e.Y < this.Location.Y)
            {
                if (isLeftTopPanelDragged)
                {
                    if (this.Width < 100 || this.Height < 50)
                    {
                        this.Width = 100;
                        this.Height = 100;
                        isLeftTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                        FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                    }
                }
            }

        }

        private void LeftTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = false;
        }


        //********************************************************************
        // LeftTopPanel 2
        private void LeftTopPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseDown(sender, e);
        }

        private void LeftTopPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseMove(sender, e);
        }

        private void LeftTopPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseUp(sender, e);
        }

        //FormText
        private void FormText_MouseDown(object sender, MouseEventArgs e)
        {
            TopPanel_MouseDown(sender, e);
        }

        private void FormText_MouseMove(object sender, MouseEventArgs e)
        {
            TopPanel_MouseMove(sender, e);
        }

        private void FormText_MouseUp(object sender, MouseEventArgs e)
        {
            TopPanel_MouseUp(sender, e);
        }

        //buttons actions
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minMaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                toolTip1.SetToolTip(minMaxButton, "Maximize");
                minMaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;

                FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(minMaxButton, "Restore Down");
                minMaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;

                FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length,
                                            9);
            }
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            FormText.Location = new Point((TopPanel.Width/2) - FormText.Text.Length*2,
                                            9);
            wordTabControl.FileButton.Click += new EventHandler(this.FileButton_Click);
            wordTabControl.HomeButton.Click += new EventHandler(this.HomeButton_Click);
            wordTabControl.InsertButton.Click += new EventHandler(this.InsertButton_Click);
            wordTabControl.DesignButton.Click += new EventHandler(this.DesignButton_Click);
            wordTabControl.PageLayoutButton.Click += new EventHandler(this.PageLayoutButton_Click);
            wordTabControl.ReferencesButton.Click += new EventHandler(this.ReferencesButton_Click);
            wordTabControl.MailingsButton.Click += new EventHandler(this.MailingsButton_Click);
            wordTabControl.ReviewButton.Click += new EventHandler(this.ReviewButton_Click);
            wordTabControl.ViewButton.Click += new EventHandler(this.ViewButton_Click);


            HomeButton_Click(sender, e);
            
        }



        Timer timer = new Timer();
        FileOptionsControl fileOptionsControl;
        public static int width = 200;
        int count = 1;

        private void AddFileOptionsControl()
        {
            timer.Interval = 160;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }


        void timer_Tick(object sender, EventArgs e)
        {
            width += 100;
            count++;
            fileOptionsControl.Width = width;

            if (width >= MainPanel.Width - 100)
            {
                fileOptionsControl.Dock = DockStyle.Fill;
                timer.Stop();

            }
        }

        enum CTRLTypes
        {
            None,
            HomeType,
            InsertType,
            DesignType,
            PageLayoutType,
            ReferencesType,
            MailingsType,
            ReviewType,
            ViewType
        }


        private void FileButton_Click(object sender, EventArgs e)
        {
            editorContainer.Visible = false;
            LeftTopItemsPanel.Visible = false;
            wordTabControl.Visible = false;
            StatusPanel.Visible = false;
            TopPanel.Separator = 125;
            fileOptionsControl = new FileOptionsControl(fileOptionsControl, this);
            fileOptionsControl.Location = new Point(0, 0);
            fileOptionsControl.Height = MainPanel.Height;
            MainPanel.Controls.Add(fileOptionsControl);
            fileOptionsControl.SetFileOptionsObject = fileOptionsControl;
            AddFileOptionsControl();
        }


        static CTRLTypes addedControlType = CTRLTypes.None;

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.HomeType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                HomeControl homectrl = new HomeControl();
                homectrl.Location = new Point(1, 1);
                homectrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                wordTabControl.tabPanel.Controls.Add(homectrl);
                addedControlType = CTRLTypes.HomeType;
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.InsertType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.InsertType;
            }
        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.DesignType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.DesignType;
            }
        }

        private void PageLayoutButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.PageLayoutType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.PageLayoutType;
            }
        }

        private void ReferencesButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.ReferencesType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.ReferencesType;
            }
        }

        private void MailingsButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.MailingsType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.MailingsType;
            }
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.ReviewType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.ReviewType;
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.ViewType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.ViewType;
            }
        }

        
    }
}
