using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleColorMixture_Cheng3001
{
    public partial class FrmSimpleColorMixture_Cheng3001 : Form
    {
        #region global variables 
        public const int BLACK_COLOR = 0, RED_COLOR = 4, GREEN_COLOR = 2, BLUE_COLOR = 1, CYAN_COLOR = 3, MAGENTA_COLOR = 5, YELLOW_COLOR = 6, WHITE_COLOR = 7, DEFAULT_COLOR = -1;
        public int ColorMixture_rgb = 0;
        const int IF_ELSE_IF_METHOD = 1, SWITCH_METHOD = 2;
        int decisionMethod = SWITCH_METHOD;
        AdditiveColorMixture_Cheng3001 additiveColorMixture;  //Create new variance additivecolormixture under class AdditiveColor
        int r = 0, g = 0, b = 0, alpha = 0;
        public Color backColor = Color.White;
        #endregion global variables

        public FrmSimpleColorMixture_Cheng3001()
        {
            InitializeComponent();
        }

        #region Method

        public void AdditiveColorMixture_Cheng3001(CheckBox _ckboxRed, CheckBox _ckboxGreen, CheckBox _ckboxBlue, int _decisionMethod)
        {
            RedCheckBox = _ckboxRed;
            GreenCheckBox = _ckboxGreen;
            BlueCheckBox = _ckboxBlue;

            ColorMixture_rgb = 0;

            if (RedCheckBox.Checked)
                ColorMixture_rgb += RED_COLOR;
            if (GreenCheckBox.Checked)
                ColorMixture_rgb += GREEN_COLOR;
            if (BlueCheckBox.Checked)
                ColorMixture_rgb += BLUE_COLOR;

            decisionMethod = _decisionMethod;
            backColor = getColor(decisionMethod);
        } //end of AdditiveColorMixture_Cheng3001

        private void decisionWhichMethod()
        {
            Color color = Color.White;
            ColorMixture_rgb = 0;

            if (IfRadioBtn.Checked)
            {
                MessageBox.Show("You select if-else method.");
                color = getMixColorUsingIfElseIf();
            }
            else
            {
                MessageBox.Show("You select switch method.");
                color = getColorMixtureUsingSwitch();
            }
        } //end of decisionWhichMethod

        #region If-Else
        private Color getMixColorUsingIfElseIf()
        {
            Color mixedColor = Color.Black; //default color

            if (RedCheckBox.Checked && GreenCheckBox.Checked && BlueCheckBox.Checked)
            {
                mixedColor = Color.White;
            }
            else if (RedCheckBox.Checked && GreenCheckBox.Checked)
            {
                mixedColor = Color.Yellow;
            }
            else if (RedCheckBox.Checked && BlueCheckBox.Checked)
            {
                mixedColor = Color.Magenta;
            }
            else if (RedCheckBox.Checked && GreenCheckBox.Checked)
            {
                mixedColor = Color.Yellow;
            }
            else if (GreenCheckBox.Checked && BlueCheckBox.Checked)
            {
                mixedColor = Color.Cyan;
            }
            else if (RedCheckBox.Checked)
            {
                mixedColor = Color.Red;
            }
            else if (GreenCheckBox.Checked)
            {
                mixedColor = Color.Green;
            }
            else if (BlueCheckBox.Checked)
            {
                mixedColor = Color.Blue;
            }
            else
            {
                mixedColor = Color.Black;
            }
            return mixedColor;
        } //end of  getMixColorUsingIfElseIf
        #endregion If-Else
        #region Switch
        private void AdditiveColorMixtureSwitch_rgb()
        {
            //BLACK_COLOR = 0, RED_COLOR = 4, GREEN_COLOR = 2, BLUE_COLOR = 1,
            //CYAN_COLOR = 3, MAGENTA_COLOR = 5, YELLOW_COLOR = 6, WHITE_COLOR = 7, DEFAULT_COLOR = -1

            ColorMixture_rgb = 0;
            if (RedCheckBox.Checked)
                ColorMixture_rgb += RED_COLOR;
            if (GreenCheckBox.Checked)
                ColorMixture_rgb += GREEN_COLOR;
            if (BlueCheckBox.Checked)
                ColorMixture_rgb += BLUE_COLOR;
        } //end of AdditiveColorMixtureSwitch_rgb


        private Color getColor(int _decisionMethod)
        {
            Color color = Color.White;

            if (decisionMethod == IF_ELSE_IF_METHOD)
            {
                MessageBox.Show("You select if-else method.");
                color = getMixColorUsingIfElseIf();
            }
            else
            {
                MessageBox.Show("You select switch method.");
                color = getColorMixtureUsingSwitch();
            }
            return color;
        } //end of GetColor
        private Color getColorMixtureUsingSwitch()
        {
            Color mixedcolor = Color.Black;
            AdditiveColorMixtureSwitch_rgb();

            switch (ColorMixture_rgb)
            {
                case BLACK_COLOR:
                    mixedcolor = Color.Black;
                    break;
                case RED_COLOR:
                    mixedcolor = Color.Red;
                    break;
                case GREEN_COLOR:
                    mixedcolor = Color.Green;
                    break;
                case BLUE_COLOR:
                    mixedcolor = Color.Blue;
                    break;
                case YELLOW_COLOR:
                    mixedcolor = Color.Yellow;
                    break;
                case CYAN_COLOR:
                    mixedcolor = Color.Cyan;
                    break;
                case MAGENTA_COLOR:
                    mixedcolor = Color.Magenta;
                    break;
                case WHITE_COLOR:
                    mixedcolor = Color.White;
                    break;
            }
            return mixedcolor;
        } //end of getColorMixtureUsingSwitch
        #endregion Switch
        #endregion Method

        #region Bar
        private void bar_ColorChanged(object sender, EventArgs e)
        {
            ColorChange();
        } //end of bar_ColorChanged

        private void ColorChange()
        {
            r = RedScrollBar.Value; //get the value of red bar
            g = GreenScrollBar.Value;
            b = BlueScrollBar.Value;
            alpha = AlphaScrollBar.Value;

            r = Math.Max(Math.Min(RedScrollBar.Value, 255), 0); //先取最小(並設置上限值為255)再取最大值
            g = Math.Max(Math.Min(GreenScrollBar.Value, 255), 0);
            b = Math.Max(Math.Min(BlueScrollBar.Value, 255), 0);
            alpha = Math.Max(Math.Min(AlphaScrollBar.Value, 255), 0);

            RedTextBox.Text = r.ToString();
            GreenTextBox.Text = g.ToString();
            BlueTextBox.Text = b.ToString();
            AlphaTextBox.Text = alpha.ToString();

            RedBarGroup.BackColor = Color.FromArgb(alpha, r, 0, 0); //change color from rgb
            GreenBarGroup.BackColor = Color.FromArgb(alpha, 0, g, 0);
            BlueBarGroup.BackColor = Color.FromArgb(alpha, 0, 0, b);

            this.BackColor = Color.FromArgb(r, g, b);
        }
        #endregion Bar

        #region Button
        private void ColorMixBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changing the background color.");
            this.backColor = Color.FromArgb(r, g, b);
        } //end of ColorMixBtn_Click

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Color color = Color.White;

            if (DifferentRadioBtn.Checked)
            {
                if (IfRadioBtn.Checked)
                    decisionMethod = IF_ELSE_IF_METHOD;
                else
                    decisionMethod = SWITCH_METHOD;
                additiveColorMixture = new AdditiveColorMixture_Cheng3001(RedCheckBox, GreenCheckBox, BlueCheckBox, decisionMethod);
                this.BackColor = additiveColorMixture.backColor;
            }
            else
            {
                if (IfRadioBtn.Checked)
                {
                    MessageBox.Show("You select if-else method.");
                    color = getMixColorUsingIfElseIf();
                }
                else
                {
                    MessageBox.Show("You select switch method.");
                    color = getColorMixtureUsingSwitch();
                }
                this.BackColor = color;
            }
        } //end of ChangeBtn_Click

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        } //end of ExitBtn_Click

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        } //end of CloseBtn_Click

        #endregion Button

    }
}
