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
    public partial class TemplatesControl : UserControl
    {
        MainForm mainForm;
        TemplatesControl templatesControl;
        public TemplatesControl(MainForm mainfrm)
        {
            InitializeComponent();
            mainForm = mainfrm;
        }

        public TemplatesControl SetTemplatesControlObject
        {
            get { return templatesControl; }
            set { templatesControl = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.editorContainer.Visible = true;
            mainForm.LeftTopItemsPanel.Visible = true;
            mainForm.wordTabControl.Visible = true;
            mainForm.StatusPanel.Visible = true;
            mainForm.TopPanel.Separator = 0;
            mainForm.FormText.Text = "Document 1 - Microsoft Word";
            mainForm.MainPanel.Controls.Remove(templatesControl);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
