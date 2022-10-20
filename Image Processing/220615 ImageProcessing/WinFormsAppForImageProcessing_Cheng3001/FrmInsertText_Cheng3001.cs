using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class FrmInsertText_Cheng3001 : Form
    {
        public FrmInsertText_Cheng3001()
        {
            InitializeComponent();
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

        public string DisplayText
        {
            get { return TxtText.Text; }
            set { TxtText.Text = value.ToString(); }
        } //end of DisplayText

        public string DisplayTextFont
        {
            get { return FontComboBox.Text; }
            set { FontComboBox.Text = value.ToString(); }
        } //end of DisplayTextFont

        public float DisplayTextFontSize
        {
            get
            {
                float fs = 10.0F;
                if (!string.IsNullOrEmpty(SizeComboBox.Text))
                    fs = Convert.ToSingle(SizeComboBox.Text.Replace("pt", ""));
                return fs;
            }
            set { SizeComboBox.Text = value.ToString() + "pt"; }
        } //end of DisplayTextFontSize

        public string DisplayTextFontStyle
        {
            get { return StyleComboBox.Text; }
            set { StyleComboBox.Text = value.ToString(); }
        } //end of DisplayTextFontStyle

        public string DisplayTextForeColor1
        {
            get { return Color1ComboBox.Text; }
            set { Color1ComboBox.Text = value.ToString(); }
        } //end of DisplayTextForeColor1

        public string DisplayTextForeColor2
        {
            get { return Color2ComboBox.Text; }
            set { Color2ComboBox.Text = value.ToString(); }
        } //end of DisplayTextForeColor2

        private void FrmInsertText_Cheng3001_Load(object sender, EventArgs e)
        {
            // Load Fonts.
            foreach (FontFamily ff in FontFamily.Families)
            {
                FontComboBox.Items.Add(ff.Name);
            }

            // Load Font Size.
            for (int i = 5; i <= 75; i += 5)
            {
                SizeComboBox.Items.Add(i.ToString() + "pt");
            }

            // Load Font Styles.
            StyleComboBox.Items.Add("Bold");
            StyleComboBox.Items.Add("Italic");
            StyleComboBox.Items.Add("Regular");
            StyleComboBox.Items.Add("Strikeout");
            StyleComboBox.Items.Add("Underline");

            // Load Colors.
            Type type = typeof(System.Drawing.Color);
            System.Reflection.PropertyInfo[] propertyInfo = type.GetProperties();
            for (int i = 0; i < propertyInfo.Length; i++)
            {
                if (propertyInfo[i].Name != "Transparent"
                    && propertyInfo[i].Name != "R"
                    && propertyInfo[i].Name != "G"
                    && propertyInfo[i].Name != "B"
                    && propertyInfo[i].Name != "A"
                    && propertyInfo[i].Name != "IsKnownColor"
                    && propertyInfo[i].Name != "IsEmpty"
                    && propertyInfo[i].Name != "IsNamedColor"
                    && propertyInfo[i].Name != "IsSystemColor"
                    && propertyInfo[i].Name != "Name")
                {
                    Color1ComboBox.Items.Add(propertyInfo[i].Name);
                    Color2ComboBox.Items.Add(propertyInfo[i].Name);
                }
            } //end of for loop
        } //end of FrmInsertText_Cheng3001_Load

        private void GradientCheckBox_CheckedChanged(object sender, EventArgs e) //色彩梯度
        {
            Color2ComboBox.Enabled = GradientCheckBox.Checked;
        }
    }
}
