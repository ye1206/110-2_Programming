namespace ColorTheme_Cheng3001
{
    partial class BackgroundColorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.YellowRadioBtn = new System.Windows.Forms.RadioButton();
            this.RedRadioBtn = new System.Windows.Forms.RadioButton();
            this.WhiteRadioBtn = new System.Windows.Forms.RadioButton();
            this.NormalRadioBtn = new System.Windows.Forms.RadioButton();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.NormalRadioBtn);
            this.ColorGroupBox.Controls.Add(this.WhiteRadioBtn);
            this.ColorGroupBox.Controls.Add(this.RedRadioBtn);
            this.ColorGroupBox.Controls.Add(this.YellowRadioBtn);
            this.ColorGroupBox.Location = new System.Drawing.Point(99, 39);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(349, 289);
            this.ColorGroupBox.TabIndex = 0;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Select a backgroud color";
            // 
            // YellowRadioBtn
            // 
            this.YellowRadioBtn.AutoSize = true;
            this.YellowRadioBtn.Location = new System.Drawing.Point(30, 53);
            this.YellowRadioBtn.Name = "YellowRadioBtn";
            this.YellowRadioBtn.Size = new System.Drawing.Size(91, 27);
            this.YellowRadioBtn.TabIndex = 0;
            this.YellowRadioBtn.TabStop = true;
            this.YellowRadioBtn.Text = "Yellow";
            this.YellowRadioBtn.UseVisualStyleBackColor = true;
            this.YellowRadioBtn.CheckedChanged += new System.EventHandler(this.YellowRadioBtn_CheckedChanged);
            // 
            // RedRadioBtn
            // 
            this.RedRadioBtn.AutoSize = true;
            this.RedRadioBtn.Location = new System.Drawing.Point(30, 103);
            this.RedRadioBtn.Name = "RedRadioBtn";
            this.RedRadioBtn.Size = new System.Drawing.Size(68, 27);
            this.RedRadioBtn.TabIndex = 1;
            this.RedRadioBtn.TabStop = true;
            this.RedRadioBtn.Text = "Red";
            this.RedRadioBtn.UseVisualStyleBackColor = true;
            this.RedRadioBtn.CheckedChanged += new System.EventHandler(this.RedRadioBtn_CheckedChanged);
            // 
            // WhiteRadioBtn
            // 
            this.WhiteRadioBtn.AutoSize = true;
            this.WhiteRadioBtn.Location = new System.Drawing.Point(30, 161);
            this.WhiteRadioBtn.Name = "WhiteRadioBtn";
            this.WhiteRadioBtn.Size = new System.Drawing.Size(86, 27);
            this.WhiteRadioBtn.TabIndex = 2;
            this.WhiteRadioBtn.TabStop = true;
            this.WhiteRadioBtn.Text = "White";
            this.WhiteRadioBtn.UseVisualStyleBackColor = true;
            this.WhiteRadioBtn.CheckedChanged += new System.EventHandler(this.WhiteRadioBtn_CheckedChanged);
            // 
            // NormalRadioBtn
            // 
            this.NormalRadioBtn.AutoSize = true;
            this.NormalRadioBtn.Location = new System.Drawing.Point(30, 218);
            this.NormalRadioBtn.Name = "NormalRadioBtn";
            this.NormalRadioBtn.Size = new System.Drawing.Size(168, 27);
            this.NormalRadioBtn.TabIndex = 3;
            this.NormalRadioBtn.TabStop = true;
            this.NormalRadioBtn.Text = "Back to Normal";
            this.NormalRadioBtn.UseVisualStyleBackColor = true;
            this.NormalRadioBtn.CheckedChanged += new System.EventHandler(this.NormalRadioBtn_CheckedChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(166, 363);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(146, 51);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BackgroundColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 468);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ColorGroupBox);
            this.Name = "BackgroundColorForm";
            this.Text = "Color Theme";
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ColorGroupBox;
        private System.Windows.Forms.RadioButton NormalRadioBtn;
        private System.Windows.Forms.RadioButton WhiteRadioBtn;
        private System.Windows.Forms.RadioButton RedRadioBtn;
        private System.Windows.Forms.RadioButton YellowRadioBtn;
        private System.Windows.Forms.Button BtnExit;
    }
}
