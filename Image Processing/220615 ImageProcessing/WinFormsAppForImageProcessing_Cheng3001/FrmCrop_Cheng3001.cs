using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class FrmCrop_Cheng3001 : Form
    {
        public FrmCrop_Cheng3001()
        {
            InitializeComponent();
            BtnOK.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;
        }

        public int CropXPosition
        {
            get
            {
                if (string.IsNullOrEmpty(TxtX.Text))
                    TxtX.Text = "0";
                return Convert.ToInt32(TxtX.Text);
            }
            set { TxtX.Text = value.ToString(); }
        } //end of CropXPosition

        public int CropYPosition
        {
            get
            {
                if (string.IsNullOrEmpty(TxtY.Text))
                    TxtY.Text = "0";
                return Convert.ToInt32(TxtY.Text);
            }
            set { TxtY.Text = value.ToString(); }
        } //end of CropYPosition

        public int CropWidth
        {
            get
            {
                if (string.IsNullOrEmpty(TxtWidth.Text))
                    TxtWidth.Text = "0";
                return Convert.ToInt32(TxtWidth.Text);
            }
            set { TxtWidth.Text = value.ToString(); }
        } //end of CropWidth

        public int CropHeight
        {
            get
            {
                if (string.IsNullOrEmpty(TxtHeight.Text))
                    TxtHeight.Text = "0";
                return Convert.ToInt32(TxtHeight.Text);
            }
            set { TxtHeight.Text = value.ToString(); }
        } //end of CropHeight
    }
}
