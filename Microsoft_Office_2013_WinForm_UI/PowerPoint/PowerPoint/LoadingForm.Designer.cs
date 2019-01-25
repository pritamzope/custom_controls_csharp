namespace PowerPoint
{
    partial class LoadingForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonZ2 = new PowerPoint.ButtonZ();
            this.buttonZ1 = new PowerPoint.ButtonZ();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.mainPanel.Controls.Add(this.buttonZ2);
            this.mainPanel.Controls.Add(this.buttonZ1);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(445, 239);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // buttonZ2
            // 
            this.buttonZ2.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ2.DisplayText = "_";
            this.buttonZ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ2.ForeColor = System.Drawing.Color.White;
            this.buttonZ2.Location = new System.Drawing.Point(390, 0);
            this.buttonZ2.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ2.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ2.Name = "buttonZ2";
            this.buttonZ2.Size = new System.Drawing.Size(27, 23);
            this.buttonZ2.TabIndex = 4;
            this.buttonZ2.Text = "_";
            this.buttonZ2.TextLocation_X = 6;
            this.buttonZ2.TextLocation_Y = -2;
            this.buttonZ2.UseVisualStyleBackColor = true;
            this.buttonZ2.Click += new System.EventHandler(this.buttonZ2_Click);
            // 
            // buttonZ1
            // 
            this.buttonZ1.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ1.DisplayText = "X";
            this.buttonZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ1.ForeColor = System.Drawing.Color.White;
            this.buttonZ1.Location = new System.Drawing.Point(418, 0);
            this.buttonZ1.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.Size = new System.Drawing.Size(27, 23);
            this.buttonZ1.TabIndex = 3;
            this.buttonZ1.Text = "X";
            this.buttonZ1.TextLocation_X = 6;
            this.buttonZ1.TextLocation_Y = 0;
            this.buttonZ1.UseVisualStyleBackColor = true;
            this.buttonZ1.Click += new System.EventHandler(this.buttonZ1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Processing...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "PowerPoint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Office";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 239);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word";
            this.Activated += new System.EventHandler(this.LoadingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingForm_Closed);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ButtonZ buttonZ1;
        private ButtonZ buttonZ2;
    }
}