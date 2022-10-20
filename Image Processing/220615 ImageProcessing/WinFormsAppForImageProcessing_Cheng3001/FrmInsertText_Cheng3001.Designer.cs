namespace WinFormsAppForImageProcessing_Cheng3001
{
    partial class FrmInsertText_Cheng3001
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.TxtText = new System.Windows.Forms.TextBox();
            this.TxtY = new System.Windows.Forms.TextBox();
            this.GradientCheckBox = new System.Windows.Forms.CheckBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.FontComboBox = new System.Windows.Forms.ComboBox();
            this.StyleComboBox = new System.Windows.Forms.ComboBox();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.Color1ComboBox = new System.Windows.Forms.ComboBox();
            this.Color2ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Font Style:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Font Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Font:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Text:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Y:";
            // 
            // TxtX
            // 
            this.TxtX.Location = new System.Drawing.Point(143, 27);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(346, 30);
            this.TxtX.TabIndex = 8;
            // 
            // TxtText
            // 
            this.TxtText.Location = new System.Drawing.Point(143, 124);
            this.TxtText.Name = "TxtText";
            this.TxtText.Size = new System.Drawing.Size(346, 30);
            this.TxtText.TabIndex = 14;
            // 
            // TxtY
            // 
            this.TxtY.Location = new System.Drawing.Point(143, 75);
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(346, 30);
            this.TxtY.TabIndex = 15;
            // 
            // GradientCheckBox
            // 
            this.GradientCheckBox.AutoSize = true;
            this.GradientCheckBox.Location = new System.Drawing.Point(40, 389);
            this.GradientCheckBox.Name = "GradientCheckBox";
            this.GradientCheckBox.Size = new System.Drawing.Size(110, 27);
            this.GradientCheckBox.TabIndex = 16;
            this.GradientCheckBox.Text = "Gradient";
            this.GradientCheckBox.UseVisualStyleBackColor = true;
            this.GradientCheckBox.CheckedChanged += new System.EventHandler(this.GradientCheckBox_CheckedChanged);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(40, 499);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(176, 45);
            this.BtnOK.TabIndex = 17;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(266, 499);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(176, 45);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FontComboBox
            // 
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Location = new System.Drawing.Point(143, 179);
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(346, 31);
            this.FontComboBox.TabIndex = 19;
            // 
            // StyleComboBox
            // 
            this.StyleComboBox.FormattingEnabled = true;
            this.StyleComboBox.Location = new System.Drawing.Point(143, 290);
            this.StyleComboBox.Name = "StyleComboBox";
            this.StyleComboBox.Size = new System.Drawing.Size(346, 31);
            this.StyleComboBox.TabIndex = 20;
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(143, 234);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(346, 31);
            this.SizeComboBox.TabIndex = 21;
            // 
            // Color1ComboBox
            // 
            this.Color1ComboBox.FormattingEnabled = true;
            this.Color1ComboBox.Location = new System.Drawing.Point(143, 336);
            this.Color1ComboBox.Name = "Color1ComboBox";
            this.Color1ComboBox.Size = new System.Drawing.Size(346, 31);
            this.Color1ComboBox.TabIndex = 22;
            // 
            // Color2ComboBox
            // 
            this.Color2ComboBox.FormattingEnabled = true;
            this.Color2ComboBox.Location = new System.Drawing.Point(143, 436);
            this.Color2ComboBox.Name = "Color2ComboBox";
            this.Color2ComboBox.Size = new System.Drawing.Size(346, 31);
            this.Color2ComboBox.TabIndex = 23;
            // 
            // FrmInsertText_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 609);
            this.Controls.Add(this.Color2ComboBox);
            this.Controls.Add(this.Color1ComboBox);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.StyleComboBox);
            this.Controls.Add(this.FontComboBox);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GradientCheckBox);
            this.Controls.Add(this.TxtY);
            this.Controls.Add(this.TxtText);
            this.Controls.Add(this.TxtX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmInsertText_Cheng3001";
            this.Text = "Insert Text Form";
            this.Load += new System.EventHandler(this.FrmInsertText_Cheng3001_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.TextBox TxtY;
        private System.Windows.Forms.CheckBox GradientCheckBox;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox FontComboBox;
        private System.Windows.Forms.ComboBox StyleComboBox;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.ComboBox Color1ComboBox;
        private System.Windows.Forms.ComboBox Color2ComboBox;
    }
}