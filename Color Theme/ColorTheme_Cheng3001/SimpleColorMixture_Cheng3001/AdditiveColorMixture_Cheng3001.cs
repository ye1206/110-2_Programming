using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleColorMixture_Cheng3001
{
    internal class AdditiveColorMixture_Cheng3001
    {
        public const int RED_COLOR = 4, GREEN_COLOR = 2, BLUE_COLOR = 1, CYAN_COLOR = 3, MAGENTA_COLOR = 5, YELLOW_COLOR = 6, WHITE_COLOR = 7, DEFAULT_COLOR = -1;

        int r = 0, g = 0, b = 0, alpha = 0;
        public int ColorMixture_rgb = 0;
        public int ColorMixtureResult = 0;

        CheckBox ckBoxRed, ckBoxGreen, ckBoxBlue;
        const int IF_ELSE_IF_METHOD = 1, SWITCH_METHOD = 2;
        int decisionMethod = SWITCH_METHOD;

        public Color backColor = Color.White;

        public AdditiveColorMixture_Cheng3001(CheckBox _ckBoxRed, CheckBox _ckBoxGreen, CheckBox _ckBoxBlue, int _decisionMethod)
        {
            ckBoxRed = _ckBoxRed;
            ckBoxGreen = _ckBoxGreen;
            ckBoxBlue = _ckBoxBlue;

            ColorMixtureResult = 0;

            if (ckBoxRed.Checked)
                ColorMixtureResult += RED_COLOR;
            if (ckBoxGreen.Checked)
                ColorMixtureResult += GREEN_COLOR;
            if (ckBoxBlue.Checked)
                ColorMixtureResult += BLUE_COLOR;

            decisionMethod = _decisionMethod;
            backColor = getColor();
        } //end of AdditiveColorMixture_Cheng3001

        private Color getMixColorUsingIfElseIf()
        {
            Color mixedColor = Color.Black; //default color

            if (ckBoxRed.Checked && ckBoxGreen.Checked && ckBoxBlue.Checked)
            {
                mixedColor = Color.White;
            }
            else if (ckBoxRed.Checked && ckBoxGreen.Checked)
            {
                mixedColor = Color.Yellow;
            }
            else if (ckBoxRed.Checked && ckBoxBlue.Checked)
            {
                mixedColor = Color.Magenta;
            }
            else if (ckBoxRed.Checked && ckBoxGreen.Checked)
            {
                mixedColor = Color.Yellow;
            }
            else if (ckBoxGreen.Checked && ckBoxBlue.Checked)
            {
                mixedColor = Color.Cyan;
            }
            else if (ckBoxRed.Checked)
            {
                mixedColor = Color.Red;
            }
            else if (ckBoxGreen.Checked)
            {
                mixedColor = Color.Green;
            }
            else if (ckBoxBlue.Checked)
            {
                mixedColor = Color.Blue;
            }
            else
            {
                mixedColor = Color.Black;
            }
            return mixedColor;
        } //end of getMixColorUsingIfElseIf

        /*public void AdditiveColorMixtureSwitch_rgb(CheckBox _ckBoxRed, CheckBox _ckBoxGreen, CheckBox _ckBoxBlue, int _decisionMethod)
        {
            ckBoxRed = _ckBoxRed;
            ckBoxGreen = _ckBoxGreen; 
            ckBoxBlue = _ckBoxBlue;

            ColorMixture_rgb = 0;

            if (ckBoxRed.Checked)
                ColorMixture_rgb += RED_COLOR;
            if (ckBoxGreen.Checked)
                ColorMixture_rgb += GREEN_COLOR;
            if (ckBoxBlue.Checked)
                ColorMixture_rgb += BLUE_COLOR;

            decisionMethod = _decisionMethod;
            backColor = getColor();
        }*/
        private Color getColor()
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
        } //end of getColor
        private Color getColorMixtureUsingSwitch()
        {
            Color mixedcolor = Color.Black;
            switch (ColorMixtureResult)
            {
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
    } // end of class AdditiveColorMixture_Cheng3001
}

