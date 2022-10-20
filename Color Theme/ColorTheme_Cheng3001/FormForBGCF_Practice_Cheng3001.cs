using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorTheme_Cheng3001
{
    public partial class FormForBGCF_Practice_Cheng3001 : Form
    {
        public FormForBGCF_Practice_Cheng3001()
        {
            InitializeComponent();
        }

        private void RedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (RedRadioBtn.Checked)
                this.BackColor = Color.Red;
        } //end of RedRadioBtn_CheckedChanged

        private void GreenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenRadioBtn.Checked)
                this.BackColor = Color.Green;
        } //end of GreenRadioBtn_CheckedChanged

        private void BlueRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BlueRadioBtn.Checked)
                this.BackColor = Color.Blue;
        } //end of BlueRadioBtn_CheckedChanged

        private void WhiteRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (WhiteRadioBtn.Checked)
                this.BackColor = Color.White;
        } //end of WhiteRadioBtn_CheckedChanged

        private void GrayRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (GrayRadioBtn.Checked)
                this.BackColor = Color.Gray;
        } //end of GrayRadioBtn_CheckedChanged

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
