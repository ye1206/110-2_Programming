using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumber_Cheng3001
{
    public partial class FrmLotteryNumber_Cheng3001 : Form
    {
        #region global
        const int SIZE = 10;
        int[] lotteryNumber = new int[SIZE];
        Label[] randomLabel = new Label[SIZE];
        #endregion global

        public FrmLotteryNumber_Cheng3001()
        {
            InitializeComponent();
            initializeLabelArray();
        }

        #region Button
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int index = 0; index < lotteryNumber.Length; index++)
            {
                lotteryNumber[index] = rnd.Next(1, 100);
                randomLabel[index].Text = lotteryNumber[index].ToString();  //將lotterynumber按照索引指定給相同位置的label

                //Before:    Lbl1st.Text = lotteryNumber[0].ToString();     (Others the same as Lbl1st)
            }

            var distinctedNumbers = produceNoDuplicatedData(lotteryNumber); //When use "var" to define a variance, you don't need to give a data type. It will define its type automatically by the things you give behind.

            for (int index = 0; index < lotteryNumber.Length; index++)
            {
                randomLabel[index].Text = distinctedNumbers[index].ToString();  //Same as Line 35
            }
        } //end of BtnGenerate_Click

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } //end of BtnExit_Click
        #endregion Button

        #region function
        private void initializeLabelArray()
        {
            Label[] randomLabel2 = { Lbl1st, Lbl2nd, Lbl3rd, Lbl4th, Lbl5th, Lbl6th, Lbl7th, Lbl8th, Lbl9th, Lbl10th };
            randomLabel = randomLabel2;
        } //end of initializeLabelArray

        /// <summary>Produces the no duplicated data.</summary>
        /// <param name="lotteryNumber">The lottery number.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        private List<int> produceNoDuplicatedData(int[] lotteryNumber)
        {
            var distinctedNumbers = lotteryNumber.Distinct().ToList();  //Use "Distinct" to clear  the duplicated number
            while (distinctedNumbers.Count != lotteryNumber.Length)
            {
                distinctedNumbers.ForEach(x => MessageBox.Show(x.ToString()));  //Appearing the duplicated number, message box will run elements first except the repeat one.

                for (int index = distinctedNumbers.Count; index < lotteryNumber.Length; index++)
                {
                    distinctedNumbers.Add(new Random().Next(1, 100));   //Create a new number for lotterynumber
                }

                distinctedNumbers = distinctedNumbers.Distinct().ToList(); //Check again to ensure every number is single.
            }

            return distinctedNumbers;
        } //end of produceNoDuplicatedData

        #endregion function
    }
}
