namespace WinFormsAppForImageProcessing_Cheng3001
{
    partial class frmGamma_Cheng3001
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRedValue = new System.Windows.Forms.TextBox();
            this.TxtBlueValue = new System.Windows.Forms.TextBox();
            this.TxtGreenValue = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Values must be between 0.2 and 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Green Value:";
            // 
            // TxtRedValue
            // 
            this.TxtRedValue.Location = new System.Drawing.Point(200, 94);
            this.TxtRedValue.Name = "TxtRedValue";
            this.TxtRedValue.Size = new System.Drawing.Size(165, 30);
            this.TxtRedValue.TabIndex = 4;
            this.TxtRedValue.Text = "1.0";
            // 
            // TxtBlueValue
            // 
            this.TxtBlueValue.Location = new System.Drawing.Point(200, 231);
            this.TxtBlueValue.Name = "TxtBlueValue";
            this.TxtBlueValue.Size = new System.Drawing.Size(165, 30);
            this.TxtBlueValue.TabIndex = 5;
            this.TxtBlueValue.Text = "1.0";
            // 
            // TxtGreenValue
            // 
            this.TxtGreenValue.Location = new System.Drawing.Point(200, 160);
            this.TxtGreenValue.Name = "TxtGreenValue";
            this.TxtGreenValue.Size = new System.Drawing.Size(165, 30);
            this.TxtGreenValue.TabIndex = 6;
            this.TxtGreenValue.Text = "1.0";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(54, 313);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(134, 46);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(231, 313);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(134, 46);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // frmGamma_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 393);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtGreenValue);
            this.Controls.Add(this.TxtBlueValue);
            this.Controls.Add(this.TxtRedValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGamma_Cheng3001";
            this.Text = "Gamma Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRedValue;
        private System.Windows.Forms.TextBox TxtBlueValue;
        private System.Windows.Forms.TextBox TxtGreenValue;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}