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
    public partial class frmAdminControl : Form
    {
        private MMControl MMControl;

        public frmAdminControl(MMControl mmControl)
        {
            InitializeComponent();
            MMControl = mmControl;

            lblCurrentTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
            tmrClock.Start();

            dgvStudents.DataSource = mmControl.StudentList;
            dgvStudents.Update();

            lblAdminName.Text = MMControl.CurrentUser.GetFullName;
            lblLoginDate.Text = MMControl.CurrentUser.LastLoginDate.ToString();

            this.btnLogout.Click += new EventHandler(MMControl.UserLogout);
        }

        private void frmAdminControl_Load(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fdAdmin.ShowDialog(this);
            Properties.Settings.Default.Save();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUser();
               
        }

        private void CreateUser()
        {

            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string screenName = txtScreenName.Text;
            string password = txtPassword.Text;
            UserType type;

            bool[] isValid = new bool[5];

            isValid[0] = true;
            isValid[1] = validName(txtFirstName);
            isValid[2] = validName(txtLastName);
            isValid[3] = validName(txtScreenName);
            isValid[4] = validName(txtPassword);
            
            foreach (bool b in isValid)
            {
                if (!b)
                {isValid[0] = false;}
            }

            if (!isValid[0])
            {
                MessageBox.Show("Invaild date detected. Please correct the errors and try again.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rbtStudent.Checked)
                {
                    type = UserType.Student;
                    Student newStudent = new Student(Guid.NewGuid().ToString(), type, fName, lName, screenName, password);
                    MMControl.AddNewStudent(newStudent);
                }
                else if (rbtAdmin.Checked)
                {
                    type = UserType.Administrator;
                    Admin newAdmin = new Admin(Guid.NewGuid().ToString(), type, fName, lName, screenName, password);
                    MMControl.AddNewAdmin(newAdmin);
                }
                else
                {
                    type = UserType.None;
                    User newUser = new User(Guid.NewGuid().ToString(), type, fName, lName, screenName, password);
                    MMControl.AddNewUser(newUser);
                }

                tmrShowLabel.Start();
                lblNewUserCreated.Enabled = true;
                lblNewUserCreated.Visible = true;
                ResetNewUserForm();
                this.Update();
            }
        }

        private void ResetNewUserForm()
        {
            rbtStudent.Checked = true;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtScreenName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private bool validName(object sender)
        {
            bool isValid = true;
            TextBox txtBox = (TextBox) sender;

            if (txtBox.Text == null)
            {
               errorProviderNewUser.SetError(txtBox, "Please Enter A Value");
               isValid = false;
            }
            else if (txtBox.Text.Length < Properties.Settings.Default.NameLengthMin)
            {
                errorProviderNewUser.SetError(txtBox, "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " charcters long.");
                isValid = false;
            }
            else if (txtBox.Text.Length > Properties.Settings.Default.NameLengthMax)
            {
                errorProviderNewUser.SetError(txtBox, "Value is too Long. Value must be less than " + Properties.Settings.Default.NameLengthMax + " charcters long.");
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError(txtBox, string.Empty);
            }
            return isValid;

        }
        
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtScreenName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void CreateProblemSet()
        {
            string name = txtProblemSetName.Text;
            Operation operation;
            bool isValid = false;

            ProblemSet problemSet = new ProblemSet();
            Operand range1 = new Operand();
            Operand range2 = new Operand();

            isValid = validName(txtProblemSetName);

            if (!isValid)
            {
                MessageBox.Show("Problem Set Name is invalid. Please Make the needed corrections and resubmit.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
                range1.rangeMin = int.Parse(txtRangeMin1.Text);
                range1.rangeMax = int.Parse(txtRangeMax1.Text);
                range2.rangeMin = int.Parse(txtRangeMin2.Text);
                range2.rangeMax = int.Parse(txtRangeMax2.Text);

                ////////////////////////////////////////////////////////
                // need to change method to only allow in values
                ////////////////////////////////////////////////////


                if (rbtAddition.Checked)
                { operation = Operation.Addition; }

                else if (rbtSubtraction.Checked)
                { operation = Operation.Subtraction; }

                else if (rbtTimes.Checked)
                { operation = Operation.Multiplication; }

                else if (rbtDivide.Checked)
                { operation = Operation.Division; }

                else
                { operation = Operation.None; }

                problemSet.ID = Guid.NewGuid().ToString();
                problemSet.Name = name;
                problemSet.Operation = operation;
                


            }




        }

        private void tmrShowLabel_Tick(object sender, EventArgs e)
        {
            lblNewUserCreated.Enabled = false;
            lblNewUserCreated.Visible = false;
            this.Update();
            tmrShowLabel.Stop();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
            this.Update();
        }

        private void txtProblemSetName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtRangeMin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtRangeMax1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtRangeMin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtRangeMax2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtProblemSetName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtScreenName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



      


 
    }
}
