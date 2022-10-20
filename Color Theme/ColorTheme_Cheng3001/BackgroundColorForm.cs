using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTheme_Cheng3001
{
    public partial class BackgroundColorForm : Form
    {
        public BackgroundColorForm()
        {
            InitializeComponent();
        }

        private void YellowRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (YellowRadioBtn.Checked)
                this.BackColor = Color.Yellow;
        } //end of YellowRadioBtn_CheckedChanged

        private void RedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (RedRadioBtn.Checked)
                this.BackColor = Color.Red;
        } //end of RedRadioBtn_CheckedChanged

        private void WhiteRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (WhiteRadioBtn.Checked)
                this.BackColor = Color.White;
        } //end of WhiteRadioBtn_CheckedChanged

        private void NormalRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalRadioBtn.Checked)
                this.BackColor = SystemColors.Control;
        } //end of NormalRadioBtn_CheckedChanged

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } //end of BtnExit_Click
    }
}
