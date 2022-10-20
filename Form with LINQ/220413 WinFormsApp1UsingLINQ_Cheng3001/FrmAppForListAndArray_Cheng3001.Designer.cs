namespace WinFormsApp1UsingLINQ_Cheng3001_220413
{
    partial class FrmAppForListAndArray_Cheng3001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppForListAndArray_Cheng3001));
            this.ListBoxTestScore = new System.Windows.Forms.ListBox();
            this.ListBoxOrderBy = new System.Windows.Forms.ListBox();
            this.BtnGetFileAndCal = new System.Windows.Forms.Button();
            this.BtnAscend = new System.Windows.Forms.Button();
            this.BtnDescend = new System.Windows.Forms.Button();
            this.LblAverage = new System.Windows.Forms.Label();
            this.LblScoreLowest = new System.Windows.Forms.Label();
            this.LblHigherNum = new System.Windows.Forms.Label();
            this.LblTotalNumber = new System.Windows.Forms.Label();
            this.LblScoreHighst = new System.Windows.Forms.Label();
            this.LblLowerNum = new System.Windows.Forms.Label();
            this.LblScoreAverage = new System.Windows.Forms.Label();
            this.LblStudentNumber = new System.Windows.Forms.Label();
            this.LblHigherAveNumber = new System.Windows.Forms.Label();
            this.LblScoreMin = new System.Windows.Forms.Label();
            this.LblScoreMax = new System.Windows.Forms.Label();
            this.LblLowerAveNumber = new System.Windows.Forms.Label();
            this.toolStripQueryBy = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnDDP_Query = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemArray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemList = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExit = new System.Windows.Forms.Button();
            this.toolStripQueryBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxTestScore
            // 
            this.ListBoxTestScore.FormattingEnabled = true;
            this.ListBoxTestScore.ItemHeight = 23;
            this.ListBoxTestScore.Location = new System.Drawing.Point(43, 103);
            this.ListBoxTestScore.Name = "ListBoxTestScore";
            this.ListBoxTestScore.Size = new System.Drawing.Size(278, 395);
            this.ListBoxTestScore.TabIndex = 1;
            // 
            // ListBoxOrderBy
            // 
            this.ListBoxOrderBy.FormattingEnabled = true;
            this.ListBoxOrderBy.ItemHeight = 23;
            this.ListBoxOrderBy.Location = new System.Drawing.Point(370, 103);
            this.ListBoxOrderBy.Name = "ListBoxOrderBy";
            this.ListBoxOrderBy.Size = new System.Drawing.Size(278, 395);
            this.ListBoxOrderBy.TabIndex = 2;
            // 
            // BtnGetFileAndCal
            // 
            this.BtnGetFileAndCal.Location = new System.Drawing.Point(43, 44);
            this.BtnGetFileAndCal.Name = "BtnGetFileAndCal";
            this.BtnGetFileAndCal.Size = new System.Drawing.Size(278, 53);
            this.BtnGetFileAndCal.TabIndex = 3;
            this.BtnGetFileAndCal.Text = "Read Score";
            this.BtnGetFileAndCal.UseVisualStyleBackColor = true;
            this.BtnGetFileAndCal.Visible = false;
            this.BtnGetFileAndCal.Click += new System.EventHandler(this.BtnGetFileAndCal_Click);
            // 
            // BtnAscend
            // 
            this.BtnAscend.Enabled = false;
            this.BtnAscend.Location = new System.Drawing.Point(370, 44);
            this.BtnAscend.Name = "BtnAscend";
            this.BtnAscend.Size = new System.Drawing.Size(136, 53);
            this.BtnAscend.TabIndex = 4;
            this.BtnAscend.Text = "Ascending";
            this.BtnAscend.UseVisualStyleBackColor = true;
            this.BtnAscend.Click += new System.EventHandler(this.BtnAscend_Click);
            // 
            // BtnDescend
            // 
            this.BtnDescend.Enabled = false;
            this.BtnDescend.Location = new System.Drawing.Point(512, 44);
            this.BtnDescend.Name = "BtnDescend";
            this.BtnDescend.Size = new System.Drawing.Size(136, 53);
            this.BtnDescend.TabIndex = 5;
            this.BtnDescend.Text = "Descending";
            this.BtnDescend.UseVisualStyleBackColor = true;
            this.BtnDescend.Click += new System.EventHandler(this.BtnDescend_Click);
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Location = new System.Drawing.Point(55, 529);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(86, 23);
            this.LblAverage.TabIndex = 6;
            this.LblAverage.Text = "平均成績:";
            this.LblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblScoreLowest
            // 
            this.LblScoreLowest.AutoSize = true;
            this.LblScoreLowest.Location = new System.Drawing.Point(388, 529);
            this.LblScoreLowest.Name = "LblScoreLowest";
            this.LblScoreLowest.Size = new System.Drawing.Size(86, 23);
            this.LblScoreLowest.TabIndex = 7;
            this.LblScoreLowest.Text = "最低成績:";
            this.LblScoreLowest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHigherNum
            // 
            this.LblHigherNum.AutoSize = true;
            this.LblHigherNum.Location = new System.Drawing.Point(55, 644);
            this.LblHigherNum.Name = "LblHigherNum";
            this.LblHigherNum.Size = new System.Drawing.Size(140, 23);
            this.LblHigherNum.TabIndex = 8;
            this.LblHigherNum.Text = "高於平均之人數:";
            this.LblHigherNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotalNumber
            // 
            this.LblTotalNumber.AutoSize = true;
            this.LblTotalNumber.Location = new System.Drawing.Point(55, 586);
            this.LblTotalNumber.Name = "LblTotalNumber";
            this.LblTotalNumber.Size = new System.Drawing.Size(68, 23);
            this.LblTotalNumber.TabIndex = 9;
            this.LblTotalNumber.Text = "總人數:";
            this.LblTotalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblScoreHighst
            // 
            this.LblScoreHighst.AutoSize = true;
            this.LblScoreHighst.Location = new System.Drawing.Point(388, 586);
            this.LblScoreHighst.Name = "LblScoreHighst";
            this.LblScoreHighst.Size = new System.Drawing.Size(86, 23);
            this.LblScoreHighst.TabIndex = 10;
            this.LblScoreHighst.Text = "最高成績:";
            this.LblScoreHighst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLowerNum
            // 
            this.LblLowerNum.AutoSize = true;
            this.LblLowerNum.Location = new System.Drawing.Point(388, 648);
            this.LblLowerNum.Name = "LblLowerNum";
            this.LblLowerNum.Size = new System.Drawing.Size(176, 23);
            this.LblLowerNum.TabIndex = 11;
            this.LblLowerNum.Text = "低於平均之人數成績:";
            this.LblLowerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblScoreAverage
            // 
            this.LblScoreAverage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblScoreAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblScoreAverage.Location = new System.Drawing.Point(156, 522);
            this.LblScoreAverage.Name = "LblScoreAverage";
            this.LblScoreAverage.Size = new System.Drawing.Size(106, 43);
            this.LblScoreAverage.TabIndex = 18;
            this.LblScoreAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblStudentNumber
            // 
            this.LblStudentNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblStudentNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblStudentNumber.Location = new System.Drawing.Point(156, 583);
            this.LblStudentNumber.Name = "LblStudentNumber";
            this.LblStudentNumber.Size = new System.Drawing.Size(106, 43);
            this.LblStudentNumber.TabIndex = 19;
            this.LblStudentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHigherAveNumber
            // 
            this.LblHigherAveNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblHigherAveNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHigherAveNumber.Location = new System.Drawing.Point(201, 638);
            this.LblHigherAveNumber.Name = "LblHigherAveNumber";
            this.LblHigherAveNumber.Size = new System.Drawing.Size(106, 43);
            this.LblHigherAveNumber.TabIndex = 20;
            this.LblHigherAveNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblScoreMin
            // 
            this.LblScoreMin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblScoreMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblScoreMin.Location = new System.Drawing.Point(497, 519);
            this.LblScoreMin.Name = "LblScoreMin";
            this.LblScoreMin.Size = new System.Drawing.Size(106, 43);
            this.LblScoreMin.TabIndex = 21;
            this.LblScoreMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblScoreMax
            // 
            this.LblScoreMax.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblScoreMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblScoreMax.Location = new System.Drawing.Point(497, 583);
            this.LblScoreMax.Name = "LblScoreMax";
            this.LblScoreMax.Size = new System.Drawing.Size(106, 43);
            this.LblScoreMax.TabIndex = 22;
            this.LblScoreMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLowerAveNumber
            // 
            this.LblLowerAveNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblLowerAveNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLowerAveNumber.Location = new System.Drawing.Point(570, 638);
            this.LblLowerAveNumber.Name = "LblLowerAveNumber";
            this.LblLowerAveNumber.Size = new System.Drawing.Size(106, 43);
            this.LblLowerAveNumber.TabIndex = 23;
            this.LblLowerAveNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripQueryBy
            // 
            this.toolStripQueryBy.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripQueryBy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnDDP_Query});
            this.toolStripQueryBy.Location = new System.Drawing.Point(0, 0);
            this.toolStripQueryBy.Name = "toolStripQueryBy";
            this.toolStripQueryBy.Size = new System.Drawing.Size(744, 32);
            this.toolStripQueryBy.TabIndex = 24;
            this.toolStripQueryBy.Text = "Query_By";
            // 
            // toolStripBtnDDP_Query
            // 
            this.toolStripBtnDDP_Query.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnDDP_Query.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemArray,
            this.toolStripMenuItemList});
            this.toolStripBtnDDP_Query.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDDP_Query.Image")));
            this.toolStripBtnDDP_Query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDDP_Query.Name = "toolStripBtnDDP_Query";
            this.toolStripBtnDDP_Query.Size = new System.Drawing.Size(108, 27);
            this.toolStripBtnDDP_Query.Text = "Query_By";
            // 
            // toolStripMenuItemArray
            // 
            this.toolStripMenuItemArray.Name = "toolStripMenuItemArray";
            this.toolStripMenuItemArray.Size = new System.Drawing.Size(155, 34);
            this.toolStripMenuItemArray.Text = "Array";
            this.toolStripMenuItemArray.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // toolStripMenuItemList
            // 
            this.toolStripMenuItemList.Name = "toolStripMenuItemList";
            this.toolStripMenuItemList.Size = new System.Drawing.Size(155, 34);
            this.toolStripMenuItemList.Text = "List";
            this.toolStripMenuItemList.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(27, 697);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(122, 53);
            this.BtnExit.TabIndex = 25;
            this.BtnExit.Text = "離開";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmAppForListAndArray_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 762);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.toolStripQueryBy);
            this.Controls.Add(this.LblLowerAveNumber);
            this.Controls.Add(this.LblScoreMax);
            this.Controls.Add(this.LblScoreMin);
            this.Controls.Add(this.LblHigherAveNumber);
            this.Controls.Add(this.LblStudentNumber);
            this.Controls.Add(this.LblScoreAverage);
            this.Controls.Add(this.LblLowerNum);
            this.Controls.Add(this.LblScoreHighst);
            this.Controls.Add(this.LblTotalNumber);
            this.Controls.Add(this.LblHigherNum);
            this.Controls.Add(this.LblScoreLowest);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.BtnDescend);
            this.Controls.Add(this.BtnAscend);
            this.Controls.Add(this.BtnGetFileAndCal);
            this.Controls.Add(this.ListBoxOrderBy);
            this.Controls.Add(this.ListBoxTestScore);
            this.Name = "FrmAppForListAndArray_Cheng3001";
            this.Text = "Demo Using LINQ Or Array";
            this.toolStripQueryBy.ResumeLayout(false);
            this.toolStripQueryBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxTestScore;
        private System.Windows.Forms.ListBox ListBoxOrderBy;
        private System.Windows.Forms.Button BtnGetFileAndCal;
        private System.Windows.Forms.Button BtnAscend;
        private System.Windows.Forms.Button BtnDescend;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.Label LblScoreLowest;
        private System.Windows.Forms.Label LblHigherNum;
        private System.Windows.Forms.Label LblTotalNumber;
        private System.Windows.Forms.Label LblScoreHighst;
        private System.Windows.Forms.Label LblLowerNum;
        private System.Windows.Forms.Label LblScoreAverage;
        private System.Windows.Forms.Label LblStudentNumber;
        private System.Windows.Forms.Label LblHigherAveNumber;
        private System.Windows.Forms.Label LblScoreMin;
        private System.Windows.Forms.Label LblScoreMax;
        private System.Windows.Forms.Label LblLowerAveNumber;
        private System.Windows.Forms.ToolStrip toolStripQueryBy;
        private System.Windows.Forms.ToolStripDropDownButton toolStripBtnDDP_Query;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemList;
        private System.Windows.Forms.Button BtnExit;
    }
}
