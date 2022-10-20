using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class FrmBrightness_Cheng3001 : Form
    {
        public FrmBrightness_Cheng3001()
        {
            InitializeComponent();
            BtnOK.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;
        }

        public int BrightnessValue
        {
            get
            {
                if (string.IsNullOrEmpty(ValueTextBox.Text))
                    ValueTextBox.Text = "0";
                return Convert.ToInt32(ValueTextBox.Text);
            }
            set { ValueTextBox.Text = value.ToString(); }
        }
    }
}
