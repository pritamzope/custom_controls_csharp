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
    public partial class FileOptionsControl : UserControl
    {
        FileOptionsControl fileOptionsControl;
        MainForm mainForm;
        public FileOptionsControl(FileOptionsControl foptctrl, MainForm mainFrm)
        {
            InitializeComponent();
            fileOptionsControl = foptctrl;
            mainForm = mainFrm;
        }

        public FileOptionsControl SetFileOptionsObject
        {
            get { return fileOptionsControl; }
            set { fileOptionsControl = value; }
        }


        Timer timer = new Timer();

        private void RemoveFileOptionsControl()
        {
            timer.Interval = 60;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }


        void timer_Tick(object sender, EventArgs e)
        {
            MainForm.width -= 100;
            fileOptionsControl.Width = MainForm.width;

            if (MainForm.width <= 200)
            {
                mainForm.TopPanel.Separator = 0;
                mainForm.LeftTopItemsPanel.Visible = true;
                mainForm.wordTabControl.Visible = true;
                mainForm.editorContainer.Visible = true;
                mainForm.StatusPanel.Visible = true;
                mainForm.MainPanel.Controls.Remove(fileOptionsControl);
                timer.Stop();
            }
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            fileOptionsControl.Dock = DockStyle.None;
            RemoveFileOptionsControl();
        }

        private void FileOptionsControl_Load(object sender, EventArgs e)
        {
            InfoButton_Click(sender, e);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoButton.BZBackColor = Color.FromArgb(65, 105, 175);
            InfoButton.ChangeColorMouseHC = false;
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;

            Info_OptionControl infooptctrl = new Info_OptionControl();
            infooptctrl.Dock = DockStyle.Fill;
            mainFilePanel.Controls.Clear();
            mainFilePanel.Controls.Add(infooptctrl);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewButton.BZBackColor = Color.FromArgb(65, 105, 175);
            NewButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;

            New_OptionControl newoptctrl = new New_OptionControl();
            newoptctrl.Dock = DockStyle.Fill;
            mainFilePanel.Controls.Clear();
            mainFilePanel.Controls.Add(newoptctrl);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenButton.BZBackColor = Color.FromArgb(65, 105, 175);
            OpenButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;

            Open_OptionControl openoptctrl = new Open_OptionControl();
            openoptctrl.Dock = DockStyle.Fill;
            mainFilePanel.Controls.Clear();
            mainFilePanel.Controls.Add(openoptctrl);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.BZBackColor = Color.FromArgb(65, 105, 175);
            SaveButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;

            
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveAsButton.BZBackColor = Color.FromArgb(65, 105, 175);
            SaveAsButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;

            SaveAs_OptionControl saveasoptctrl = new SaveAs_OptionControl();
            saveasoptctrl.Dock = DockStyle.Fill;
            mainFilePanel.Controls.Clear();
            mainFilePanel.Controls.Add(saveasoptctrl);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintButton.BZBackColor = Color.FromArgb(65, 105, 175);
            PrintButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;

            Print_OptionControl printoptctrl = new Print_OptionControl();
            printoptctrl.Dock = DockStyle.Fill;
            mainFilePanel.Controls.Clear();
            mainFilePanel.Controls.Add(printoptctrl);
        }

        private void ShareButton_Click(object sender, EventArgs e)
        {
            ShareButton.BZBackColor = Color.FromArgb(65, 105, 175);
            ShareButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;

            Share_OptionControl shareoptctrl = new Share_OptionControl();
            shareoptctrl.Dock = DockStyle.Fill;
            mainFilePanel.Controls.Clear();
            mainFilePanel.Controls.Add(shareoptctrl);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButton.BZBackColor = Color.FromArgb(65, 105, 175);
            ExportButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseButton.BZBackColor = Color.FromArgb(65, 105, 175);
            CloseButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountButton.BZBackColor = Color.FromArgb(65, 105, 175);
            AccountButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OptionsButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            OptionsButton.ChangeColorMouseHC = true;
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsButton.BZBackColor = Color.FromArgb(65, 105, 175);
            OptionsButton.ChangeColorMouseHC = false;
            InfoButton.BZBackColor = Color.FromArgb(45, 85, 155);
            NewButton.BZBackColor = Color.FromArgb(45, 85, 155);
            OpenButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveButton.BZBackColor = Color.FromArgb(45, 85, 155);
            SaveAsButton.BZBackColor = Color.FromArgb(45, 85, 155);
            PrintButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ShareButton.BZBackColor = Color.FromArgb(45, 85, 155);
            ExportButton.BZBackColor = Color.FromArgb(45, 85, 155);
            CloseButton.BZBackColor = Color.FromArgb(45, 85, 155);
            AccountButton.BZBackColor = Color.FromArgb(45, 85, 155);

            InfoButton.ChangeColorMouseHC = true;
            NewButton.ChangeColorMouseHC = true;
            OpenButton.ChangeColorMouseHC = true;
            SaveButton.ChangeColorMouseHC = true;
            SaveAsButton.ChangeColorMouseHC = true;
            PrintButton.ChangeColorMouseHC = true;
            ShareButton.ChangeColorMouseHC = true;
            ExportButton.ChangeColorMouseHC = true;
            CloseButton.ChangeColorMouseHC = true;
            AccountButton.ChangeColorMouseHC = true;
        }
    }
}
