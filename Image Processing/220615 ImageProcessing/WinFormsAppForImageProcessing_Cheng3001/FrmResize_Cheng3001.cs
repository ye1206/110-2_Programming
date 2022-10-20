using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class FrmResize_Cheng3001 : Form
    {
        public FrmResize_Cheng3001()
        {
            InitializeComponent();
            BtnOK.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;
        }

        public int NewWidth
        {
            get
            {
                if (string.IsNullOrEmpty(TxtWidth.Text))
                    TxtWidth.Text = "0";
                return Convert.ToInt32(TxtWidth.Text);
            }
            set { TxtWidth.Text = value.ToString(); }
        } //end of NewWidth

        public int NewHeight
        {
            get
            {
                if (string.IsNullOrEmpty(TxtHeight.Text))
                    TxtHeight.Text = "0";
                return Convert.ToInt32(TxtHeight.Text);
            }
            set { TxtHeight.Text = value.ToString(); }
        } //end of NewHeight
    }
}
