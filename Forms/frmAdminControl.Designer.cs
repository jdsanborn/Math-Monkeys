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
            this.tbpAssignments = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbpStudents = new System.Windows.Forms.TabPage();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ttFrmAdmin = new System.Windows.Forms.ToolTip(this.components);
            this.fdAdmin = new System.Windows.Forms.FontDialog();
            this.tbcAdmin.SuspendLayout();
            this.tbpReports.SuspendLayout();
            this.gbxReportDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tbpAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tbcAdmin.Controls.Add(this.tbpSettings);
            this.tbcAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbcAdmin.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbcAdmin.Location = new System.Drawing.Point(13, 108);
            this.tbcAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.SelectedIndex = 0;
            this.tbcAdmin.Size = new System.Drawing.Size(1078, 904);
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
            this.tbpReports.Size = new System.Drawing.Size(1070, 871);
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
            this.gbxReportDates.Location = new System.Drawing.Point(180, 316);
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
            this.dgvReport.Location = new System.Drawing.Point(3, 398);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(1059, 423);
            this.dgvReport.TabIndex = 1;
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(7, 37);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(1056, 242);
            this.dgvStudents.TabIndex = 0;
            // 
            // tbpAssignments
            // 
            this.tbpAssignments.Controls.Add(this.dataGridView1);
            this.tbpAssignments.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpAssignments.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbpAssignments.Location = new System.Drawing.Point(4, 29);
            this.tbpAssignments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpAssignments.Name = "tbpAssignments";
            this.tbpAssignments.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpAssignments.Size = new System.Drawing.Size(1070, 871);
            this.tbpAssignments.TabIndex = 1;
            this.tbpAssignments.Text = "Assignments";
            this.tbpAssignments.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1056, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbpStudents
            // 
            this.tbpStudents.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpStudents.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbpStudents.Location = new System.Drawing.Point(4, 29);
            this.tbpStudents.Name = "tbpStudents";
            this.tbpStudents.Size = new System.Drawing.Size(1070, 871);
            this.tbpStudents.TabIndex = 3;
            this.tbpStudents.Text = "Students";
            this.tbpStudents.UseVisualStyleBackColor = true;
            // 
            // tbpSettings
            // 
            this.tbpSettings.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpSettings.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.tbpSettings.Location = new System.Drawing.Point(4, 29);
            this.tbpSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpSettings.Size = new System.Drawing.Size(1070, 871);
            this.tbpSettings.TabIndex = 2;
            this.tbpSettings.Text = "Settings";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "adminFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnLogout.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.btnLogout.Location = new System.Drawing.Point(927, 1023);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(151, 38);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
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
            this.fdAdmin.Apply += new System.EventHandler(this.fdAdmin_Apply);
            // 
            // frmAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 1073);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tbcAdmin);
            this.Font = global::Math_Monkeys.Properties.Settings.Default.adminFont;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.tbpAssignments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tbpStudents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FontDialog fdAdmin;
    }
}