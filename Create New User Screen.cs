/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: NewUserForm
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
using System.Text.RegularExpressions;

namespace Math_Monkeys
{
    //Coders of this class - Mary Venegas + Jeff Cribben
    public partial class NewUserForm : Form
    {
        ListOfUsersXMLHandler NewUserHandler= new ListOfUsersXMLHandler();
        ListOfReportHandler NewUserReport = new ListOfReportHandler();

        List<string> junglesForNow = new List<string>();
        //Temp varibles that should not be here
        private string jungleName1="The Addition Jungle";
        private string jungleName2 = "The Subtraction Jungle";

        public NewUserForm()
        {
            InitializeComponent();
            txtNewName.Select();
            txtNewName.Focus();

            junglesForNow.Add(jungleName1);
            junglesForNow.Add(jungleName2);
            for (int i = 0; i < junglesForNow.Count; i++)
            {
                try
                {
                    ddlJungleSelection.Items.Insert(i, junglesForNow[i]);
                }
                catch (ArgumentOutOfRangeException x)
                {
                   
                }
            }

            ddlJungleSelection.SelectedIndex = 0;

        }

        static string CleanInput(string strIn)
        {
            Match match = Regex.Match(strIn, @"[0-9a-zA-Z-.'_]+");
            return match.ToString();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            
            if(txtNewName.Text!= "")
            {
                string Name = (txtNewName.Text).Trim();
                Name = CleanInput(Name);
               int Userid= AddNametoDoc(Name);
                //NewUserHandler.GetId(Name)
                NewUserReport.CreateNewXmlReport(Name, Userid-1, ddlJungleSelection.SelectedItem.ToString());
            }
        
            else{
                //nothing for now
            }
            //need to verify that this name has correct caracters
            this.Close();
        }
        private int  AddNametoDoc(string Name)
        {
            
            NewUserHandler.WriteFile("ListOfUsers.xml",Name);
            return NewUserHandler.getCount("ListOfUsers.xml");
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

    }
}
