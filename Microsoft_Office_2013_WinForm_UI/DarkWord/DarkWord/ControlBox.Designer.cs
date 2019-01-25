namespace DarkWord
{
    partial class ControlBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.helpButton = new DarkWord.ButtonZ();
            this.minButton = new DarkWord.ButtonZ();
            this.minMaxButton = new DarkWord.MinMaxButton();
            this.closeButton = new DarkWord.ButtonZ();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // helpButton
            // 
            this.helpButton.BZBackColor = System.Drawing.Color.White;
            this.helpButton.DisplayText = "?";
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.helpButton.Location = new System.Drawing.Point(0, 0);
            this.helpButton.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.helpButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(28, 18);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "?";
            this.helpButton.TextLocation_X = 6;
            this.helpButton.TextLocation_Y = -2;
            this.toolTip1.SetToolTip(this.helpButton, "Help");
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // minButton
            // 
            this.minButton.BZBackColor = System.Drawing.Color.White;
            this.minButton.DisplayText = "_";
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minButton.Location = new System.Drawing.Point(28, 0);
            this.minButton.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.minButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(28, 18);
            this.minButton.TabIndex = 2;
            this.minButton.Text = "_";
            this.minButton.TextLocation_X = 6;
            this.minButton.TextLocation_Y = -20;
            this.toolTip1.SetToolTip(this.minButton, "Minimize");
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // minMaxButton
            // 
            this.minMaxButton.BZBackColor = System.Drawing.Color.White;
            this.minMaxButton.CFormState = DarkWord.MinMaxButton.CustomFormState.Normal;
            this.minMaxButton.DisplayText = "_";
            this.minMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minMaxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minMaxButton.Location = new System.Drawing.Point(56, 0);
            this.minMaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.minMaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.minMaxButton.Name = "minMaxButton";
            this.minMaxButton.Size = new System.Drawing.Size(28, 18);
            this.minMaxButton.TabIndex = 1;
            this.minMaxButton.Text = "minMaxButton1";
            this.minMaxButton.TextLocation_X = 6;
            this.minMaxButton.TextLocation_Y = 5;
            this.toolTip1.SetToolTip(this.minMaxButton, "Maximize");
            this.minMaxButton.UseVisualStyleBackColor = true;
            this.minMaxButton.Click += new System.EventHandler(this.minMaxButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BZBackColor = System.Drawing.Color.White;
            this.closeButton.DisplayText = "X";
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.closeButton.Location = new System.Drawing.Point(84, 0);
            this.closeButton.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.closeButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 18);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.TextLocation_X = 6;
            this.closeButton.TextLocation_Y = -2;
            this.toolTip1.SetToolTip(this.closeButton, "Close");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ControlBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.minMaxButton);
            this.Controls.Add(this.closeButton);
            this.Name = "ControlBox";
            this.Size = new System.Drawing.Size(111, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonZ closeButton;
        private MinMaxButton minMaxButton;
        private ButtonZ minButton;
        private ButtonZ helpButton;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
