using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkWord
{
    static class Program
    {
        public static bool isMinimize = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadingForm());

            MainForm mainform = new MainForm();
            mainform.LeftTopItemsPanel.Visible = false;
            mainform.wordTabControl.Visible = false;
            mainform.editorContainer.Visible = false;
            mainform.StatusPanel.Visible = false;
            mainform.TopPanel.Separator = 280;
            mainform.FormText.Text = "";

            TemplatesControl templatesControl = new TemplatesControl(mainform);
            templatesControl.Location = new Point(0, 0);
            templatesControl.Height = mainform.MainPanel.Height;
            templatesControl.Dock = DockStyle.Fill;
            mainform.MainPanel.Controls.Add(templatesControl);

            templatesControl.SetTemplatesControlObject = templatesControl;

            Application.Run(mainform);
        }
    }
}
