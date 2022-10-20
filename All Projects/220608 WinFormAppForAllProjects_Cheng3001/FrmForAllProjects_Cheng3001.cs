using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateFile_TextAndByte_Cheng3001;
using ReadSequentialAccessFile_TextAndByte_Cheng3001;
using CreditInquirty_TextAndByte_Cheng3001;
using SimpleColorMixture_Cheng3001;
using LotteryNumber_Cheng3001;
using WinFormsApp1UsingLINQ_Cheng3001_220413;
using ;
using WinFormsApp4Bank_Cheng3001_220504;
using ClassLibrary_Cheng3001.FileStreams_Cheng3001;

namespace WinFormAppForAllProjects_Cheng3001_220608
{
    public partial class FrmForAllProjects_Cheng3001 : Form
    {
        public FrmForAllProjects_Cheng3001()
        {
            InitializeComponent();
        }

        #region File

        private void ColorThemeTSMI_Click(object sender, EventArgs e)
        {
            var child = new FrmSimpleColorMixture_Cheng3001(); // create new child
            child.MdiParent = this; // set parent
            child.Show(); // display child    
        } //end of ColorThemeTSMI_Click

        private void LotteryNumberTSMI_Click(object sender, EventArgs e)
        {
            var child = new FrmLotteryNumber_Cheng3001(); // create new child
            child.MdiParent = this; // set parent
            child.Show(); // display child    
        } //end of LotteryNumberTSMI_Click

        #region LINQ
        private void GradeTSMI_Click(object sender, EventArgs e)
        {
            var child = new FrmAppForListAndArray_Cheng3001(); // create new child
            child.MdiParent = this; // set parent
            child.Show(); // display child    
        } //end of GradeTSMI_Click
        
        private void WorkerTSMI_Click(object sender, EventArgs e)
        {
            var child = new FrmForWorker_Cheng3001_220525(); // create new child
            child.MdiParent = this; // set parent
            child.Show(); // display child    
        } //end of WorkerTSMI_Click
        #endregion LINQ

        #region Bank
        private void CreateAccountTSMI_Click(object sender, EventArgs e)
        {
            var child = new FrmCreateFile_TextAndByte_Cheng3001(); // create new child
            child.MdiParent = this; // set parent
            child.Show(); // display child    
        } //end of CreateAccountsTSMI_Click

        private void ReadAccountTSMI_Click(object sender, EventArgs e)
        {
            var child = new FrmReadFile_TextNByte_Cheng3001();
            child.MdiParent = this;
            child.Show();
        } //end of ReadAccountTSMI_Click

        private void QueryTSMI_Click(object sender, EventArgs e)
        {
            var child = new FrmCreditInquirty_TextAndByte_Cheng3001();
            child.MdiParent = this;
            child.Show();
        } //end of QueryTSMI_Click
        #endregion Bank

        private void ImageProcessingTSMI_Click(object sender, EventArgs e)
        {

        } //end of ImageProcessingTSMI_Click

        private void ExitTSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //end of ExitTSMI_Click

        #endregion File

        #region Windows
        private void CascadeTSMI_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        } //end of CascadeTSMI_Click

        private void HorizontalTSMI_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        } //end of HorizontalTSMI_Click

        private void VerticalTSMI_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        } //end of VerticalTSMI_Click
        #endregion Windows





        
    }
}
