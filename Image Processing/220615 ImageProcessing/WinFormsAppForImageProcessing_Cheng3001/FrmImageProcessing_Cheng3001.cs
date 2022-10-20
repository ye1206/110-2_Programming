using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class FrmImageProcessing_Cheng3001 : Form
    {
        OpenFileDialog oDlg;
        SaveFileDialog sDlg;
        double zoomFactor = 1.0;
        private ToolStripMenuItem cZoom;
        ImageHandler_Cheng3001 imageHandler = new ImageHandler_Cheng3001();

        public FrmImageProcessing_Cheng3001()
        {
            InitializeComponent();
            oDlg = new OpenFileDialog(); // Open Dialog Initialization
            oDlg.RestoreDirectory = true;
            oDlg.InitialDirectory = "C:\\";
            oDlg.FilterIndex = 1;
            oDlg.Filter = "jpg Files (*.jpg)|*.jpg|gif Files (*.gif)|*.gif|png Files (*.png)|*.png |bmp Files (*.bmp)|*.bmp";
            /*************************/
            sDlg = new SaveFileDialog(); // Save Dialog Initialization
            sDlg.RestoreDirectory = true;
            sDlg.InitialDirectory = "C:\\";
            sDlg.FilterIndex = 1;
            sDlg.Filter = "jpg Files (*.jpg)|*.jpg|gif Files (*.gif)|*.gif|png Files (*.png)|*.png |bmp Files (*.bmp)|*.bmp";
            /*************************/
            cZoom = Zoom100TSMI; // Current Zoom Percentage = 100%
        }

        private void ImageProcessing_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(imageHandler.CurrentBitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor)));
        }

        #region File
        private void OpenTSMI_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == oDlg.ShowDialog())
            {
                imageHandler.CurrentBitmap = (Bitmap)Bitmap.FromFile(oDlg.FileName);
                imageHandler.BitmapPath = oDlg.FileName;
                this.AutoScroll = true;
                this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
                this.Invalidate();
                ImageInfoTSMI.Enabled = true;
                ImageInfo_Cheng3001 imgInfo = new ImageInfo_Cheng3001(imageHandler);
                imgInfo.Show();
            }
        } //end of OpenTSMI_Click

        private void SaveTSMI_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == sDlg.ShowDialog())
            {
                imageHandler.SaveBitmap(sDlg.FileName);
            }
        } //end of SaveTSMI_Click

        private void ExitTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        } //end of ExitTSMI_Click
        #endregion File

        #region Edit
        private void UndoTSMI_Click(object sender, EventArgs e)
        {
            imageHandler.ResetBitmap();
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of UndoTSMI_Click

        private void ClearImageTSMI_Click(object sender, EventArgs e)
        {
            imageHandler.RestorePrevious();
            imageHandler.ClearImage();
            this.Invalidate();
        } //end of ClearImageTSMI_Click
        #endregion Edit

        #region View
        private void ImageInfoTSMI_Click(object sender, EventArgs e)
        {
            imageHandler.RestorePrevious();
            imageHandler.ClearImage();
            this.Invalidate();
        } //end of ImageInfoTSMI_Click

        private void Zoom50TSMI_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.5;
            cZoom.Checked = false;
            Zoom100TSMI.Checked = true;
            cZoom = Zoom50TSMI;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Zoom50TSMI_Click

        private void Zoom100TSMI_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.0;
            cZoom.Checked = false;
            Zoom100TSMI.Checked = true;
            cZoom = Zoom100TSMI;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Zoom100TSMI_Click

        private void Zoom150TSMI_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.5;
            cZoom.Checked = false;
            Zoom150TSMI.Checked = true;
            cZoom = Zoom150TSMI;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Zoom150TSMI_Click

        private void Zoom200TSMI_Click(object sender, EventArgs e)
        {
            zoomFactor = 2.0;
            cZoom.Checked = false;
            Zoom200TSMI.Checked = true;
            cZoom = Zoom200TSMI;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Zoom200TSMI_Click

        private void Zoom300TSMI_Click(object sender, EventArgs e)
        {
            zoomFactor = 3.0;
            cZoom.Checked = false;
            Zoom300TSMI.Checked = true;
            cZoom = Zoom300TSMI;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Zoom300TSMI_Click

        private void Zoom400TSMI_Click(object sender, EventArgs e)
        {
            zoomFactor = 4.0;
            cZoom.Checked = false;
            Zoom400TSMI.Checked = true;
            cZoom = Zoom400TSMI;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Zoom400TSMI_Click

        private void Zoom500TSMI_Click(object sender, EventArgs e)
        {
            zoomFactor = 5.0;
            cZoom.Checked = false;
            Zoom500TSMI.Checked = true;
            cZoom = Zoom500TSMI;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Zoom500TSMI_Click
        #endregion View

        #region Color
        #region Filter
        private void RedFilterTSMI_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            imageHandler.RestorePrevious();
            imageHandler.SetColorFilter(ImageHandler_Cheng3001.ColorFilterTypes.Red);
            this.Invalidate();
            this.Cursor = Cursors.Default;
        } //end of RedFilterTSMI_Click

        private void GreenFilterTSMI_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            imageHandler.RestorePrevious();
            imageHandler.SetColorFilter(ImageHandler_Cheng3001.ColorFilterTypes.Green);
            this.Invalidate();
            this.Cursor = Cursors.Default;
        } //end of GreenFilterTSMI_Click

        private void BlueFilterTSMI_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            imageHandler.RestorePrevious();
            imageHandler.SetColorFilter(ImageHandler_Cheng3001.ColorFilterTypes.Blue);
            this.Invalidate();
            this.Cursor = Cursors.Default;
        } //end of BlueFilterTSMI_Click
        #endregion Filter

        private void GammaTSMI_Click(object sender, EventArgs e)
        {
            frmGamma_Cheng3001 gFrm = new frmGamma_Cheng3001();
            gFrm.RedComponent = gFrm.GreenComponent = gFrm.BlueComponent = 0;
            if (gFrm.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                imageHandler.RestorePrevious();
                imageHandler.SetGamma(gFrm.RedComponent, gFrm.GreenComponent, gFrm.BlueComponent);
                this.Invalidate();
                this.Cursor = Cursors.Default;
            }
        } //end of GammaTSMI_Click

        private void BrightnessTSMI_Click(object sender, EventArgs e)
        {
            FrmBrightness_Cheng3001 bFrm = new FrmBrightness_Cheng3001();
            bFrm.BrightnessValue = 0;
            if (bFrm.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                imageHandler.RestorePrevious();
                imageHandler.SetBrightness(bFrm.BrightnessValue);
                this.Invalidate();
                this.Cursor = Cursors.Default;
            }
        } //end of BrightnessTSMI_Click

        private void ContrastTSMI_Click(object sender, EventArgs e) //對比
        {
            FrmContrast_Cheng3001 cFrm = new FrmContrast_Cheng3001();
            cFrm.ContrastValue = 0;
            if (cFrm.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                imageHandler.RestorePrevious();
                imageHandler.SetContrast(cFrm.ContrastValue);
                this.Invalidate();
                this.Cursor = Cursors.Default;
            }
        } //end of ContrastTSMI_Click

        private void GrayscaleTSMI_Click(object sender, EventArgs e) //灰階
        {
            this.Cursor = Cursors.WaitCursor;
            imageHandler.RestorePrevious();
            imageHandler.SetGrayscale();
            this.Invalidate();
            this.Cursor = Cursors.Default;
        } //end of GrayscaleTSMI_Click

        private void InvertTSMI_Click(object sender, EventArgs e) //色彩反轉
        {
            this.Cursor = Cursors.WaitCursor;
            imageHandler.RestorePrevious();
            imageHandler.SetInvert();
            this.Invalidate();
            this.Cursor = Cursors.Default;
        }
        #endregion Color

        #region Image
        private void ResizeTSMI_Click(object sender, EventArgs e)
        {
            FrmResize_Cheng3001 rFrm = new FrmResize_Cheng3001();
            rFrm.NewWidth = imageHandler.CurrentBitmap.Width;
            rFrm.NewHeight = imageHandler.CurrentBitmap.Height;
            if (rFrm.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                imageHandler.RestorePrevious();
                imageHandler.Resize(rFrm.NewWidth, rFrm.NewHeight);
                this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
                this.Invalidate();
                this.Cursor = Cursors.Default;
            }
        } //end of ResizeTSMI_Click

        #region Rotate
        private void Rotate90TSMI_Click(object sender, EventArgs e)
        {
            imageHandler.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Rotate90TSMI_Click

        private void Rotate180TSMI_Click(object sender, EventArgs e)
        {
            imageHandler.RotateFlip(RotateFlipType.Rotate180FlipNone);
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Rotate180TSMI_Click

        private void Rotate270TSMI_Click(object sender, EventArgs e)
        {
            imageHandler.RotateFlip(RotateFlipType.Rotate270FlipNone);
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of Rotate270TSMI_Click
        #endregion Rotate

        #region Flip
        private void FlipHorizontalTSMI_Click(object sender, EventArgs e)
        {
            imageHandler.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of FlipHorizontalTSMI_Click

        private void FlipVerticalTSMI_Click(object sender, EventArgs e)
        {
            imageHandler.RotateFlip(RotateFlipType.RotateNoneFlipY);
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
            this.Invalidate();
        } //end of FlipVerticalTSMI_Click
        #endregion Flip

        private void CropTSMI_Click(object sender, EventArgs e) //剪裁
        {
            FrmCrop_Cheng3001 cpFrm = new FrmCrop_Cheng3001();
            cpFrm.CropXPosition = 0;
            cpFrm.CropYPosition = 0;
            cpFrm.CropWidth = imageHandler.CurrentBitmap.Width;
            cpFrm.CropHeight = imageHandler.CurrentBitmap.Height;
            if (cpFrm.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                imageHandler.RestorePrevious();
                imageHandler.DrawOutCropArea(cpFrm.CropXPosition, cpFrm.CropYPosition, cpFrm.CropWidth, cpFrm.CropHeight);
                this.Invalidate();
                if (MessageBox.Show("Do u want to crop this area?", "ImageProcessing", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    imageHandler.Crop(cpFrm.CropXPosition, cpFrm.CropYPosition, cpFrm.CropWidth, cpFrm.CropHeight);
                }
                else
                {
                    imageHandler.RemoveCropAreaDraw();
                }
                this.Invalidate();
                this.Cursor = Cursors.Default;
            }
        } //end of CropTSMI_Click

        #endregion Image

        #region Insert
        private void TextTSMI_Click(object sender, EventArgs e) //Add text on the image
        {
            FrmInsertText_Cheng3001 itFrm = new FrmInsertText_Cheng3001();
            itFrm.XPosition = itFrm.YPosition = 0;
            if (itFrm.ShowDialog() == DialogResult.OK)
            {
                imageHandler.RestorePrevious();
                imageHandler.InsertText(itFrm.DisplayText, itFrm.XPosition, itFrm.YPosition, itFrm.DisplayTextFont, itFrm.DisplayTextFontSize, itFrm.DisplayTextFontStyle, itFrm.DisplayTextForeColor1, itFrm.DisplayTextForeColor2);
                this.Invalidate();
            }
        } //end of TextTSMI_Click

        private void InsertImageTSMI_Click(object sender, EventArgs e)
        {
            FrmInsertImage_Cheng3001 iiFrm = new FrmInsertImage_Cheng3001();
            iiFrm.XPosition = iiFrm.YPosition = 0;
            if (iiFrm.ShowDialog() == DialogResult.OK)
            {
                imageHandler.RestorePrevious();
                imageHandler.InsertImage(iiFrm.DisplayImagePath, iiFrm.XPosition, iiFrm.YPosition);
                this.Invalidate();
            }
        } //end of InsertImageTSMI_Click

        private void ShapeTSMI_Click(object sender, EventArgs e)
        {
            FrmInsertShape_Cheng3001 isFrm = new FrmInsertShape_Cheng3001();
            isFrm.XPosition = isFrm.YPosition = 0;
            if (isFrm.ShowDialog() == DialogResult.OK)
            {
                imageHandler.RestorePrevious();
                imageHandler.InsertShape(isFrm.ShapeType, isFrm.XPosition, isFrm.YPosition, isFrm.ShapeWidth, isFrm.ShapeHeight, isFrm.ShapeColor);
                this.Invalidate();
            }
        } //end of ShapeTSMI_Click

        #endregion Insert
    }
}
