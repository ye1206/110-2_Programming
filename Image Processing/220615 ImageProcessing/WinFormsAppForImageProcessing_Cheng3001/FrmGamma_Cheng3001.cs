using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class frmGamma_Cheng3001 : Form
    {
        public frmGamma_Cheng3001()
        {
            InitializeComponent();
            BtnOK.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;
        }

        public double RedComponent
        {
            get
            {
                if (string.IsNullOrEmpty(TxtRedValue.Text))
                    TxtRedValue.Text = "0";
                return Convert.ToDouble(TxtRedValue.Text);
            }
            set { TxtRedValue.Text = value.ToString(); }
        } //end of RedComponent

        public double GreenComponent
        {
            get
            {
                if (string.IsNullOrEmpty(TxtGreenValue.Text))
                    TxtGreenValue.Text = "0";
                return Convert.ToDouble(TxtGreenValue.Text);
            }
            set { TxtGreenValue.Text = value.ToString(); }
        }

        public double BlueComponent
        {
            get
            {
                if (string.IsNullOrEmpty(TxtBlueValue.Text))
                    TxtBlueValue.Text = "0";
                return Convert.ToDouble(TxtBlueValue.Text);
            }
            set { TxtBlueValue.Text = value.ToString(); }
        }


    }
}
