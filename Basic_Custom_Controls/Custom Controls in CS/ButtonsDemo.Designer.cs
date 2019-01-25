namespace Custom_Controls_in_CS
{
    partial class ButtonsDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZ6 = new Custom_Controls_in_CS.ButtonZ();
            this.buttonZ5 = new Custom_Controls_in_CS.ButtonZ();
            this.buttonZ4 = new Custom_Controls_in_CS.ButtonZ();
            this.buttonZ3 = new Custom_Controls_in_CS.ButtonZ();
            this.buttonZ2 = new Custom_Controls_in_CS.ButtonZ();
            this.buttonZ1 = new Custom_Controls_in_CS.ButtonZ();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.cfButton1);
            this.BackPanel.Controls.Add(this.label1);
            this.BackPanel.Controls.Add(this.buttonZ6);
            this.BackPanel.Controls.Add(this.buttonZ5);
            this.BackPanel.Controls.Add(this.buttonZ4);
            this.BackPanel.Controls.Add(this.buttonZ3);
            this.BackPanel.Controls.Add(this.buttonZ2);
            this.BackPanel.Controls.Add(this.buttonZ1);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackPanel.GradientAngle = 90;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(788, 383);
            this.BackPanel.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Transparent1 = 222;
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
            this.cfButton1.Location = new System.Drawing.Point(754, 4);
            this.cfButton1.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cfButton1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cfButton1.Name = "cfButton1";
            this.cfButton1.Size = new System.Drawing.Size(31, 24);
            this.cfButton1.TabIndex = 7;
            this.cfButton1.Text = "X";
            this.cfButton1.TextLocation_X = 6;
            this.cfButton1.TextLocation_Y = 0;
            this.cfButton1.UseVisualStyleBackColor = true;
            this.cfButton1.Click += new System.EventHandler(this.cfButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buttons Demo";
            // 
            // buttonZ6
            // 
            this.buttonZ6.BackColor = System.Drawing.Color.Transparent;
            this.buttonZ6.BorderColor = System.Drawing.Color.Transparent;
            this.buttonZ6.BorderWidth = 2;
            this.buttonZ6.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Rect;
            this.buttonZ6.ButtonText = "This is Computer Programming";
            this.buttonZ6.EndColor = System.Drawing.Color.Navy;
            this.buttonZ6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZ6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ6.ForeColor = System.Drawing.Color.White;
            this.buttonZ6.GradientAngle = 90;
            this.buttonZ6.Location = new System.Drawing.Point(22, 285);
            this.buttonZ6.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.buttonZ6.MouseClickColor2 = System.Drawing.Color.Red;
            this.buttonZ6.MouseHoverColor1 = System.Drawing.Color.Magenta;
            this.buttonZ6.MouseHoverColor2 = System.Drawing.Color.Crimson;
            this.buttonZ6.Name = "buttonZ6";
            this.buttonZ6.ShowButtontext = true;
            this.buttonZ6.Size = new System.Drawing.Size(751, 80);
            this.buttonZ6.StartColor = System.Drawing.Color.Teal;
            this.buttonZ6.TabIndex = 5;
            this.buttonZ6.Text = "This is Computer Programming";
            this.buttonZ6.TextLocation_X = 220;
            this.buttonZ6.TextLocation_Y = 24;
            this.buttonZ6.Transparent1 = 255;
            this.buttonZ6.Transparent2 = 255;
            this.buttonZ6.UseVisualStyleBackColor = true;
            // 
            // buttonZ5
            // 
            this.buttonZ5.BackColor = System.Drawing.Color.Transparent;
            this.buttonZ5.BorderColor = System.Drawing.Color.Transparent;
            this.buttonZ5.BorderWidth = 2;
            this.buttonZ5.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Rect;
            this.buttonZ5.ButtonText = "HTML & CSS";
            this.buttonZ5.EndColor = System.Drawing.Color.Navy;
            this.buttonZ5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ5.ForeColor = System.Drawing.Color.White;
            this.buttonZ5.GradientAngle = 90;
            this.buttonZ5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonZ5.Location = new System.Drawing.Point(253, 137);
            this.buttonZ5.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.buttonZ5.MouseClickColor2 = System.Drawing.Color.Red;
            this.buttonZ5.MouseHoverColor1 = System.Drawing.Color.Yellow;
            this.buttonZ5.MouseHoverColor2 = System.Drawing.Color.DarkOrange;
            this.buttonZ5.Name = "buttonZ5";
            this.buttonZ5.ShowButtontext = true;
            this.buttonZ5.Size = new System.Drawing.Size(300, 129);
            this.buttonZ5.StartColor = System.Drawing.SystemColors.Highlight;
            this.buttonZ5.TabIndex = 4;
            this.buttonZ5.Text = "HTML & CSS";
            this.buttonZ5.TextLocation_X = 90;
            this.buttonZ5.TextLocation_Y = 50;
            this.buttonZ5.Transparent1 = 255;
            this.buttonZ5.Transparent2 = 255;
            this.buttonZ5.UseVisualStyleBackColor = true;
            // 
            // buttonZ4
            // 
            this.buttonZ4.BackColor = System.Drawing.Color.Transparent;
            this.buttonZ4.BorderColor = System.Drawing.Color.Transparent;
            this.buttonZ4.BorderWidth = 2;
            this.buttonZ4.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Circle;
            this.buttonZ4.ButtonText = "";
            this.buttonZ4.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonZ4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ4.ForeColor = System.Drawing.Color.White;
            this.buttonZ4.GradientAngle = 90;
            this.buttonZ4.Image = global::Custom_Controls_in_CS.Properties.Resources.save;
            this.buttonZ4.Location = new System.Drawing.Point(22, 137);
            this.buttonZ4.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.buttonZ4.MouseClickColor2 = System.Drawing.Color.Red;
            this.buttonZ4.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonZ4.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonZ4.Name = "buttonZ4";
            this.buttonZ4.ShowButtontext = true;
            this.buttonZ4.Size = new System.Drawing.Size(200, 129);
            this.buttonZ4.StartColor = System.Drawing.Color.Yellow;
            this.buttonZ4.TabIndex = 3;
            this.buttonZ4.TextLocation_X = 76;
            this.buttonZ4.TextLocation_Y = 24;
            this.buttonZ4.Transparent1 = 80;
            this.buttonZ4.Transparent2 = 120;
            this.buttonZ4.UseVisualStyleBackColor = true;
            // 
            // buttonZ3
            // 
            this.buttonZ3.BackColor = System.Drawing.Color.Transparent;
            this.buttonZ3.BorderColor = System.Drawing.Color.Transparent;
            this.buttonZ3.BorderWidth = 2;
            this.buttonZ3.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Rect;
            this.buttonZ3.ButtonText = "Button 3";
            this.buttonZ3.EndColor = System.Drawing.Color.DarkGreen;
            this.buttonZ3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ3.ForeColor = System.Drawing.Color.White;
            this.buttonZ3.GradientAngle = 90;
            this.buttonZ3.Image = global::Custom_Controls_in_CS.Properties.Resources.openproject;
            this.buttonZ3.Location = new System.Drawing.Point(576, 39);
            this.buttonZ3.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonZ3.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonZ3.MouseHoverColor1 = System.Drawing.Color.Lime;
            this.buttonZ3.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.buttonZ3.Name = "buttonZ3";
            this.buttonZ3.ShowButtontext = true;
            this.buttonZ3.Size = new System.Drawing.Size(200, 213);
            this.buttonZ3.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonZ3.TabIndex = 2;
            this.buttonZ3.Text = "Button 3";
            this.buttonZ3.TextLocation_X = 55;
            this.buttonZ3.TextLocation_Y = 90;
            this.buttonZ3.Transparent1 = 222;
            this.buttonZ3.Transparent2 = 255;
            this.buttonZ3.UseVisualStyleBackColor = true;
            // 
            // buttonZ2
            // 
            this.buttonZ2.BackColor = System.Drawing.Color.Transparent;
            this.buttonZ2.BorderColor = System.Drawing.Color.Transparent;
            this.buttonZ2.BorderWidth = 2;
            this.buttonZ2.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.RoundRect;
            this.buttonZ2.ButtonText = "Button 2";
            this.buttonZ2.EndColor = System.Drawing.Color.Purple;
            this.buttonZ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ2.ForeColor = System.Drawing.Color.White;
            this.buttonZ2.GradientAngle = 90;
            this.buttonZ2.Location = new System.Drawing.Point(291, 39);
            this.buttonZ2.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.buttonZ2.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonZ2.MouseHoverColor1 = System.Drawing.Color.MediumOrchid;
            this.buttonZ2.MouseHoverColor2 = System.Drawing.Color.Indigo;
            this.buttonZ2.Name = "buttonZ2";
            this.buttonZ2.ShowButtontext = true;
            this.buttonZ2.Size = new System.Drawing.Size(262, 81);
            this.buttonZ2.StartColor = System.Drawing.Color.Violet;
            this.buttonZ2.TabIndex = 1;
            this.buttonZ2.Text = "Button 2";
            this.buttonZ2.TextLocation_X = 86;
            this.buttonZ2.TextLocation_Y = 30;
            this.buttonZ2.Transparent1 = 220;
            this.buttonZ2.Transparent2 = 255;
            this.buttonZ2.UseVisualStyleBackColor = true;
            // 
            // buttonZ1
            // 
            this.buttonZ1.BackColor = System.Drawing.Color.Transparent;
            this.buttonZ1.BorderColor = System.Drawing.Color.Transparent;
            this.buttonZ1.BorderWidth = 2;
            this.buttonZ1.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Rect;
            this.buttonZ1.ButtonText = "Button 1";
            this.buttonZ1.EndColor = System.Drawing.Color.Black;
            this.buttonZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ1.ForeColor = System.Drawing.Color.White;
            this.buttonZ1.GradientAngle = 90;
            this.buttonZ1.Location = new System.Drawing.Point(22, 39);
            this.buttonZ1.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.buttonZ1.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.buttonZ1.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonZ1.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.ShowButtontext = true;
            this.buttonZ1.Size = new System.Drawing.Size(254, 69);
            this.buttonZ1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonZ1.TabIndex = 0;
            this.buttonZ1.Text = "Button 1";
            this.buttonZ1.TextLocation_X = 76;
            this.buttonZ1.TextLocation_Y = 24;
            this.buttonZ1.Transparent1 = 220;
            this.buttonZ1.Transparent2 = 255;
            this.buttonZ1.UseVisualStyleBackColor = true;
            // 
            // ButtonsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 383);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ButtonsDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ButtonsDemo";
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelZ.PanelZ BackPanel;
        private Custom_Controls_in_CS.ButtonZ buttonZ1;
        private Custom_Controls_in_CS.ButtonZ buttonZ3;
        private Custom_Controls_in_CS.ButtonZ buttonZ2;
        private Custom_Controls_in_CS.ButtonZ buttonZ4;
        private Custom_Controls_in_CS.ButtonZ buttonZ5;
        private Custom_Controls_in_CS.ButtonZ buttonZ6;
        private System.Windows.Forms.Label label1;
        private CFButton cfButton1;
    }
}