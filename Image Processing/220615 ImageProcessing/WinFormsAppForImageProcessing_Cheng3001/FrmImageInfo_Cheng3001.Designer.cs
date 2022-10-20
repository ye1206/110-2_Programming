namespace WinFormsAppForImageProcessing_Cheng3001
{
    partial class ImageInfo_Cheng3001
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblCreated = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.LblDimension = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.LblExtension = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image Extension:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Image Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image Dimension:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Image Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Image Created On:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(298, 35);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(18, 23);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "-";
            // 
            // LblCreated
            // 
            this.LblCreated.AutoSize = true;
            this.LblCreated.Location = new System.Drawing.Point(298, 382);
            this.LblCreated.Name = "LblCreated";
            this.LblCreated.Size = new System.Drawing.Size(18, 23);
            this.LblCreated.TabIndex = 7;
            this.LblCreated.Text = "-";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(298, 311);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(18, 23);
            this.LblSize.TabIndex = 8;
            this.LblSize.Text = "-";
            // 
            // LblDimension
            // 
            this.LblDimension.AutoSize = true;
            this.LblDimension.Location = new System.Drawing.Point(298, 241);
            this.LblDimension.Name = "LblDimension";
            this.LblDimension.Size = new System.Drawing.Size(18, 23);
            this.LblDimension.TabIndex = 9;
            this.LblDimension.Text = "-";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(298, 174);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(18, 23);
            this.LblLocation.TabIndex = 10;
            this.LblLocation.Text = "-";
            // 
            // LblExtension
            // 
            this.LblExtension.AutoSize = true;
            this.LblExtension.Location = new System.Drawing.Point(298, 108);
            this.LblExtension.Name = "LblExtension";
            this.LblExtension.Size = new System.Drawing.Size(18, 23);
            this.LblExtension.TabIndex = 11;
            this.LblExtension.Text = "-";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(146, 454);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(136, 49);
            this.BtnOK.TabIndex = 12;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // ImageInfo_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 529);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblExtension);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.LblDimension);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.LblCreated);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ImageInfo_Cheng3001";
            this.Text = "Image Info.";
            this.Load += new System.EventHandler(this.ImageInfo_Cheng3001_Load);
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
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblCreated;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label LblDimension;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.Label LblExtension;
        private System.Windows.Forms.Button BtnOK;
    }
}