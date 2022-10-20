namespace WinFormsAppForImageProcessing_Cheng3001
{
    partial class FrmInsertImage_Cheng3001
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtImage = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtY
            // 
            this.TxtY.Location = new System.Drawing.Point(160, 86);
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(346, 30);
            this.TxtY.TabIndex = 19;
            // 
            // TxtX
            // 
            this.TxtX.Location = new System.Drawing.Point(160, 38);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(346, 30);
            this.TxtX.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "X:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(283, 228);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(224, 45);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(57, 228);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(220, 45);
            this.BtnOK.TabIndex = 20;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Image:";
            // 
            // TxtImage
            // 
            this.TxtImage.Location = new System.Drawing.Point(160, 156);
            this.TxtImage.Name = "TxtImage";
            this.TxtImage.Size = new System.Drawing.Size(299, 30);
            this.TxtImage.TabIndex = 23;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(465, 156);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(42, 30);
            this.BtnSelect.TabIndex = 24;
            this.BtnSelect.Text = "...";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // FrmInsertImage_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 331);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.TxtImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtY);
            this.Controls.Add(this.TxtX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "FrmInsertImage_Cheng3001";
            this.Text = "Insert Image";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtImage;
        private System.Windows.Forms.Button BtnSelect;
    }
}