/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: EndUser , implements from User class
 * has a name, an id, and a type 
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{
    public class Student : User
    {
        //List of report function
        List<Report> rep1 = new List<Report>();

        private List<Assignment> assigments;
        private List<AssignmentAttempt> assignmentAttempt;

        
        internal List<Assignment> Assignments
        {
            get { return assigments; }
            set { assigments = value; }
        }
           
        
        internal List<AssignmentAttempt> AssignmentAttempt
        {
            get { return assignmentAttempt; }
            set { assignmentAttempt = value; }
        }
        
        

        //List of problem sets
        //List<ProblemSetGenerator> prl
        //

        private void init()
        {
            this.UserType = UserType.Student;
        }

        public Student():base()
        {
            init();
        }

        public Student(string id, UserType userType, string fistName, string lastName, string screenName, string password)
            :base(id, userType, fistName, lastName, screenName, password )
        {
            init();
        }

        public Student(User user): base()
        {
            init();
            this.ID = user.ID;
            this.UserType = user.UserType;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.ScreenName = user.ScreenName;
            this.Password = user.Password;
            this.LastLoginDate = user.LastLoginDate;
        }

        //loads reports from the user file
        private void LoadProgress()
        {

        }

        // make a report object  
        private void SaveProgress()
        {
            //would append to the list 

        }

        //14 March 2014 Jonathan Sanborn: User Type implmented in the User class 
        //
        //public string GetUserType()
        //{
        //    return "EndUser";
        //}

        //add correct problem set or modify existing problem set making sure that not 
        protected void AddProblemSet(string problemSetName)
        {

        }
    }
}
