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
       
        #region Member Varibles

        List<AssignmentSet> AllAssignmentList;
        private User currentUser;

        private frmLogin LoginForm;
        private frmAdminControl AdminForm;
        private Math_Problem_Screen StudentForm;

        private List<User> allUserList;
        private List<Student> studentList;
        private List<Admin> adminList;
        private List<ProblemSet> problemSetList;

        private FileHandler FileHandler;

        #endregion

        #region Properties

        internal List<User> AllUserList
        {
            get {
                allUserList.Sort();
                return allUserList; 
            }
            set { allUserList = value; }
        }

        internal List<Student> StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }

        internal List<Admin> AdminList
        {
            get { return adminList; }
            set { adminList = value; }
        }

        public User CurrentUser
        {
            get
            { return currentUser;}
        }

        internal List<ProblemSet> ProblemSetList
        {
            get
            {
                return problemSetList;
            }
            //set
            //{
            //    problemSetList = value;
            //}
        }

        #endregion

        #region constructors

        private void init()
        {
            FileHandler = new FileHandler();
            AdminList = new List<Admin>();
            StudentList = new List<Student>();
            AllUserList = new List<User>();
        }

        public MMControl()
        {
            List<User> temp;

            init();

            temp = FileHandler.GetUsersByType(UserType.Administrator);
            for(int i = 0; i < temp.Count(); i++)
            {
                 Admin newAdmin = new Admin(temp[i]);
                 AdminList.Add(newAdmin);
                 AllUserList.Add(newAdmin);
            }

            temp = FileHandler.GetUsersByType(UserType.Student);
            for (int i = 0; i < temp.Count(); i++)
            {
                Student newStudent = new Student(temp[i]);
                StudentList.Add(newStudent);
                AllUserList.Add(newStudent);
            }

      }

        #endregion

        #region Event Handlers

        public void LoginSelectionChanged(object sender, EventArgs e)
        {
           ComboBox changed = sender as ComboBox;

           currentUser = (User) changed.SelectedValue;
        }

        public void Login(object sender, EventArgs e)
        {
            LoginUser();

        }

        public void LoginFormClosing(object sender, EventArgs e)
        {

        }

        public void IntNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }

                //in the key is the negative sign and it is not the first charcter ignore it.
                if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                {
                    e.Handled = true;
                }
            }
        }

        public void DoubleNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }

                //If the key is a decimal point and it is the second one ignore it.
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                //in the key is the negative sign and it is not the first charcter ignore it.
                if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                {
                    e.Handled = true;
                }
            }
        }

        public void NameOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) 
                && !char.IsLetterOrDigit(e.KeyChar) 
                && e.KeyChar != '-' 
                && e.KeyChar != '`' 
                && e.KeyChar != '~' 
                && e.KeyChar != ' '
                && e.KeyChar != '.' 
                && e.KeyChar != ','
                && e.KeyChar != '\''
                )
            {
                e.Handled = true;
            }
        }

        public void UserLogout(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Form myForm = btn.FindForm();

            myForm.Hide();
            myForm.Close();

            LoginForm = new frmLogin(this);
            LoginForm.ShowDialog();
        }

        #endregion

        #region Methods

        internal void LoginUser()
        {
            if (currentUser == null)
            {
                ////NEED SOME CODE HERE
            }
            else
            {
                TextBox txtPassword = LoginForm.Controls.Find("txtPassword", true)[0] as TextBox;
                if (AuthenticateUser(CurrentUser, txtPassword.Text))
                {
                    LoginForm.Hide();
                    LoginForm.Close();
                    if (currentUser.UserType == UserType.Student)
                    {
                        StudentForm = new Math_Problem_Screen(this);
                        StudentForm.ShowDialog();
                    }
                    else if (currentUser.UserType == UserType.Administrator)
                    {
                        AdminForm = new frmAdminControl(this);
                        AdminForm.ShowDialog();
                    }
                }

                else
                {
                    txtPassword.Text = string.Empty;
                    MessageBox.Show("Wrong Password", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        internal bool AuthenticateUser(User user, string password)
        {
            if (user.Password != password)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        internal void AddNewStudent(Student newUser)
        {
                       
            AllUserList.Add(newUser);
            StudentList.Add(newUser);
            this.FileHandler.SaveNewUser(newUser);
        }

        internal void AddNewAdmin(Admin newUser)
        {
            AllUserList.Add(newUser);
            AdminList.Add(newUser);
            this.FileHandler.SaveNewUser(newUser);
        }

        internal void AddNewUser(User newUser)
        {
            AllUserList.Add(newUser);
            this.FileHandler.SaveNewUser(newUser);
        }

        internal void AddProblemSet(ProblemSet problemSet)
        {
            ProblemSetList.Add(problemSet);
            this.FileHandler.SaveNewProblemSet(problemSet);
        }

        public int RunProgram()
        {
            LoginForm = new frmLogin(this);
            LoginForm.ShowDialog();

            return 0;
        }

        #endregion


        #region DEPRACATED CODE
        
        //private string _Message;
        //List<Jungle> Jungles = new List<Jungle>();
        //Math Sets
        //AdditionProblemSet addition = new AdditionProblemSet();
        //SubtractionProblemSet subtraction = new SubtractionProblemSet();


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
        #endregion


    }
}
