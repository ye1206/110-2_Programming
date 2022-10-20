using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary_Cheng3001;
using ClassLibrary_Cheng3001.HelperEnum_Cheng3001;
using ClassLibrary_Cheng3001.HelperFunctions_Cheng3001;

namespace GradeBook_V2_Cheng3001
{
    class GradeBookTest_Cheng3001
    {
        static string courseName;
        static int[] gradeArray;
        static int studentNumber;
        // Main method begins app execution

        static void Main()
        {
            //MainV0();
            //MainV1();
            //MainV2();
            //MainV3();
            MainV4();
            Console.Read();
        }

        static void MainV0()
        {
            // one-dimensional array of student grades
            int[] gradesArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

            var myGradeBook = new GradeBook_Cheng3001("CS101 Introduction to C# Programming", gradesArray);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();
        } //end of MainV0

        static void MainV1()
        {
            int gradeCounter = 1;
            Console.WriteLine("Enter course name: ");
            courseName = Console.ReadLine().ToString();

            Console.Write("How many students?\t"); //prompt the user
            studentNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"There are {studentNumber} students!");

            gradeArray = new int[studentNumber];
            Console.Write("Enter student grade\t");
            while (gradeCounter <= studentNumber)  //Enter every student grade 
            {
                gradeArray[gradeCounter - 1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Grade for student{gradeCounter} is {gradeArray[gradeCounter - 1]}");
                gradeCounter++; //increase the counter by 1
                Console.Write("Enter student grade\t");
            }

            var myGradeBook = new GradeBook_Cheng3001(courseName, gradeArray);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();
        }  //end of MainV1

        static void MainV2()
        {
            int gradeCounter = 1;
            string courseNameQuestion = "courseName";
            courseName = validateStringNotEmpty(courseNameQuestion);


            Console.Write("How many students?\t"); //prompt the user
            studentNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"There are {studentNumber} students!");

            gradeArray = new int[studentNumber];
            Console.Write("Enter student grade\t");
            while (gradeCounter <= studentNumber)  //Enter every student grade 
            {
                gradeArray[gradeCounter - 1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Grade for student{gradeCounter} is {gradeArray[gradeCounter - 1]}");
                gradeCounter++; //increase the counter by 1
                Console.Write("Enter student grade\t");
            }

            var myGradeBook = new GradeBook_Cheng3001(courseName, gradeArray);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();
        } //end of MainV2

        static void MainV3()
        {
            string courseNameQuestion = "Course Name: ";
            courseName = validateStringNotEmpty(courseNameQuestion);
            int gradeCounter = 1;

            Console.Write("How many students?\t"); //prompt the user
            var studentNum = validateValueUsingCompare_1flag("Student no. ", 0, 1);
            studentNumber = Convert.ToInt32(studentNum);
            Console.WriteLine($"There are {studentNumber} students!");

            gradeArray = new int[studentNumber];
            bool bResult;
            for (int i = 0; i < gradeArray.Length; i++)
            {
                int iscore;

                Console.Write("Enter student grade: ");
                bResult = false;
                do
                {

                    iscore = Convert.ToInt32(Console.ReadLine());
                    bResult = GradeRange(iscore);

                    if (!bResult)
                        Console.Write("Error. Enter student grade: ");
                } while (bResult == false);

                gradeArray[i] = iscore;
                Console.WriteLine($"Grade for student{i + 1} is {gradeArray[i]}");

            }

            for (int i = 0; i < gradeArray.Length; i++)
            {
                var myGradeBook = new GradeBook_Cheng3001(courseName, gradeArray);
                myGradeBook.DisplayMessage();
                myGradeBook.ProcessGrades();
                break;
            }
        } //end of MainV3

        static void MainV4()
        {
            DataValidation_Cheng3001 dataValidation = new DataValidation_Cheng3001(false, true);
            string courseNameQuestion = "Course Name: ";
            courseName = validateStringNotEmpty(courseNameQuestion);
            int gradeCounter = 1;

            Console.Write("How many students?\t"); //prompt the user
            var studentNum = validateValueUsingCompare_1flag("Student no. ", 0, 1);
            studentNumber = Convert.ToInt32(studentNum);
            Console.WriteLine($"There are {studentNumber} students!");

            gradeArray = new int[studentNumber];
            while (gradeCounter <= studentNumber)
            {
                string gradeS = dataValidation.validateValueInRange("grade? ", 0, 100, true, true, (int)EnumForDataType.DOUBLE_TYPE);
                gradeArray[gradeCounter - 1] = Convert.ToInt32(gradeS);
                Console.WriteLine($"Grade for student {gradeCounter - 1} is {gradeArray[gradeCounter - 1]}");
                gradeCounter++;
            }

            var myGradeBook = new GradeBook_Cheng3001(courseName, gradeArray);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();
        } //end of MainV4
        static string validateStringNotEmpty(string KeyString)
        {
            var stringInput = "";
            var check_S = false;
            var Qes = KeyString + "?";
            var exceptionMessage = KeyString + " (Cannot be empty!)";

            while (check_S == false)
            {
                Console.WriteLine(Qes);
                stringInput = Console.ReadLine();
                try
                {
                    if (stringInput.Trim() != string.Empty)  //trim只會留下非空格的字元
                    {
                        check_S = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please re-input " + exceptionMessage);
                } //end of try-catch
            } // end of while

            return stringInput;
        } //end of validateStringNotEmpty

        public static string getReminderUsingFlagPNO(int flagValuePNO, double thresholdValue, string KeyString)
        {
            var reminder = "";
            if (flagValuePNO == 0)
                reminder = KeyString + "(Make sure: = " + thresholdValue + "!)";
            else if (flagValuePNO == +1)
                reminder = KeyString + "(Make sure: > " + thresholdValue + "!)";
            else
                reminder = KeyString + "(Make sure: < " + thresholdValue + "!)";
            return reminder;
        }
        /// <summary>
        /// 
        /// flagValuePNO: if flagValue > 0 --> flagValue = +1 (input value > threshold Value)
        /// flagValuePNO: if flagValue = 0 --> flagValue =0 (input value = threshold Value)
        /// flagValuePNO: if flagValue < 0 --> flagValue = -1 (input value < threshold Value)
        /// <param name="KeyString"></param>
        /// <param name="thresholdValue"></param>
        /// <param name="flagValuePNO"></param>
        /// <returns></returns>

        static string validateValueUsingCompare_1flag(string KeyString, double thresholdValue, int flagValuePNO)
        {
            var stringInput = "";
            var check_S = false;
            var reminder = "";
            var inputDoubleValue = 0.0;
            reminder = getReminderUsingFlagPNO(flagValuePNO, thresholdValue, KeyString);
            var Question = reminder + "?";
            Console.WriteLine("\nInside validateValueUsingCompare_1flag");

            while (check_S == false)
            {
                Console.WriteLine(Question);
                try
                {
                    stringInput = Console.ReadLine();
                    inputDoubleValue = double.Parse(stringInput);
                    if (FunctionsUseOftenOrArray_Cheng3001.CompareTwoData(inputDoubleValue, thresholdValue) == flagValuePNO)
                        check_S = true;
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error. " + ex.Message + reminder);
                }
            }
            return stringInput;
        } //end of validateValueUsingCompare_1flag 

        public static bool GradeRange(int iqscore)
        {
            if ((iqscore >= 0) && (iqscore <= 100))
                return true;
            else
                return false;
        } // end of GradeRange
    }
}
