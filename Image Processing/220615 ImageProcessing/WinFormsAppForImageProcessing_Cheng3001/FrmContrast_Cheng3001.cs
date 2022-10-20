using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class FrmContrast_Cheng3001 : Form
    {
        public FrmContrast_Cheng3001()
        {
            InitializeComponent();
            BtnOK.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;
        }

        public double ContrastValue
        {
            get
            {
                if (string.IsNullOrEmpty(ValueTextBox.Text))
                    ValueTextBox.Text = "0";
                return Convert.ToDouble(ValueTextBox.Text);
            }
            set { ValueTextBox.Text = value.ToString(); }
        }
    }
}
