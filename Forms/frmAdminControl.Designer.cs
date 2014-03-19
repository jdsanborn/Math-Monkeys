namespace Math_Monkeys
{
    partial class frmAdminControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminControl));
            this.tbcAdmin = new System.Windows.Forms.TabControl();
            this.tbpReports = new System.Windows.Forms.TabPage();
            this.gbxReportDates = new System.Windows.Forms.GroupBox();
            this.dtbEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.clmCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpAssignments = new System.Windows.Forms.TabPage();
            this.tbpStudents = new System.Windows.Forms.TabPage();
            this.gbxCreateNewUser = new System.Windows.Forms.GroupBox();
            this.lblNewUserCreated = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtScreenName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbxUserType = new System.Windows.Forms.GroupBox();
            this.rbtAdmin = new System.Windows.Forms.RadioButton();
            this.rbtStudent = new System.Windows.Forms.RadioButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbpProblemSet = new System.Windows.Forms.TabPage();
            this.gbxCreateProblemSet = new System.Windows.Forms.GroupBox();
            this.lblCreateSet = new System.Windows.Forms.Label();
            this.btnCreateProblemSet = new System.Windows.Forms.Button();
            this.gbxSecondOperand = new System.Windows.Forms.GroupBox();
            this.lblRangeMax2 = new System.Windows.Forms.Label();
            this.txtRangeMax2 = new System.Windows.Forms.TextBox();
            this.lblRangeMin2 = new System.Windows.Forms.Label();
            this.txtRangeMin2 = new System.Windows.Forms.TextBox();
            this.gbxFirstOperand = new System.Windows.Forms.GroupBox();
            this.lblRangeMax1 = new System.Windows.Forms.Label();
            this.txtRangeMax1 = new System.Windows.Forms.TextBox();
            this.lblRangeMin1 = new System.Windows.Forms.Label();
            this.txtRangeMin1 = new System.Windows.Forms.TextBox();
            this.txtProblemSetName = new System.Windows.Forms.TextBox();
            this.gbxOperation = new System.Windows.Forms.GroupBox();
            this.rbtDivide = new System.Windows.Forms.RadioButton();
            this.rbtSubtraction = new System.Windows.Forms.RadioButton();
            this.rbtTimes = new System.Windows.Forms.RadioButton();
            this.rbtAddition = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.ttFrmAdmin = new System.Windows.Forms.ToolTip(this.components);
            this.fdAdmin = new System.Windows.Forms.FontDialog();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.lblLoginDate = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.errorProviderNewUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tmrShowLabel = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbcAdmin.SuspendLayout();
            this.tbpReports.SuspendLayout();
            this.gbxReportDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tbpStudents.SuspendLayout();
            this.gbxCreateNewUser.SuspendLayout();
            this.gbxUserType.SuspendLayout();
            this.tbpProblemSet.SuspendLayout();
            this.gbxCreateProblemSet.SuspendLayout();
            this.gbxSecondOperand.SuspendLayout();
            this.gbxFirstOperand.SuspendLayout();
            this.gbxOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAdmin
            // 
            this.tbcAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcAdmin.Controls.Add(this.tbpReports);
            this.tbcAdmin.Controls.Add(this.tbpAssignments);
            this.tbcAdmin.Controls.Add(this.tbpStudents);
            this.tbcAdmin.Controls.Add(this.tbpProblemSet);
            this.tbcAdmin.Controls.Add(this.tbpSettings);
            this.tbcAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbcAdmin.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbcAdmin.Location = new System.Drawing.Point(36, 114);
            this.tbcAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.SelectedIndex = 0;
            this.tbcAdmin.Size = new System.Drawing.Size(1048, 569);
            this.tbcAdmin.TabIndex = 1;
            // 
            // tbpReports
            // 
            this.tbpReports.Controls.Add(this.gbxReportDates);
            this.tbpReports.Controls.Add(this.dgvReport);
            this.tbpReports.Controls.Add(this.dgvStudents);
            this.tbpReports.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpReports.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbpReports.Location = new System.Drawing.Point(4, 29);
            this.tbpReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpReports.Name = "tbpReports";
            this.tbpReports.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpReports.Size = new System.Drawing.Size(1040, 536);
            this.tbpReports.TabIndex = 0;
            this.tbpReports.Text = "Reports";
            this.tbpReports.UseVisualStyleBackColor = true;
            // 
            // gbxReportDates
            // 
            this.gbxReportDates.Controls.Add(this.dtbEndDate);
            this.gbxReportDates.Controls.Add(this.lblStartDate);
            this.gbxReportDates.Controls.Add(this.lblEndDate);
            this.gbxReportDates.Controls.Add(this.dtpStartDate);
            this.gbxReportDates.Location = new System.Drawing.Point(131, 223);
            this.gbxReportDates.Name = "gbxReportDates";
            this.gbxReportDates.Size = new System.Drawing.Size(674, 76);
            this.gbxReportDates.TabIndex = 6;
            this.gbxReportDates.TabStop = false;
            this.gbxReportDates.Text = "Progress Reports Dates";
            // 
            // dtbEndDate
            // 
            this.dtbEndDate.Location = new System.Drawing.Point(447, 34);
            this.dtbEndDate.Name = "dtbEndDate";
            this.dtbEndDate.Size = new System.Drawing.Size(200, 26);
            this.dtbEndDate.TabIndex = 3;
            this.ttFrmAdmin.SetToolTip(this.dtbEndDate, "The ending date from which you want to see progress reports.");
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblStartDate.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.lblStartDate.Location = new System.Drawing.Point(5, 40);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(87, 20);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(360, 40);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(81, 20);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpStartDate.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.dtpStartDate.Location = new System.Drawing.Point(94, 35);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 26);
            this.dtpStartDate.TabIndex = 2;
            this.ttFrmAdmin.SetToolTip(this.dtpStartDate, "The beginning date from which you want to see progress reports.");
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(7, 336);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(1022, 178);
            this.dgvReport.TabIndex = 1;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToOrderColumns = true;
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCheckBox});
            this.dgvStudents.Location = new System.Drawing.Point(7, 24);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(1019, 164);
            this.dgvStudents.TabIndex = 0;
            // 
            // clmCheckBox
            // 
            this.clmCheckBox.Frozen = true;
            this.clmCheckBox.HeaderText = "";
            this.clmCheckBox.Name = "clmCheckBox";
            // 
            // tbpAssignments
            // 
            this.tbpAssignments.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpAssignments.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbpAssignments.Location = new System.Drawing.Point(4, 29);
            this.tbpAssignments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpAssignments.Name = "tbpAssignments";
            this.tbpAssignments.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpAssignments.Size = new System.Drawing.Size(1077, 802);
            this.tbpAssignments.TabIndex = 1;
            this.tbpAssignments.Text = "Assignments";
            this.tbpAssignments.UseVisualStyleBackColor = true;
            // 
            // tbpStudents
            // 
            this.tbpStudents.Controls.Add(this.gbxCreateNewUser);
            this.tbpStudents.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpStudents.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbpStudents.Location = new System.Drawing.Point(4, 29);
            this.tbpStudents.Name = "tbpStudents";
            this.tbpStudents.Size = new System.Drawing.Size(1077, 802);
            this.tbpStudents.TabIndex = 3;
            this.tbpStudents.Text = "Students";
            this.tbpStudents.UseVisualStyleBackColor = true;
            // 
            // gbxCreateNewUser
            // 
            this.gbxCreateNewUser.Controls.Add(this.lblNewUserCreated);
            this.gbxCreateNewUser.Controls.Add(this.lblAddUser);
            this.gbxCreateNewUser.Controls.Add(this.btnCreateUser);
            this.gbxCreateNewUser.Controls.Add(this.txtPassword);
            this.gbxCreateNewUser.Controls.Add(this.txtScreenName);
            this.gbxCreateNewUser.Controls.Add(this.txtLastName);
            this.gbxCreateNewUser.Controls.Add(this.txtFirstName);
            this.gbxCreateNewUser.Controls.Add(this.gbxUserType);
            this.gbxCreateNewUser.Controls.Add(this.lblPassword);
            this.gbxCreateNewUser.Controls.Add(this.lblScreenName);
            this.gbxCreateNewUser.Controls.Add(this.lblLastName);
            this.gbxCreateNewUser.Controls.Add(this.lblFirstName);
            this.gbxCreateNewUser.Location = new System.Drawing.Point(35, 45);
            this.gbxCreateNewUser.Name = "gbxCreateNewUser";
            this.gbxCreateNewUser.Size = new System.Drawing.Size(479, 300);
            this.gbxCreateNewUser.TabIndex = 0;
            this.gbxCreateNewUser.TabStop = false;
            this.gbxCreateNewUser.Text = "Create A New User";
            // 
            // lblNewUserCreated
            // 
            this.lblNewUserCreated.AutoSize = true;
            this.lblNewUserCreated.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUserCreated.Enabled = false;
            this.lblNewUserCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUserCreated.Image = global::Math_Monkeys.Properties.Resources.apply;
            this.lblNewUserCreated.Location = new System.Drawing.Point(137, 243);
            this.lblNewUserCreated.Name = "lblNewUserCreated";
            this.lblNewUserCreated.Size = new System.Drawing.Size(212, 29);
            this.lblNewUserCreated.TabIndex = 10;
            this.lblNewUserCreated.Text = "New User Created";
            this.lblNewUserCreated.Visible = false;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Location = new System.Drawing.Point(359, 277);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(76, 20);
            this.lblAddUser.TabIndex = 1;
            this.lblAddUser.Text = "Add User";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackgroundImage = global::Math_Monkeys.Properties.Resources.add_user;
            this.btnCreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreateUser.Location = new System.Drawing.Point(355, 222);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(85, 52);
            this.btnCreateUser.TabIndex = 9;
            this.btnCreateUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 190);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(285, 26);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtScreenName
            // 
            this.txtScreenName.Location = new System.Drawing.Point(155, 158);
            this.txtScreenName.MaxLength = 30;
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.Size = new System.Drawing.Size(285, 26);
            this.txtScreenName.TabIndex = 7;
            this.txtScreenName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScreenName_KeyPress);
            this.txtScreenName.Validating += new System.ComponentModel.CancelEventHandler(this.txtScreenName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(155, 126);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(285, 26);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(155, 94);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(285, 26);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // gbxUserType
            // 
            this.gbxUserType.Controls.Add(this.rbtAdmin);
            this.gbxUserType.Controls.Add(this.rbtStudent);
            this.gbxUserType.Location = new System.Drawing.Point(43, 30);
            this.gbxUserType.Name = "gbxUserType";
            this.gbxUserType.Size = new System.Drawing.Size(397, 58);
            this.gbxUserType.TabIndex = 4;
            this.gbxUserType.TabStop = false;
            this.gbxUserType.Text = "User Type";
            // 
            // rbtAdmin
            // 
            this.rbtAdmin.AutoSize = true;
            this.rbtAdmin.Location = new System.Drawing.Point(195, 25);
            this.rbtAdmin.Name = "rbtAdmin";
            this.rbtAdmin.Size = new System.Drawing.Size(121, 24);
            this.rbtAdmin.TabIndex = 1;
            this.rbtAdmin.TabStop = true;
            this.rbtAdmin.Text = "Administrator";
            this.rbtAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtStudent
            // 
            this.rbtStudent.AutoSize = true;
            this.rbtStudent.Checked = true;
            this.rbtStudent.Location = new System.Drawing.Point(74, 25);
            this.rbtStudent.Name = "rbtStudent";
            this.rbtStudent.Size = new System.Drawing.Size(84, 24);
            this.rbtStudent.TabIndex = 0;
            this.rbtStudent.TabStop = true;
            this.rbtStudent.Text = "Student";
            this.rbtStudent.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(67, 193);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.Location = new System.Drawing.Point(39, 161);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(110, 20);
            this.lblScreenName.TabIndex = 2;
            this.lblScreenName.Text = "Screen Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(59, 129);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(59, 97);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbpProblemSet
            // 
            this.tbpProblemSet.Controls.Add(this.gbxCreateProblemSet);
            this.tbpProblemSet.Location = new System.Drawing.Point(4, 29);
            this.tbpProblemSet.Name = "tbpProblemSet";
            this.tbpProblemSet.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProblemSet.Size = new System.Drawing.Size(1077, 802);
            this.tbpProblemSet.TabIndex = 4;
            this.tbpProblemSet.Text = "Problem Sets";
            this.tbpProblemSet.UseVisualStyleBackColor = true;
            // 
            // gbxCreateProblemSet
            // 
            this.gbxCreateProblemSet.Controls.Add(this.lblCreateSet);
            this.gbxCreateProblemSet.Controls.Add(this.btnCreateProblemSet);
            this.gbxCreateProblemSet.Controls.Add(this.gbxSecondOperand);
            this.gbxCreateProblemSet.Controls.Add(this.gbxFirstOperand);
            this.gbxCreateProblemSet.Controls.Add(this.txtProblemSetName);
            this.gbxCreateProblemSet.Controls.Add(this.gbxOperation);
            this.gbxCreateProblemSet.Controls.Add(this.lblName);
            this.gbxCreateProblemSet.Location = new System.Drawing.Point(29, 38);
            this.gbxCreateProblemSet.Name = "gbxCreateProblemSet";
            this.gbxCreateProblemSet.Size = new System.Drawing.Size(433, 447);
            this.gbxCreateProblemSet.TabIndex = 0;
            this.gbxCreateProblemSet.TabStop = false;
            this.gbxCreateProblemSet.Text = "Create Problem Set";
            // 
            // lblCreateSet
            // 
            this.lblCreateSet.AutoSize = true;
            this.lblCreateSet.Location = new System.Drawing.Point(315, 412);
            this.lblCreateSet.Name = "lblCreateSet";
            this.lblCreateSet.Size = new System.Drawing.Size(86, 20);
            this.lblCreateSet.TabIndex = 11;
            this.lblCreateSet.Text = "Create Set";
            // 
            // btnCreateProblemSet
            // 
            this.btnCreateProblemSet.BackgroundImage = global::Math_Monkeys.Properties.Resources.apply;
            this.btnCreateProblemSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreateProblemSet.Location = new System.Drawing.Point(316, 357);
            this.btnCreateProblemSet.Name = "btnCreateProblemSet";
            this.btnCreateProblemSet.Size = new System.Drawing.Size(85, 52);
            this.btnCreateProblemSet.TabIndex = 10;
            this.btnCreateProblemSet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateProblemSet.UseVisualStyleBackColor = true;
            // 
            // gbxSecondOperand
            // 
            this.gbxSecondOperand.Controls.Add(this.lblRangeMax2);
            this.gbxSecondOperand.Controls.Add(this.txtRangeMax2);
            this.gbxSecondOperand.Controls.Add(this.lblRangeMin2);
            this.gbxSecondOperand.Controls.Add(this.txtRangeMin2);
            this.gbxSecondOperand.Location = new System.Drawing.Point(36, 247);
            this.gbxSecondOperand.Name = "gbxSecondOperand";
            this.gbxSecondOperand.Size = new System.Drawing.Size(365, 104);
            this.gbxSecondOperand.TabIndex = 3;
            this.gbxSecondOperand.TabStop = false;
            this.gbxSecondOperand.Text = "Second Operand";
            // 
            // lblRangeMax2
            // 
            this.lblRangeMax2.AutoSize = true;
            this.lblRangeMax2.Location = new System.Drawing.Point(72, 66);
            this.lblRangeMax2.Name = "lblRangeMax2";
            this.lblRangeMax2.Size = new System.Drawing.Size(94, 20);
            this.lblRangeMax2.TabIndex = 3;
            this.lblRangeMax2.Text = "Range Max:";
            // 
            // txtRangeMax2
            // 
            this.txtRangeMax2.Location = new System.Drawing.Point(168, 63);
            this.txtRangeMax2.MaxLength = 5;
            this.txtRangeMax2.Name = "txtRangeMax2";
            this.txtRangeMax2.Size = new System.Drawing.Size(125, 26);
            this.txtRangeMax2.TabIndex = 2;
            this.txtRangeMax2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRangeMax2_KeyPress);
            // 
            // lblRangeMin2
            // 
            this.lblRangeMin2.AutoSize = true;
            this.lblRangeMin2.Location = new System.Drawing.Point(72, 34);
            this.lblRangeMin2.Name = "lblRangeMin2";
            this.lblRangeMin2.Size = new System.Drawing.Size(90, 20);
            this.lblRangeMin2.TabIndex = 1;
            this.lblRangeMin2.Text = "Range Min:";
            // 
            // txtRangeMin2
            // 
            this.txtRangeMin2.Location = new System.Drawing.Point(168, 31);
            this.txtRangeMin2.MaxLength = 5;
            this.txtRangeMin2.Name = "txtRangeMin2";
            this.txtRangeMin2.Size = new System.Drawing.Size(125, 26);
            this.txtRangeMin2.TabIndex = 0;
            this.txtRangeMin2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRangeMin2_KeyPress);
            // 
            // gbxFirstOperand
            // 
            this.gbxFirstOperand.Controls.Add(this.lblRangeMax1);
            this.gbxFirstOperand.Controls.Add(this.txtRangeMax1);
            this.gbxFirstOperand.Controls.Add(this.lblRangeMin1);
            this.gbxFirstOperand.Controls.Add(this.txtRangeMin1);
            this.gbxFirstOperand.Location = new System.Drawing.Point(36, 137);
            this.gbxFirstOperand.Name = "gbxFirstOperand";
            this.gbxFirstOperand.Size = new System.Drawing.Size(365, 104);
            this.gbxFirstOperand.TabIndex = 2;
            this.gbxFirstOperand.TabStop = false;
            this.gbxFirstOperand.Text = "First Operand";
            // 
            // lblRangeMax1
            // 
            this.lblRangeMax1.AutoSize = true;
            this.lblRangeMax1.Location = new System.Drawing.Point(72, 66);
            this.lblRangeMax1.Name = "lblRangeMax1";
            this.lblRangeMax1.Size = new System.Drawing.Size(94, 20);
            this.lblRangeMax1.TabIndex = 3;
            this.lblRangeMax1.Text = "Range Max:";
            // 
            // txtRangeMax1
            // 
            this.txtRangeMax1.Location = new System.Drawing.Point(168, 63);
            this.txtRangeMax1.MaxLength = 5;
            this.txtRangeMax1.Name = "txtRangeMax1";
            this.txtRangeMax1.Size = new System.Drawing.Size(125, 26);
            this.txtRangeMax1.TabIndex = 2;
            this.txtRangeMax1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRangeMax1_KeyPress);
            // 
            // lblRangeMin1
            // 
            this.lblRangeMin1.AutoSize = true;
            this.lblRangeMin1.Location = new System.Drawing.Point(72, 34);
            this.lblRangeMin1.Name = "lblRangeMin1";
            this.lblRangeMin1.Size = new System.Drawing.Size(90, 20);
            this.lblRangeMin1.TabIndex = 1;
            this.lblRangeMin1.Text = "Range Min:";
            // 
            // txtRangeMin1
            // 
            this.txtRangeMin1.Location = new System.Drawing.Point(168, 31);
            this.txtRangeMin1.MaxLength = 5;
            this.txtRangeMin1.Name = "txtRangeMin1";
            this.txtRangeMin1.Size = new System.Drawing.Size(125, 26);
            this.txtRangeMin1.TabIndex = 0;
            this.txtRangeMin1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRangeMin1_KeyPress);
            // 
            // txtProblemSetName
            // 
            this.txtProblemSetName.Location = new System.Drawing.Point(93, 34);
            this.txtProblemSetName.MaxLength = 30;
            this.txtProblemSetName.Name = "txtProblemSetName";
            this.txtProblemSetName.Size = new System.Drawing.Size(308, 26);
            this.txtProblemSetName.TabIndex = 0;
            this.txtProblemSetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProblemSetName_KeyPress);
            this.txtProblemSetName.Validating += new System.ComponentModel.CancelEventHandler(this.txtProblemSetName_Validating);
            // 
            // gbxOperation
            // 
            this.gbxOperation.Controls.Add(this.rbtDivide);
            this.gbxOperation.Controls.Add(this.rbtSubtraction);
            this.gbxOperation.Controls.Add(this.rbtTimes);
            this.gbxOperation.Controls.Add(this.rbtAddition);
            this.gbxOperation.Location = new System.Drawing.Point(36, 66);
            this.gbxOperation.Name = "gbxOperation";
            this.gbxOperation.Size = new System.Drawing.Size(365, 65);
            this.gbxOperation.TabIndex = 1;
            this.gbxOperation.TabStop = false;
            this.gbxOperation.Text = "Operation";
            // 
            // rbtDivide
            // 
            this.rbtDivide.AutoSize = true;
            this.rbtDivide.Image = global::Math_Monkeys.Properties.Resources.Divide;
            this.rbtDivide.Location = new System.Drawing.Point(297, 20);
            this.rbtDivide.Name = "rbtDivide";
            this.rbtDivide.Size = new System.Drawing.Size(46, 32);
            this.rbtDivide.TabIndex = 3;
            this.rbtDivide.UseVisualStyleBackColor = true;
            // 
            // rbtSubtraction
            // 
            this.rbtSubtraction.AutoSize = true;
            this.rbtSubtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtSubtraction.Image = global::Math_Monkeys.Properties.Resources.Subtraction;
            this.rbtSubtraction.Location = new System.Drawing.Point(113, 20);
            this.rbtSubtraction.Name = "rbtSubtraction";
            this.rbtSubtraction.Size = new System.Drawing.Size(46, 32);
            this.rbtSubtraction.TabIndex = 1;
            this.rbtSubtraction.UseVisualStyleBackColor = true;
            // 
            // rbtTimes
            // 
            this.rbtTimes.AutoSize = true;
            this.rbtTimes.Image = global::Math_Monkeys.Properties.Resources.times;
            this.rbtTimes.Location = new System.Drawing.Point(205, 20);
            this.rbtTimes.Name = "rbtTimes";
            this.rbtTimes.Size = new System.Drawing.Size(46, 32);
            this.rbtTimes.TabIndex = 2;
            this.rbtTimes.UseVisualStyleBackColor = true;
            // 
            // rbtAddition
            // 
            this.rbtAddition.AutoSize = true;
            this.rbtAddition.Checked = true;
            this.rbtAddition.Image = global::Math_Monkeys.Properties.Resources.Plus;
            this.rbtAddition.Location = new System.Drawing.Point(21, 20);
            this.rbtAddition.Name = "rbtAddition";
            this.rbtAddition.Size = new System.Drawing.Size(46, 32);
            this.rbtAddition.TabIndex = 0;
            this.rbtAddition.TabStop = true;
            this.rbtAddition.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tbpSettings
            // 
            this.tbpSettings.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpSettings.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbpSettings.Location = new System.Drawing.Point(4, 29);
            this.tbpSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpSettings.Size = new System.Drawing.Size(1077, 802);
            this.tbpSettings.TabIndex = 2;
            this.tbpSettings.Text = "Settings";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // ttFrmAdmin
            // 
            this.ttFrmAdmin.IsBalloon = true;
            // 
            // fdAdmin
            // 
            this.fdAdmin.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.fdAdmin.FontMustExist = true;
            this.fdAdmin.MaxSize = 20;
            this.fdAdmin.MinSize = 8;
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(1026, 1006);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(59, 20);
            this.lblLogout.TabIndex = 3;
            this.lblLogout.Text = "Logout";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackgroundImage = global::Math_Monkeys.Properties.Resources.exit;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnLogout.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.btnLogout.Location = new System.Drawing.Point(1013, 951);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 52);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Administrator Control";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(13, 61);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(79, 20);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome:";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(98, 61);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(129, 20);
            this.lblAdminName.TabIndex = 6;
            this.lblAdminName.Text = "<ADMIN NAME>";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLogin.Location = new System.Drawing.Point(33, 81);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(59, 13);
            this.lblLastLogin.TabIndex = 7;
            this.lblLastLogin.Text = "Last Login:";
            // 
            // lblLoginDate
            // 
            this.lblLoginDate.AutoSize = true;
            this.lblLoginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginDate.Location = new System.Drawing.Point(100, 81);
            this.lblLoginDate.Name = "lblLoginDate";
            this.lblLoginDate.Size = new System.Drawing.Size(141, 13);
            this.lblLoginDate.TabIndex = 8;
            this.lblLoginDate.Text = " MM/DD/YYYY HH:MM PM";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(663, 36);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(436, 20);
            this.lblCurrentTime.TabIndex = 9;
            this.lblCurrentTime.Text = "WEDNESDAY, DECEMBERERERE DD, YYYY HH:MM PM";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProviderNewUser
            // 
            this.errorProviderNewUser.ContainerControl = this;
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 10000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // tmrShowLabel
            // 
            this.tmrShowLabel.Interval = 2500;
            this.tmrShowLabel.Tick += new System.EventHandler(this.tmrShowLabel_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1111, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 741);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblLoginDate);
            this.Controls.Add(this.lblLastLogin);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tbcAdmin);
            this.Controls.Add(this.menuStrip1);
            this.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminControl";
            this.Text = "Math Monkeys - Admin Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminControl_Load);
            this.tbcAdmin.ResumeLayout(false);
            this.tbpReports.ResumeLayout(false);
            this.gbxReportDates.ResumeLayout(false);
            this.gbxReportDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tbpStudents.ResumeLayout(false);
            this.gbxCreateNewUser.ResumeLayout(false);
            this.gbxCreateNewUser.PerformLayout();
            this.gbxUserType.ResumeLayout(false);
            this.gbxUserType.PerformLayout();
            this.tbpProblemSet.ResumeLayout(false);
            this.gbxCreateProblemSet.ResumeLayout(false);
            this.gbxCreateProblemSet.PerformLayout();
            this.gbxSecondOperand.ResumeLayout(false);
            this.gbxSecondOperand.PerformLayout();
            this.gbxFirstOperand.ResumeLayout(false);
            this.gbxFirstOperand.PerformLayout();
            this.gbxOperation.ResumeLayout(false);
            this.gbxOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAdmin;
        private System.Windows.Forms.TabPage tbpReports;
        private System.Windows.Forms.TabPage tbpAssignments;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.GroupBox gbxReportDates;
        private System.Windows.Forms.DateTimePicker dtbEndDate;
        private System.Windows.Forms.ToolTip ttFrmAdmin;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TabPage tbpStudents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FontDialog fdAdmin;
        private System.Windows.Forms.GroupBox gbxCreateNewUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtScreenName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbxUserType;
        private System.Windows.Forms.RadioButton rbtAdmin;
        private System.Windows.Forms.RadioButton rbtStudent;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.TabPage tbpProblemSet;
        private System.Windows.Forms.GroupBox gbxCreateProblemSet;
        private System.Windows.Forms.GroupBox gbxOperation;
        private System.Windows.Forms.RadioButton rbtDivide;
        private System.Windows.Forms.RadioButton rbtSubtraction;
        private System.Windows.Forms.RadioButton rbtAddition;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbtTimes;
        private System.Windows.Forms.Button btnCreateProblemSet;
        private System.Windows.Forms.GroupBox gbxSecondOperand;
        private System.Windows.Forms.Label lblRangeMax2;
        private System.Windows.Forms.TextBox txtRangeMax2;
        private System.Windows.Forms.Label lblRangeMin2;
        private System.Windows.Forms.TextBox txtRangeMin2;
        private System.Windows.Forms.GroupBox gbxFirstOperand;
        private System.Windows.Forms.Label lblRangeMax1;
        private System.Windows.Forms.TextBox txtRangeMax1;
        private System.Windows.Forms.Label lblRangeMin1;
        private System.Windows.Forms.TextBox txtRangeMin1;
        private System.Windows.Forms.TextBox txtProblemSetName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmCheckBox;
        private System.Windows.Forms.Label lblCreateSet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Label lblLoginDate;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.ErrorProvider errorProviderNewUser;
        private System.Windows.Forms.Label lblNewUserCreated;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Timer tmrShowLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}