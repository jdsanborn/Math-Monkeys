﻿/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Math_Problem_Screen
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Monkeys
{

    // Coder of this - Mary Venegas
    public partial class Math_Problem_Screen : Form
    {
        private int preceed=0;
        private List<Report> ReportList = new List<Report>();

        //Jungle Selection removed at customer request
        //private int jungle;//helps determine which type of math operation we are following
        
        private string[] number; //holds numbers will use a delimeter for '+' or '-', 
        SubtractionProblemSet sub1 ;
        AdditionProblemSet add1;
        //Jungle Selection removed at customer request
        //Jungle thisJungle= new Jungle();
        List<AssignmentSet> handledAssigList = new List<AssignmentSet>();
        AssignmentHandlers _handler= new AssignmentHandlers(); 
        AssignmentSet _mathSetting=new AssignmentSet();
        ListOfReportHandler saveSetting = new ListOfReportHandler(); 
        User _student= new User();
        Report _stdReport = new Report();
        private bool attempted = false;

        private MMControl MMControl;

        /*
         * Time to ask users some Math Questions
         * 
         * */
        public Math_Problem_Screen(MMControl mmControl)
        {
            //Jungle Selection removed at customer request
            //thisJungle = theJungle;
            //_student = student;
            
           
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            InitializeComponent();

            MMControl = mmControl;

            handledAssigList= _handler.ReadFile();

            //Font databound and moved to settings
            //lblFeedbackAnswer.Font = new Font("Georgia", 40);

            //ProblemSetting(theJungle, reportList);
            txtInsertAnswer.Select();
            txtInsertAnswer.Focus();

        }

       //Process of updating student report if necessary and closing this form. 
        private void btnExit_Click(object sender, EventArgs e)
        {
            //before closing we need to save the changes thre stuff needs to be save: assgmentComplete, date complete, and grade 
            //double calcGrade;
            //if (attempted == true)
            //{
            //    if (jungle == 1)
            //    {
            //        calcGrade = ((Convert.ToDouble(add1.CorrectSoFar) / Convert.ToDouble(add1.NumberOfProblems)) * 100.00);
            //        //System.Diagnostics.Debug.Write("Grade Calculation:::+> " + add1.CorrectSoFar + "div" + add1.NumberOfProblems +"Gives"+calcGrade);
            //        saveSetting.UpdateReport(_student, calcGrade, thisJungle, _stdReport);
            //    }
            //    else if (jungle == 2)
            //    {
            //        calcGrade = (sub1.CorrectSoFar / sub1.NumberOfProblems) * 100;
            //        //System.Diagnostics.Debug.Write("Grade Calculation:::+> " + sub1.CorrectSoFar + "div" + sub1.NumberOfProblems +"Gives"+ calcGrade);
            //        //System.Diagnostics.Debug.Write("Grade is handler " + calcGrade);
            //        saveSetting.UpdateReport(_student, calcGrade, thisJungle, _stdReport);
            //    }
            //    attempted = false;
            //}
            this.Close();
        }
        //when inputing an answer we wan to make sure user entered number 
        
        private void btnEnterAnswer_Click(object sender, EventArgs e)
        {
            //attempted = true;
            //bool isNumber = false;
            //string theAnswer;
            //if (txtInsertAnswer.Text != "")
            //{
            //    theAnswer = txtInsertAnswer.Text.Replace(" ", "");
               
            //   double.Parse(theAnswer);
                

            //    if ((txtInsertAnswer.Text != "" && isNumber == true))
            //    {

            //        if (jungle == 1) { AddData(theAnswer); }
            //        if (jungle == 2) { SubDatas(theAnswer); }
            //    }
            //}

        }
        //Determines if the student has any problem sets to work on 
        //public void ProblemSetting(Jungle theJungle, List<Report> reportList)
        //{
        //    bool foundFlag = false;
        //    if (reportList.Count == 1 && reportList[0].AssignmentName == "Default")
        //    {
        //        for (int i = 0; i < handledAssigList.Count; i++)
        //        {
        //            if (handledAssigList[i].AssignmentName == "Default")
        //            {
        //                _stdReport = reportList[0];
        //                MathSettings(thisJungle.MathOperation, handledAssigList[i]);
        //                GetProblem();
        //            }
        //        }
        //    }
        //    else if (reportList.Count != 0)
        //    {
        //        for (int x = 0; x < reportList.Count; x++)
        //        {
        //            if (reportList[x].Completed == false)
        //            {
        //                for (int y = 0; y < handledAssigList.Count; y++)
        //                {
        //                    if (reportList[x].AssignmentName == handledAssigList[y].AssignmentName)
        //                    {
        //                        //System.Diagnostics.Debug.Write("New Math Problem setting are for for Bob");
        //                        _stdReport = reportList[x];
        //                        _mathSetting = handledAssigList[y];
        //                        foundFlag = true;
        //                        MathSettings(thisJungle.MathOperation, handledAssigList[y]);
        //                        GetProblem();
        //                    }

        //                }
        //            }
        //        }
        //    }
        //    if (foundFlag == false)
        //    {
        //        MessageBox.Show("No Assigments are Set Now");
        //        this.Close();
        //    }

        //}

        //MathSetting funciton sets necessary information to get the math problem that the student determined to work on
        //public void MathSettings(char MathOperation, AssignmentSet set)
        //{
        //    if (MathOperation == '-')
        //    {
        //        jungle = 2;
        //        lblOperatorSymbol.Text = "-";
        //        sub1 = new SubtractionProblemSet(set.BottomRange, set.TopRange, set.NumberofProblems, set.Goal, set.Attempts);

        //    }
        //    else if (MathOperation == '+')
        //    {
        //        jungle = 1;
        //        lblOperatorSymbol.Text = "+";
        //        add1 = new AdditionProblemSet(set.BottomRange, set.TopRange, set.NumberofProblems, set.Goal, set.Attempts);

        //    }
        //}
        //AddData checks answer for additon
        //private void AddData(string answer)
        //{
        //    if ((add1.CheckAnswer(answer) == true))
        //    {
        //        CorrectAnswer();
        //    }
        //    else
        //    {
        //        IncorrectAnswer();
        //    }
        //}
        ////SubDatas checks anwer for subtraction
        //private void SubDatas(string answer)
        //{
        //    if ((sub1.CheckAnswer(answer) == true))
        //    {
        //        CorrectAnswer();
        //    }
        //    else
        //    {
        //        IncorrectAnswer();
        //    }

        //}
        //continuing function are student feedback on their answer
        //private void CorrectAnswer()
        //{
        //    lblFeedbackAnswer.Text = "Correct";
        //    lblFeedbackAnswer.Font = new Font("Georgia", 35);
        //    preceed += 1;
        //    GetProblem();
        //    txtInsertAnswer.Select();
        //    txtInsertAnswer.Focus();
        //}

        //private void IncorrectAnswer()
        //{
        //    lblFeedbackAnswer.Text = "Good Try";
        //    lblFeedbackAnswer.Font = new Font("Georgia", 35);
        //    preceed += 1;
        //    GetProblem();
        //    txtInsertAnswer.Select();
        //    txtInsertAnswer.Focus();
        //}

        // GetProble(): will go to get the next problem from the subtraction or additon class depending on user's choice using the GetNext() function
        //private void GetProblem()
        //{
        //    if (jungle == 2 && preceed < sub1.NumberOfProblems)
        //    {
        //        txtInsertAnswer.Text = "";
        //        sub1.GetNext();
        //        number = sub1.CurrentProblem.Split('-');
        //        lblNumberA.Text = number[0];
        //        lblNumberB.Text = number[1];
        //    }
        //    else if (jungle == 1 && preceed < add1.NumberOfProblems)
        //    {
        //        txtInsertAnswer.Text = "";
        //        add1.GetNext();
        //        number = add1.CurrentProblem.Split('+');
        //        lblNumberA.Text = number[0];
        //        lblNumberB.Text = number[1];
        //    }
        //    if (jungle == 1)
        //    {
        //        if (preceed == add1.NumberOfProblems)
        //        {
        //            txtInsertAnswer.Enabled = false;
        //            btnEnterAnswer.Enabled = false;
        //        }
        //    }
        //    else if (jungle == 2)
        //    {
        //        if (preceed == sub1.NumberOfProblems)
        //        {
        //            txtInsertAnswer.Enabled = false;
        //            btnEnterAnswer.Enabled = false;
        //        }
        //    }
        //}

        private void txtInsertAnswer_TextChanged_1(object sender, EventArgs e)
        {
            this.AcceptButton = btnEnterAnswer;
        }

        /// <summary>
        /// This method take the keypresses in the txtInsertAnswer textbox and only allows [.-0-9] into the textbox.
        /// Created: 13 March 2014
        /// Author: Jonathan Sanborn
        /// </summary>
        /// 
        /// <param name="sender">the object that raised this event</param>
        /// <param name="e">the KeyPressEventArgs of the text box</param>
        private void txtInsertAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.DoubleNumberOnly(sender, e);
        }

        //public void GetUserReport(User student)
        //{
        //    //Report handler "ReadFile" could be implemented by taking the user as a parameter
        //    _fileNameReport = (student.ScreenName + student.ID + ".xml").Replace(" ", "");
        //    ReportList = StudentReport.ReadFile(_fileNameReport);
        //}

        
    }
}
