/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Cotrol 
 * intented to unite all forms in one class
 * as of March 2, not implemented yet. 
 * March 3, 2014 Modified by Mary Venegas
 * implementing a control class to fit all forms in the application
 * 
 * March 16, 2014 
 * implementing control class as progam controller
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Math_Monkeys
{
    
    public class MMControl //: FrameworkElement
    {
        //private string _Message;
        
        List<AssignmentSet> AllAssignmentList;
        private User currentUser;

        //List<Jungle> Jungles = new List<Jungle>();
        //Math Sets
        //AdditionProblemSet addition = new AdditionProblemSet();
        //SubtractionProblemSet subtraction = new SubtractionProblemSet();
        private frmLogin LoginForm;
        private Admin_Control AdminForm;
        private Math_Problem_Screen StudentForm;

        private List<User> allUserList;
        private Classes.FileHandler FileHandler;

        public List<User> AllUserList
        {
            get { return allUserList; }
            set { allUserList = value; }
        }

        public MMControl()
        {
            FileHandler = new Classes.FileHandler();
            allUserList = FileHandler.GetAllUsers();
            //default
        }

        public void SelectionChanged(object sender, EventArgs e)
        {
            ComboBox changed = sender as ComboBox;

           currentUser = (User) changed.SelectedValue;
        }

        public void Login(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                ////NEED SOME CODE HERE
            }
            else
            {
                LoginForm.Hide();
                if (currentUser.UserType == UserType.Student)
                {
                    StudentForm = new Math_Problem_Screen(currentUser);
                    StudentForm.ShowDialog();
                }
                else if (currentUser.UserType == UserType.Administrator)
                {
                    AdminForm = new Admin_Control(currentUser);
                    AdminForm.ShowDialog();
                }
            }
        }

        public void LoginFormClosing(object sender, EventArgs e)
        {

        }

        public int RunProgram()
        {
            LoginForm = new frmLogin(this);
            LoginForm.ShowDialog();

            return 0;
        }


        private void displayLoginForm()
        {

        }

        ////Loging Form 
        //// return a list of existent user
        //public List<User> GetUsers()
        //{
        //    return AllUserList;
        //}


        ////Messge to Return 
        //public string Message
        //{
        //    get
        //    {
        //        return _Message;
        //    }
        //    set
        //    {
        //        _Message = value;
        //    }
        //}

        //

        //

        //

    }
}
