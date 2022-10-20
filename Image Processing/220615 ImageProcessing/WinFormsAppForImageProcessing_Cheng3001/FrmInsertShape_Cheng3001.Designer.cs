namespace WinFormsAppForImageProcessing_Cheng3001
{
    partial class FrmInsertShape_Cheng3001
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
            this.TxtY = new System.Windows.Forms.TextBox();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShapeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtY
            // 
            this.TxtY.Location = new System.Drawing.Point(154, 81);
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(157, 30);
            this.TxtY.TabIndex = 19;
            // 
            // TxtX
            // 
            this.TxtX.Location = new System.Drawing.Point(154, 33);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(157, 30);
            this.TxtX.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "X:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(187, 335);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(124, 51);
            this.BtnCancel.TabIndex = 31;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(51, 335);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(124, 51);
            this.BtnOK.TabIndex = 30;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(154, 174);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(157, 30);
            this.TxtHeight.TabIndex = 29;
            // 
            // TxtWidth
            // 
            this.TxtWidth.Location = new System.Drawing.Point(154, 125);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(157, 30);
            this.TxtWidth.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Height:";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(154, 285);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(157, 31);
            this.ColorComboBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Color :";
            // 
            // ShapeComboBox
            // 
            this.ShapeComboBox.FormattingEnabled = true;
            this.ShapeComboBox.Location = new System.Drawing.Point(154, 222);
            this.ShapeComboBox.Name = "ShapeComboBox";
            this.ShapeComboBox.Size = new System.Drawing.Size(157, 31);
            this.ShapeComboBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Shape:";
            // 
            // FrmInsertShape_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 413);
            this.Controls.Add(this.ShapeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.TxtWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtY);
            this.Controls.Add(this.TxtX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "FrmInsertShape_Cheng3001";
            this.Text = "Insert Shape Form";
            this.Load += new System.EventHandler(this.FrmInsertShape_Cheng3001_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtY;
        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ShapeComboBox;
        private System.Windows.Forms.Label label5;
    }
}