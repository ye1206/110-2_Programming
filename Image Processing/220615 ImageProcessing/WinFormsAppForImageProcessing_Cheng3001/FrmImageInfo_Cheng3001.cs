using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class ImageInfo_Cheng3001 : Form
    {
        ImageHandler_Cheng3001 imageHandler;
        public ImageInfo_Cheng3001(ImageHandler_Cheng3001 imageHandler)
        {
            this.imageHandler = imageHandler;
            InitializeComponent();
        }

        private void ImageInfo_Cheng3001_Load(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(imageHandler.BitmapPath);
            LblName.Text = fileInfo.Name.Replace(fileInfo.Extension, "");
            LblExtension.Text = fileInfo.Extension;
            string loc = fileInfo.DirectoryName;
            if (loc.Length > 50)
                loc = loc.Substring(0, 15) + "..." + loc.Substring(loc.LastIndexOf("\\"));
            LblLocation.Text = loc;
            LblDimension.Text = imageHandler.CurrentBitmap.Width + " x " + imageHandler.CurrentBitmap.Height;
            LblSize.Text = (fileInfo.Length / 1024.0).ToString("0.0") + " KB";
            LblCreated.Text = fileInfo.CreationTime.ToString("dddd MMMM dd, yyyy");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
