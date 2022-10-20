using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary_Cheng3001.HelperFunctions_Cheng3001;

namespace WinFormsApp1UsingLINQ_Cheng3001_220413
{
    public partial class FrmAppForListAndArray_Cheng3001 : Form
    {
        #region global
        bool isArray = true, isRead = true;
        int SIZE = 0;
        char[] delim =  { ',', '\t', ';' }; //Record delimiter (分隔號)
        string arrayQueryS = "Array", listQueryS = "List";
        double[] scoresArray = null;
        List<double> scoresList = new List<double>();
        double average, maxValue, minValue;
        int numBelowAve = 0, numAboveAve = 0;
        #endregion global

        #region SystemIO
        StreamReader inputFile;
        int dataCount = 0;
        FunctionsUseOftenOrArray_Cheng3001 functionsOften = new FunctionsUseOftenOrArray_Cheng3001(); //Quote functions from ClassLibrary
        FunctionsUsingLINQorList_Cheng3001 functionsLINQ = new FunctionsUsingLINQorList_Cheng3001(); //Same as the above
        #endregion SystemIO

        public FrmAppForListAndArray_Cheng3001()
        {
            InitializeComponent();
        }

        #region Buttons
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGetFileAndCal_Click(object sender, EventArgs e)
        {
            isRead = false;
            if (isArray) //User click array
                ProcessArray();
            else
                ProcessList();

   
            if (!isArray)
                ProcessDataUsingList(scoresList);
            else
                processDataUsingArray(scoresArray);

                displayDataOfInterestOnLabels(dataCount);

                //Interface
                BtnAscend.Enabled = true;
                BtnDescend.Enabled = true;
                ListBoxOrderBy.Enabled = true;
                BtnGetFileAndCal.Visible = false;
          
        }
        private void BtnAscend_Click(object sender, EventArgs e)
        {
            ListBoxOrderBy.Items.Clear(); //make sure that ListBoxOrderBy is clear
            if (!isArray)
                DisplayScoresUsingList(FunctionsUsingLINQorList_Cheng3001.Linq_DoubleListSortedByAscending(scoresList).ToList(), ListBoxOrderBy);
            else
                DisplayScoresUsingList(FunctionsUsingLINQorList_Cheng3001.Linq_DoubleArraySortedByAscending(scoresArray).ToList(), ListBoxOrderBy);
        }

        private void BtnDescend_Click(object sender, EventArgs e)
        {
            ListBoxOrderBy.Items.Clear(); //make sure that ListBoxOrderBy is clear
            if (!isArray)
                DisplayScoresUsingList(FunctionsUsingLINQorList_Cheng3001.Linq_DoubleListSortedByDescending(scoresList).ToList(), ListBoxOrderBy);
            else
                DisplayScoresUsingList(FunctionsUsingLINQorList_Cheng3001.Linq_DoubleArraySortedByDescending(scoresArray).ToList(), ListBoxOrderBy);
        } // end of BtnDescend_Click
        #endregion Buttons

        #region ProcessFunctions
        private void ProcessArray()
        {
            try
            {
                inputFile = File.OpenText("GradeForArray.txt"); //Open file

                string inputdataS = inputFile.ReadLine();
                string[] inputField = inputdataS.Split(delim);
                SIZE = int.Parse(inputField[1]);

                scoresArray = new double[SIZE]; //create an array to hlod items read from the file

                dataCount = 0; //create a variable to use in the loop

                while (dataCount < scoresArray.Length && !inputFile.EndOfStream) //Read the file's contents into the array
                {
                    scoresArray[dataCount] = int.Parse(inputFile.ReadLine());
                    dataCount++;
                }

                inputFile.Close();

                foreach (int value in scoresArray) //Display the array elements in the list box
                    ListBoxTestScore.Items.Add(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        } //end of ProcessArray

        private void ProcessList()
        {
            try
            {
                inputFile = File.OpenText("GradeForList.txt"); //Open file

                dataCount = 0; //create a variable to use in the loop

                while (!inputFile.EndOfStream) //Read the file's contents into the array
                {
                    double value = double.Parse(inputFile.ReadLine());
                    scoresList.Add(value);
                    ListBoxTestScore.Items.Add(value);
                    dataCount += 1;
                } //end while
                inputFile.Close();
                isRead = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //end fo ProcessList
        public void processDataUsingArray(double[] scoreArray)
        {
            average = functionsOften.FindAverage(scoreArray);
            maxValue = functionsOften.FindHighest(scoreArray);
            minValue = functionsOften.FindLowest(scoreArray);

            numBelowAve = FunctionsUseOftenOrArray_Cheng3001.FindAmountBelowThresholdUsingArrayPO(scoreArray, average, FunctionsUseOftenOrArray_Cheng3001.FLAG_IS_EQUAL);
            numAboveAve = FunctionsUseOftenOrArray_Cheng3001.FindAmountAboveThresholdUsingArrayPO(scoreArray, average, FunctionsUseOftenOrArray_Cheng3001.FLAG_IS_EQUAL);
        }

        public void ProcessDataUsingList(List<double> ScoreList)
        {
            //Display all scores
            //Calculate data of interest: Average, min, Max, belowAve, and AboveAve

            average = FunctionsUsingLINQorList_Cheng3001.FindAverageForList(ScoreList);
            minValue = functionsLINQ.FindLowestForList(ScoreList);
            maxValue = functionsLINQ.FindHighestForList(ScoreList);

            numBelowAve = FunctionsUsingLINQorList_Cheng3001.FindAmountBelowThresholdUsingList(ScoreList, average);
            numAboveAve = FunctionsUsingLINQorList_Cheng3001.FindAmountAboveThresholdUsingList(ScoreList, average);
        }
        #endregion ProcessFunctions

        #region DisplayData
        public static void DisplayScoresUsingList(List<double> ScoresList, ListBox displayListBox)
        {
            foreach (int score in ScoresList)
                displayListBox.Items.Add(score);
        } // end of DisplayScoresUsingList

        private void displayDataOfInterestOnLabels(int dataCount)
        {
            LblScoreAverage.Text = average.ToString("n1"); // n1 for 小數點後第一位
            LblScoreMin.Text = minValue.ToString();
            LblScoreMax.Text = maxValue.ToString();
            LblHigherAveNumber.Text = numAboveAve.ToString();
            LblLowerAveNumber.Text = numBelowAve.ToString();

            LblStudentNumber.Text = dataCount.ToString();
        } //end of displayDataOfInterestOnLabels
        #endregion DisplayData
        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnGetFileAndCal.Text = "Read Score";
            scoresArray = null;
            ToolStripMenuItem sendertoolStripMenuItem = (ToolStripMenuItem)sender;
            string menuType = sendertoolStripMenuItem.Text;
            MessageBox.Show("menuType =  " + menuType);

            if (menuType == arrayQueryS)
                isArray = true;
            else //run list
                isArray = false;

            BtnGetFileAndCal.Visible = true;
            BtnGetFileAndCal.Text = BtnGetFileAndCal.Text + " (" + menuType + ")";
        }//end of queryToolStripMenuItem

        
    }
}
