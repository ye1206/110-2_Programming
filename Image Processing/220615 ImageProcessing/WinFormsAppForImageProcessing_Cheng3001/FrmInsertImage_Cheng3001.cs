using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class FrmInsertImage_Cheng3001 : Form
    {
        OpenFileDialog oDlg;

        public FrmInsertImage_Cheng3001()
        {
            InitializeComponent();
            oDlg = new OpenFileDialog(); // Open Dialog Initialization
            oDlg.RestoreDirectory = true;
            oDlg.InitialDirectory = "C:\\";
            oDlg.FilterIndex = 1;
            oDlg.Filter = "jpg Files (*.jpg)|*.jpg|gif Files (*.gif)|*.gif|png Files (*.png)|*.png |bmp Files (*.bmp)|*.bmp";
            BtnOK.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;
        }

        public int XPosition
        {
            get
            {
                if (string.IsNullOrEmpty(TxtX.Text))
                    TxtX.Text = "0";
                return Convert.ToInt32(TxtX.Text);
            }
            set { TxtX.Text = value.ToString(); }
        } //end of XPosition

        public int YPosition
        {
            get
            {
                if (string.IsNullOrEmpty(TxtY.Text))
                    TxtY.Text = "0";
                return Convert.ToInt32(TxtY.Text);
            }
            set { TxtY.Text = value.ToString(); }
        } //end of YPosition

        public string DisplayImagePath
        {
            get { return TxtImage.Text; }
            set { TxtImage.Text = value.ToString(); }
        } //end of DisplayImagePath

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == oDlg.ShowDialog())
            {
                TxtImage.Text = oDlg.FileName;
            }
        } //end of BtnSelect_Click
    }
}
