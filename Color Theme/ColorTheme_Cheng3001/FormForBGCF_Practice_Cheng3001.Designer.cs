namespace ColorTheme_Cheng3001
{
    partial class FormForBGCF_Practice_Cheng3001
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
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.GrayRadioBtn = new System.Windows.Forms.RadioButton();
            this.WhiteRadioBtn = new System.Windows.Forms.RadioButton();
            this.RedRadioBtn = new System.Windows.Forms.RadioButton();
            this.GreenRadioBtn = new System.Windows.Forms.RadioButton();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BlueRadioBtn = new System.Windows.Forms.RadioButton();
            this.ColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.BlueRadioBtn);
            this.ColorGroupBox.Controls.Add(this.GrayRadioBtn);
            this.ColorGroupBox.Controls.Add(this.WhiteRadioBtn);
            this.ColorGroupBox.Controls.Add(this.RedRadioBtn);
            this.ColorGroupBox.Controls.Add(this.GreenRadioBtn);
            this.ColorGroupBox.Location = new System.Drawing.Point(103, 39);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(349, 341);
            this.ColorGroupBox.TabIndex = 2;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Select a backgroud color";
            // 
            // GrayRadioBtn
            // 
            this.GrayRadioBtn.AutoSize = true;
            this.GrayRadioBtn.Location = new System.Drawing.Point(30, 283);
            this.GrayRadioBtn.Name = "GrayRadioBtn";
            this.GrayRadioBtn.Size = new System.Drawing.Size(74, 27);
            this.GrayRadioBtn.TabIndex = 3;
            this.GrayRadioBtn.TabStop = true;
            this.GrayRadioBtn.Text = "Gray";
            this.GrayRadioBtn.UseVisualStyleBackColor = true;
            // 
            // WhiteRadioBtn
            // 
            this.WhiteRadioBtn.AutoSize = true;
            this.WhiteRadioBtn.Location = new System.Drawing.Point(30, 225);
            this.WhiteRadioBtn.Name = "WhiteRadioBtn";
            this.WhiteRadioBtn.Size = new System.Drawing.Size(86, 27);
            this.WhiteRadioBtn.TabIndex = 2;
            this.WhiteRadioBtn.TabStop = true;
            this.WhiteRadioBtn.Text = "White";
            this.WhiteRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RedRadioBtn
            // 
            this.RedRadioBtn.AutoSize = true;
            this.RedRadioBtn.Location = new System.Drawing.Point(30, 51);
            this.RedRadioBtn.Name = "RedRadioBtn";
            this.RedRadioBtn.Size = new System.Drawing.Size(68, 27);
            this.RedRadioBtn.TabIndex = 1;
            this.RedRadioBtn.TabStop = true;
            this.RedRadioBtn.Text = "Red";
            this.RedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // GreenRadioBtn
            // 
            this.GreenRadioBtn.AutoSize = true;
            this.GreenRadioBtn.Location = new System.Drawing.Point(30, 107);
            this.GreenRadioBtn.Name = "GreenRadioBtn";
            this.GreenRadioBtn.Size = new System.Drawing.Size(86, 27);
            this.GreenRadioBtn.TabIndex = 0;
            this.GreenRadioBtn.TabStop = true;
            this.GreenRadioBtn.Text = "Green";
            this.GreenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(167, 410);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(146, 51);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BlueRadioBtn
            // 
            this.BlueRadioBtn.AutoSize = true;
            this.BlueRadioBtn.Location = new System.Drawing.Point(30, 166);
            this.BlueRadioBtn.Name = "BlueRadioBtn";
            this.BlueRadioBtn.Size = new System.Drawing.Size(72, 27);
            this.BlueRadioBtn.TabIndex = 4;
            this.BlueRadioBtn.TabStop = true;
            this.BlueRadioBtn.Text = "Blue";
            this.BlueRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FormForBGCF_Practice_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 499);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ColorGroupBox);
            this.Name = "FormForBGCF_Practice_Cheng3001";
            this.Text = "Color Mixture Using Background";
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ColorGroupBox;
        private System.Windows.Forms.RadioButton GrayRadioBtn;
        private System.Windows.Forms.RadioButton WhiteRadioBtn;
        private System.Windows.Forms.RadioButton RedRadioBtn;
        private System.Windows.Forms.RadioButton GreenRadioBtn;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.RadioButton BlueRadioBtn;
    }
}