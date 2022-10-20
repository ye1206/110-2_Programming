namespace WinFormsAppForImageProcessing_Cheng3001
{
    partial class FrmImageProcessing_Cheng3001
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
            this.ImageProcessingMS = new System.Windows.Forms.MenuStrip();
            this.FileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSUnderSave = new System.Windows.Forms.ToolStripSeparator();
            this.ExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageInfoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom50TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom100TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom150TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom200TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom300TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom400TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom500TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RedFilterTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenFilterTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueFilterTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UnderFilterTSS = new System.Windows.Forms.ToolStripSeparator();
            this.GammaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BrightnessTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayscaleTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.InvertTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ResizeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateNFilpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate90TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate180TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate270TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Under270TSS = new System.Windows.Forms.ToolStripSeparator();
            this.FlipHorizontalTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipVerticalTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CropTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TextTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ShapeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessingMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageProcessingMS
            // 
            this.ImageProcessingMS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ImageProcessingMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTSMI,
            this.EditTSMI,
            this.ViewTSMI,
            this.ColorTSMI,
            this.ImageTSMI,
            this.InsertTSMI});
            this.ImageProcessingMS.Location = new System.Drawing.Point(0, 0);
            this.ImageProcessingMS.Name = "ImageProcessingMS";
            this.ImageProcessingMS.Size = new System.Drawing.Size(1197, 32);
            this.ImageProcessingMS.TabIndex = 0;
            this.ImageProcessingMS.Text = "menuStrip1";
            // 
            // FileTSMI
            // 
            this.FileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTSMI,
            this.SaveTSMI,
            this.TSSUnderSave,
            this.ExitTSMI});
            this.FileTSMI.Name = "FileTSMI";
            this.FileTSMI.Size = new System.Drawing.Size(55, 28);
            this.FileTSMI.Text = "File";
            // 
            // OpenTSMI
            // 
            this.OpenTSMI.Name = "OpenTSMI";
            this.OpenTSMI.Size = new System.Drawing.Size(157, 34);
            this.OpenTSMI.Text = "&Open";
            this.OpenTSMI.Click += new System.EventHandler(this.OpenTSMI_Click);
            // 
            // SaveTSMI
            // 
            this.SaveTSMI.Name = "SaveTSMI";
            this.SaveTSMI.Size = new System.Drawing.Size(157, 34);
            this.SaveTSMI.Text = "Save";
            this.SaveTSMI.Click += new System.EventHandler(this.SaveTSMI_Click);
            // 
            // TSSUnderSave
            // 
            this.TSSUnderSave.Name = "TSSUnderSave";
            this.TSSUnderSave.Size = new System.Drawing.Size(154, 6);
            // 
            // ExitTSMI
            // 
            this.ExitTSMI.Name = "ExitTSMI";
            this.ExitTSMI.Size = new System.Drawing.Size(157, 34);
            this.ExitTSMI.Text = "Exit";
            this.ExitTSMI.Click += new System.EventHandler(this.ExitTSMI_Click);
            // 
            // EditTSMI
            // 
            this.EditTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoTSMI,
            this.ClearImageTSMI});
            this.EditTSMI.Name = "EditTSMI";
            this.EditTSMI.Size = new System.Drawing.Size(59, 28);
            this.EditTSMI.Text = "Edit";
            // 
            // UndoTSMI
            // 
            this.UndoTSMI.Name = "UndoTSMI";
            this.UndoTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoTSMI.Size = new System.Drawing.Size(221, 34);
            this.UndoTSMI.Text = "&Undo";
            this.UndoTSMI.Click += new System.EventHandler(this.UndoTSMI_Click);
            // 
            // ClearImageTSMI
            // 
            this.ClearImageTSMI.Name = "ClearImageTSMI";
            this.ClearImageTSMI.Size = new System.Drawing.Size(221, 34);
            this.ClearImageTSMI.Text = "Clear Image";
            this.ClearImageTSMI.Click += new System.EventHandler(this.ClearImageTSMI_Click);
            // 
            // ViewTSMI
            // 
            this.ViewTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImageInfoTSMI,
            this.ZoomTSMI});
            this.ViewTSMI.Name = "ViewTSMI";
            this.ViewTSMI.Size = new System.Drawing.Size(67, 28);
            this.ViewTSMI.Text = "View";
            // 
            // ImageInfoTSMI
            // 
            this.ImageInfoTSMI.Enabled = false;
            this.ImageInfoTSMI.Name = "ImageInfoTSMI";
            this.ImageInfoTSMI.Size = new System.Drawing.Size(270, 34);
            this.ImageInfoTSMI.Text = "Image Info";
            this.ImageInfoTSMI.Click += new System.EventHandler(this.ImageInfoTSMI_Click);
            // 
            // ZoomTSMI
            // 
            this.ZoomTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zoom50TSMI,
            this.Zoom100TSMI,
            this.Zoom150TSMI,
            this.Zoom200TSMI,
            this.Zoom300TSMI,
            this.Zoom400TSMI,
            this.Zoom500TSMI});
            this.ZoomTSMI.Name = "ZoomTSMI";
            this.ZoomTSMI.Size = new System.Drawing.Size(270, 34);
            this.ZoomTSMI.Text = "Zoom";
            // 
            // Zoom50TSMI
            // 
            this.Zoom50TSMI.Name = "Zoom50TSMI";
            this.Zoom50TSMI.Size = new System.Drawing.Size(156, 34);
            this.Zoom50TSMI.Text = "50%";
            this.Zoom50TSMI.Click += new System.EventHandler(this.Zoom50TSMI_Click);
            // 
            // Zoom100TSMI
            // 
            this.Zoom100TSMI.Name = "Zoom100TSMI";
            this.Zoom100TSMI.Size = new System.Drawing.Size(156, 34);
            this.Zoom100TSMI.Text = "100%";
            this.Zoom100TSMI.Click += new System.EventHandler(this.Zoom100TSMI_Click);
            // 
            // Zoom150TSMI
            // 
            this.Zoom150TSMI.Name = "Zoom150TSMI";
            this.Zoom150TSMI.Size = new System.Drawing.Size(156, 34);
            this.Zoom150TSMI.Text = "150%";
            this.Zoom150TSMI.Click += new System.EventHandler(this.Zoom150TSMI_Click);
            // 
            // Zoom200TSMI
            // 
            this.Zoom200TSMI.Name = "Zoom200TSMI";
            this.Zoom200TSMI.Size = new System.Drawing.Size(156, 34);
            this.Zoom200TSMI.Text = "200%";
            this.Zoom200TSMI.Click += new System.EventHandler(this.Zoom200TSMI_Click);
            // 
            // Zoom300TSMI
            // 
            this.Zoom300TSMI.Name = "Zoom300TSMI";
            this.Zoom300TSMI.Size = new System.Drawing.Size(156, 34);
            this.Zoom300TSMI.Text = "300%";
            this.Zoom300TSMI.Click += new System.EventHandler(this.Zoom300TSMI_Click);
            // 
            // Zoom400TSMI
            // 
            this.Zoom400TSMI.Name = "Zoom400TSMI";
            this.Zoom400TSMI.Size = new System.Drawing.Size(156, 34);
            this.Zoom400TSMI.Text = "400%";
            this.Zoom400TSMI.Click += new System.EventHandler(this.Zoom400TSMI_Click);
            // 
            // Zoom500TSMI
            // 
            this.Zoom500TSMI.Name = "Zoom500TSMI";
            this.Zoom500TSMI.Size = new System.Drawing.Size(156, 34);
            this.Zoom500TSMI.Text = "500%";
            this.Zoom500TSMI.Click += new System.EventHandler(this.Zoom500TSMI_Click);
            // 
            // ColorTSMI
            // 
            this.ColorTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterTSMI,
            this.UnderFilterTSS,
            this.GammaTSMI,
            this.BrightnessTSMI,
            this.ContrastTSMI,
            this.GrayscaleTSMI,
            this.InvertTSMI});
            this.ColorTSMI.Name = "ColorTSMI";
            this.ColorTSMI.Size = new System.Drawing.Size(72, 28);
            this.ColorTSMI.Text = "Color";
            // 
            // FilterTSMI
            // 
            this.FilterTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedFilterTSMI,
            this.GreenFilterTSMI,
            this.BlueFilterTSMI});
            this.FilterTSMI.Name = "FilterTSMI";
            this.FilterTSMI.Size = new System.Drawing.Size(199, 34);
            this.FilterTSMI.Text = "Filter";
            // 
            // RedFilterTSMI
            // 
            this.RedFilterTSMI.Name = "RedFilterTSMI";
            this.RedFilterTSMI.Size = new System.Drawing.Size(209, 34);
            this.RedFilterTSMI.Text = "Red Filter";
            this.RedFilterTSMI.Click += new System.EventHandler(this.RedFilterTSMI_Click);
            // 
            // GreenFilterTSMI
            // 
            this.GreenFilterTSMI.Name = "GreenFilterTSMI";
            this.GreenFilterTSMI.Size = new System.Drawing.Size(209, 34);
            this.GreenFilterTSMI.Text = "Green Filter";
            this.GreenFilterTSMI.Click += new System.EventHandler(this.GreenFilterTSMI_Click);
            // 
            // BlueFilterTSMI
            // 
            this.BlueFilterTSMI.Name = "BlueFilterTSMI";
            this.BlueFilterTSMI.Size = new System.Drawing.Size(209, 34);
            this.BlueFilterTSMI.Text = "Blue Filter";
            this.BlueFilterTSMI.Click += new System.EventHandler(this.BlueFilterTSMI_Click);
            // 
            // UnderFilterTSS
            // 
            this.UnderFilterTSS.Name = "UnderFilterTSS";
            this.UnderFilterTSS.Size = new System.Drawing.Size(196, 6);
            // 
            // GammaTSMI
            // 
            this.GammaTSMI.Name = "GammaTSMI";
            this.GammaTSMI.Size = new System.Drawing.Size(199, 34);
            this.GammaTSMI.Text = "Gamma";
            this.GammaTSMI.Click += new System.EventHandler(this.GammaTSMI_Click);
            // 
            // BrightnessTSMI
            // 
            this.BrightnessTSMI.Name = "BrightnessTSMI";
            this.BrightnessTSMI.Size = new System.Drawing.Size(199, 34);
            this.BrightnessTSMI.Text = "Brightness";
            this.BrightnessTSMI.Click += new System.EventHandler(this.BrightnessTSMI_Click);
            // 
            // ContrastTSMI
            // 
            this.ContrastTSMI.Name = "ContrastTSMI";
            this.ContrastTSMI.Size = new System.Drawing.Size(199, 34);
            this.ContrastTSMI.Text = "Contrast";
            this.ContrastTSMI.Click += new System.EventHandler(this.ContrastTSMI_Click);
            // 
            // GrayscaleTSMI
            // 
            this.GrayscaleTSMI.Name = "GrayscaleTSMI";
            this.GrayscaleTSMI.Size = new System.Drawing.Size(199, 34);
            this.GrayscaleTSMI.Text = "Grayscale";
            this.GrayscaleTSMI.Click += new System.EventHandler(this.GrayscaleTSMI_Click);
            // 
            // InvertTSMI
            // 
            this.InvertTSMI.Name = "InvertTSMI";
            this.InvertTSMI.Size = new System.Drawing.Size(199, 34);
            this.InvertTSMI.Text = "Invert";
            this.InvertTSMI.Click += new System.EventHandler(this.InvertTSMI_Click);
            // 
            // ImageTSMI
            // 
            this.ImageTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResizeTSMI,
            this.RotateNFilpTSMI,
            this.CropTSMI});
            this.ImageTSMI.Name = "ImageTSMI";
            this.ImageTSMI.Size = new System.Drawing.Size(79, 28);
            this.ImageTSMI.Text = "Image";
            // 
            // ResizeTSMI
            // 
            this.ResizeTSMI.Name = "ResizeTSMI";
            this.ResizeTSMI.Size = new System.Drawing.Size(239, 34);
            this.ResizeTSMI.Text = "Resize";
            this.ResizeTSMI.Click += new System.EventHandler(this.ResizeTSMI_Click);
            // 
            // RotateNFilpTSMI
            // 
            this.RotateNFilpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotate90TSMI,
            this.Rotate180TSMI,
            this.Rotate270TSMI,
            this.Under270TSS,
            this.FlipHorizontalTSMI,
            this.FlipVerticalTSMI});
            this.RotateNFilpTSMI.Name = "RotateNFilpTSMI";
            this.RotateNFilpTSMI.Size = new System.Drawing.Size(239, 34);
            this.RotateNFilpTSMI.Text = "Rotate and Flip";
            // 
            // Rotate90TSMI
            // 
            this.Rotate90TSMI.Name = "Rotate90TSMI";
            this.Rotate90TSMI.Size = new System.Drawing.Size(235, 34);
            this.Rotate90TSMI.Text = "Rotate 90°";
            this.Rotate90TSMI.Click += new System.EventHandler(this.Rotate90TSMI_Click);
            // 
            // Rotate180TSMI
            // 
            this.Rotate180TSMI.Name = "Rotate180TSMI";
            this.Rotate180TSMI.Size = new System.Drawing.Size(235, 34);
            this.Rotate180TSMI.Text = "Rotate 180°";
            this.Rotate180TSMI.Click += new System.EventHandler(this.Rotate180TSMI_Click);
            // 
            // Rotate270TSMI
            // 
            this.Rotate270TSMI.Name = "Rotate270TSMI";
            this.Rotate270TSMI.Size = new System.Drawing.Size(235, 34);
            this.Rotate270TSMI.Text = "Rotate 270°";
            this.Rotate270TSMI.Click += new System.EventHandler(this.Rotate270TSMI_Click);
            // 
            // Under270TSS
            // 
            this.Under270TSS.Name = "Under270TSS";
            this.Under270TSS.Size = new System.Drawing.Size(232, 6);
            // 
            // FlipHorizontalTSMI
            // 
            this.FlipHorizontalTSMI.Name = "FlipHorizontalTSMI";
            this.FlipHorizontalTSMI.Size = new System.Drawing.Size(235, 34);
            this.FlipHorizontalTSMI.Text = "Flip Horizontal";
            this.FlipHorizontalTSMI.Click += new System.EventHandler(this.FlipHorizontalTSMI_Click);
            // 
            // FlipVerticalTSMI
            // 
            this.FlipVerticalTSMI.Name = "FlipVerticalTSMI";
            this.FlipVerticalTSMI.Size = new System.Drawing.Size(235, 34);
            this.FlipVerticalTSMI.Text = "Flip Vertical";
            this.FlipVerticalTSMI.Click += new System.EventHandler(this.FlipVerticalTSMI_Click);
            // 
            // CropTSMI
            // 
            this.CropTSMI.Name = "CropTSMI";
            this.CropTSMI.Size = new System.Drawing.Size(239, 34);
            this.CropTSMI.Text = "Crop";
            this.CropTSMI.Click += new System.EventHandler(this.CropTSMI_Click);
            // 
            // InsertTSMI
            // 
            this.InsertTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextTSMI,
            this.InsertImageTSMI,
            this.ShapeTSMI});
            this.InsertTSMI.Name = "InsertTSMI";
            this.InsertTSMI.Size = new System.Drawing.Size(74, 28);
            this.InsertTSMI.Text = "Insert";
            // 
            // TextTSMI
            // 
            this.TextTSMI.Name = "TextTSMI";
            this.TextTSMI.Size = new System.Drawing.Size(163, 34);
            this.TextTSMI.Text = "Text";
            this.TextTSMI.Click += new System.EventHandler(this.TextTSMI_Click);
            // 
            // InsertImageTSMI
            // 
            this.InsertImageTSMI.Name = "InsertImageTSMI";
            this.InsertImageTSMI.Size = new System.Drawing.Size(163, 34);
            this.InsertImageTSMI.Text = "Image";
            this.InsertImageTSMI.Click += new System.EventHandler(this.InsertImageTSMI_Click);
            // 
            // ShapeTSMI
            // 
            this.ShapeTSMI.Name = "ShapeTSMI";
            this.ShapeTSMI.Size = new System.Drawing.Size(163, 34);
            this.ShapeTSMI.Text = "Shape";
            this.ShapeTSMI.Click += new System.EventHandler(this.ShapeTSMI_Click);
            // 
            // FrmImageProcessing_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1197, 625);
            this.Controls.Add(this.ImageProcessingMS);
            this.MainMenuStrip = this.ImageProcessingMS;
            this.Name = "FrmImageProcessing_Cheng3001";
            this.Text = "Image Processing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageProcessing_Paint);
            this.ImageProcessingMS.ResumeLayout(false);
            this.ImageProcessingMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ImageProcessingMS;
        private System.Windows.Forms.ToolStripMenuItem FileTSMI;
        private System.Windows.Forms.ToolStripMenuItem OpenTSMI;
        private System.Windows.Forms.ToolStripMenuItem SaveTSMI;
        private System.Windows.Forms.ToolStripSeparator TSSUnderSave;
        private System.Windows.Forms.ToolStripMenuItem ExitTSMI;
        private System.Windows.Forms.ToolStripMenuItem EditTSMI;
        private System.Windows.Forms.ToolStripMenuItem UndoTSMI;
        private System.Windows.Forms.ToolStripMenuItem ClearImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem ColorTSMI;
        private System.Windows.Forms.ToolStripMenuItem FilterTSMI;
        private System.Windows.Forms.ToolStripMenuItem RedFilterTSMI;
        private System.Windows.Forms.ToolStripMenuItem GreenFilterTSMI;
        private System.Windows.Forms.ToolStripMenuItem BlueFilterTSMI;
        private System.Windows.Forms.ToolStripMenuItem GammaTSMI;
        private System.Windows.Forms.ToolStripMenuItem ViewTSMI;
        private System.Windows.Forms.ToolStripMenuItem ImageInfoTSMI;
        private System.Windows.Forms.ToolStripSeparator UnderFilterTSS;
        private System.Windows.Forms.ToolStripMenuItem ZoomTSMI;
        private System.Windows.Forms.ToolStripMenuItem Zoom100TSMI;
        private System.Windows.Forms.ToolStripMenuItem Zoom50TSMI;
        private System.Windows.Forms.ToolStripMenuItem Zoom150TSMI;
        private System.Windows.Forms.ToolStripMenuItem Zoom200TSMI;
        private System.Windows.Forms.ToolStripMenuItem Zoom300TSMI;
        private System.Windows.Forms.ToolStripMenuItem Zoom400TSMI;
        private System.Windows.Forms.ToolStripMenuItem Zoom500TSMI;
        private System.Windows.Forms.ToolStripMenuItem BrightnessTSMI;
        private System.Windows.Forms.ToolStripMenuItem ContrastTSMI;
        private System.Windows.Forms.ToolStripMenuItem GrayscaleTSMI;
        private System.Windows.Forms.ToolStripMenuItem InvertTSMI;
        private System.Windows.Forms.ToolStripMenuItem ImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem ResizeTSMI;
        private System.Windows.Forms.ToolStripMenuItem RotateNFilpTSMI;
        private System.Windows.Forms.ToolStripMenuItem Rotate90TSMI;
        private System.Windows.Forms.ToolStripMenuItem Rotate180TSMI;
        private System.Windows.Forms.ToolStripMenuItem Rotate270TSMI;
        private System.Windows.Forms.ToolStripSeparator Under270TSS;
        private System.Windows.Forms.ToolStripMenuItem FlipHorizontalTSMI;
        private System.Windows.Forms.ToolStripMenuItem FlipVerticalTSMI;
        private System.Windows.Forms.ToolStripMenuItem CropTSMI;
        private System.Windows.Forms.ToolStripMenuItem InsertTSMI;
        private System.Windows.Forms.ToolStripMenuItem TextTSMI;
        private System.Windows.Forms.ToolStripMenuItem InsertImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem ShapeTSMI;
    }
}
