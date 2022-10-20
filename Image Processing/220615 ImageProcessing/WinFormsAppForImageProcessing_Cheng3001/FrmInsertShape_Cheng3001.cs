using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppForImageProcessing_Cheng3001
{
    public partial class FrmInsertShape_Cheng3001 : Form
    {
        public FrmInsertShape_Cheng3001()
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

        public int ShapeWidth
        {
            get
            {
                if (string.IsNullOrEmpty(TxtWidth.Text))
                    TxtWidth.Text = "0";
                return Convert.ToInt32(TxtWidth.Text);
            }
            set { TxtWidth.Text = value.ToString(); }
        } //end of ShapeWidth

        public int ShapeHeight
        {
            get
            {
                if (string.IsNullOrEmpty(TxtHeight.Text))
                    TxtHeight.Text = "0";
                return Convert.ToInt32(TxtHeight.Text);
            }
            set { TxtHeight.Text = value.ToString(); }
        } //end of ShapeHeight

        public string ShapeType
        {
            get { return ShapeComboBox.Text; }
            set { ShapeComboBox.Text = value.ToString(); }
        } //end of ShapeType

        public string ShapeColor
        {
            get { return ColorComboBox.Text; }
            set { ColorComboBox.Text = value.ToString(); }
        } //end of ShapeColor

        private void FrmInsertShape_Cheng3001_Load(object sender, EventArgs e)
        {
            // Load Shapes.
            ShapeComboBox.Items.Add("FilledEllipse");
            ShapeComboBox.Items.Add("FilledRectangle");
            ShapeComboBox.Items.Add("Ellipse");
            ShapeComboBox.Items.Add("Rectangle");
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
                    ColorComboBox.Items.Add(propertyInfo[i].Name);
                }
            }
        } //end of FrmInsertShape_Cheng3001_Load
    }
}
