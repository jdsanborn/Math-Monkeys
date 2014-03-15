/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Form1Login
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO; 


namespace Math_Monkeys
{
    // Coder of this class - Mary Venegas + Jeff Cribben
    public partial class Form1Login : Form
    {
        private List<User> EndUserList = new List<User>();
        public bool AdminWorking = false; 
        public Form1Login()
        {

            InitializeComponent();
            //Form1_Load(); 
        }

        public Form1Login(ref User user)
        {
            InitializeComponent();
            // this.ddlUserName = user;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //set time
          this.lblTodayDate.Text = DateTime.Today.ToShortDateString();
          this.lblTodayDate.Text += " "; 
          this.lblTodayDate.Text +=DateTime.Now.ToShortTimeString();
          updateDdlist();
          

        }
        //when begin button is hit we determine which user was chosen and they applay the correct action
        //if admin type open the admin application, else if enduser open the math session
        private void btnBegin_Click(object sender, EventArgs e)
        {
            int reset=0;
            if((ddlUserName.SelectedIndex) != -1)
            {
            for (int i=reset; i < EndUserList.Count; i++)
            {
                try
                {
                    if (ddlUserName.SelectedItem.ToString() == EndUserList[i].UserName)
                    {
                        if (EndUserList[i].UserType == UserType.Administrator)
                        {
                            AdminWorking = true;
                            i = reset;
                            Admin_Control adminscreen = new Admin_Control(EndUserList[i]);
                            adminscreen.ShowDialog();
                            updateDdlist();
                            AdminWorking = false;
                        }
                        else if (EndUserList[i].UserType == UserType.Student)
                        {
                            Problem_Select_Screen nextscreen = new Problem_Select_Screen(EndUserList[i]);
                            nextscreen.WelcomeLabel = "WELCOME " + EndUserList[i].UserName;
                            nextscreen.ShowDialog();
                        }
                    }
                }
                catch (NullReferenceException x)
                {

                }
            }
            }
        }
        //set the current date in login form 
        public void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTodayDate.Text = DateTime.Today.ToShortDateString();
            this.lblTodayDate.Text += " ";
            this.lblTodayDate.Text += DateTime.Now.ToShortTimeString();

        }
        //Fill out the dropDown list with user accessible to this application
        public void updateDdlist()
        {
            ddlUserName.Items.Clear();
            EndUserList.Clear(); 

            ListOfUsersXMLHandler userHandler = new ListOfUsersXMLHandler();
            
            //List<string> AdminList = userHandler.GetAdminList();
            string filename = "ListOfUsers.xml"; // FILENAME OF LIST OF USERS XML
            EndUserList = userHandler.ReadFile(filename);

            btnBegin.Update();
            for (int i = 0; i < EndUserList.Count; i++)
            {
                try
                {
                    ddlUserName.Items.Insert(i, EndUserList[i].UserName);
                }
                catch (ArgumentOutOfRangeException x)
                {

                }
            }
        }

    }
}
