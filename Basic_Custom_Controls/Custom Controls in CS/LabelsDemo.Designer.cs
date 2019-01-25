namespace Custom_Controls_in_CS
{
    partial class LabelsDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackPanel = new PanelZ.PanelZ();
            this.cfButton1 = new Custom_Controls_in_CS.CFButton();
            this.labelZ4 = new LabelZ.LabelZ();
            this.labelZ3 = new LabelZ.LabelZ();
            this.labelZ2 = new LabelZ.LabelZ();
            this.labelZ1 = new LabelZ.LabelZ();
            this.label1 = new System.Windows.Forms.Label();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.label1);
            this.BackPanel.Controls.Add(this.cfButton1);
            this.BackPanel.Controls.Add(this.labelZ4);
            this.BackPanel.Controls.Add(this.labelZ3);
            this.BackPanel.Controls.Add(this.labelZ2);
            this.BackPanel.Controls.Add(this.labelZ1);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackPanel.GradientAngle = 90;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(625, 343);
            this.BackPanel.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Transparent1 = 255;
            this.BackPanel.Transparent2 = 255;
            this.BackPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseDown);
            this.BackPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseMove);
            this.BackPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseUp);
            // 
            // cfButton1
            // 
            this.cfButton1.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cfButton1.DisplayText = "X";
            this.cfButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cfButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfButton1.ForeColor = System.Drawing.Color.White;
            this.cfButton1.Location = new System.Drawing.Point(588, 5);
            this.cfButton1.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cfButton1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cfButton1.Name = "cfButton1";
            this.cfButton1.Size = new System.Drawing.Size(31, 24);
            this.cfButton1.TabIndex = 5;
            this.cfButton1.Text = "X";
            this.cfButton1.TextLocation_X = 6;
            this.cfButton1.TextLocation_Y = 0;
            this.cfButton1.UseVisualStyleBackColor = true;
            this.cfButton1.Click += new System.EventHandler(this.cfButton1_Click);
            // 
            // labelZ4
            // 
            this.labelZ4.AutoSize = true;
            this.labelZ4.BackColor = System.Drawing.Color.Transparent;
            this.labelZ4.DisplayText = "Java,Ruby,Python,ASM";
            this.labelZ4.EndColor = System.Drawing.Color.Teal;
            this.labelZ4.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ4.ForeColor = System.Drawing.Color.Transparent;
            this.labelZ4.GradientAngle = 45;
            this.labelZ4.Location = new System.Drawing.Point(58, 254);
            this.labelZ4.Name = "labelZ4";
            this.labelZ4.Size = new System.Drawing.Size(528, 58);
            this.labelZ4.StartColor = System.Drawing.Color.Red;
            this.labelZ4.TabIndex = 3;
            this.labelZ4.Text = "Java,Ruby,Python,ASM";
            this.labelZ4.Transparent1 = 255;
            this.labelZ4.Transparent2 = 255;
            // 
            // labelZ3
            // 
            this.labelZ3.AutoSize = true;
            this.labelZ3.BackColor = System.Drawing.Color.Transparent;
            this.labelZ3.DisplayText = "C#,VB,Win32,ASP";
            this.labelZ3.EndColor = System.Drawing.Color.Fuchsia;
            this.labelZ3.Font = new System.Drawing.Font("Lucida Bright", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ3.ForeColor = System.Drawing.Color.Transparent;
            this.labelZ3.GradientAngle = 320;
            this.labelZ3.Location = new System.Drawing.Point(35, 151);
            this.labelZ3.Name = "labelZ3";
            this.labelZ3.Size = new System.Drawing.Size(568, 72);
            this.labelZ3.StartColor = System.Drawing.Color.Yellow;
            this.labelZ3.TabIndex = 2;
            this.labelZ3.Text = "C#,VB,Win32,ASP";
            this.labelZ3.Transparent1 = 255;
            this.labelZ3.Transparent2 = 255;
            // 
            // labelZ2
            // 
            this.labelZ2.AutoSize = true;
            this.labelZ2.BackColor = System.Drawing.Color.Transparent;
            this.labelZ2.DisplayText = "HTML/CSS";
            this.labelZ2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelZ2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ2.ForeColor = System.Drawing.Color.Transparent;
            this.labelZ2.GradientAngle = 90;
            this.labelZ2.Location = new System.Drawing.Point(289, 35);
            this.labelZ2.Name = "labelZ2";
            this.labelZ2.Size = new System.Drawing.Size(314, 79);
            this.labelZ2.StartColor = System.Drawing.Color.Lime;
            this.labelZ2.TabIndex = 1;
            this.labelZ2.Text = "HTML/CSS";
            this.labelZ2.Transparent1 = 255;
            this.labelZ2.Transparent2 = 255;
            // 
            // labelZ1
            // 
            this.labelZ1.AutoSize = true;
            this.labelZ1.BackColor = System.Drawing.Color.Transparent;
            this.labelZ1.DisplayText = "C/C++";
            this.labelZ1.EndColor = System.Drawing.Color.Navy;
            this.labelZ1.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ1.ForeColor = System.Drawing.Color.Transparent;
            this.labelZ1.GradientAngle = 90;
            this.labelZ1.Location = new System.Drawing.Point(21, 35);
            this.labelZ1.Name = "labelZ1";
            this.labelZ1.Size = new System.Drawing.Size(242, 83);
            this.labelZ1.StartColor = System.Drawing.Color.Red;
            this.labelZ1.TabIndex = 0;
            this.labelZ1.Text = "C/C++";
            this.labelZ1.Transparent1 = 255;
            this.labelZ1.Transparent2 = 255;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Labels Demo";
            // 
            // LabelsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 343);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LabelsDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabelsDemo";
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelZ.PanelZ BackPanel;
        private LabelZ.LabelZ labelZ3;
        private LabelZ.LabelZ labelZ2;
        private LabelZ.LabelZ labelZ1;
        private LabelZ.LabelZ labelZ4;
        private CFButton cfButton1;
        private System.Windows.Forms.Label label1;
    }
}