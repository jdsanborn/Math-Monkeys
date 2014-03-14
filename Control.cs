/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Cotrol 
 * intented to unite all forms in one class
 * as of March 2, not implemented yet. 
 * March 3, 2014 Modified by Mary Venegas
 * implementing a control class to fit all forms in the application 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Math_Monkeys
{
    //Coder of this class - Mary Venegas
    public class Control//: FrameworkElement
    {
        private string _Message;
        List<User> AllUserList = new List<User>();
        List<AssignmentSet> AllAssignmentList = new List<AssignmentSet>();
        List<Jungle> Jungles = new List<Jungle>();
        //Math Sets
        AdditionProblemSet addition = new AdditionProblemSet();
        SubtractionProblemSet subtraction = new SubtractionProblemSet();

        public Control()
        {
            //default
        }
        //Loging Form 
        // return a list of existent user
        public List<User> GetUsers()
        {
            return AllUserList;
        }
        //Messge to Return 
        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        //

        //

        //

    }
}
