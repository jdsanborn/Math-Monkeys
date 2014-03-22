namespace Math_Monkeys
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.imgMathMonkeys = new System.Windows.Forms.PictureBox();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblPleaseChoose = new System.Windows.Forms.Label();
            this.ddlUserName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMathMonkeys
            // 
            this.imgMathMonkeys.Image = global::Math_Monkeys.Properties.Resources.Math_Monkeys_Logo_2;
            this.imgMathMonkeys.Location = new System.Drawing.Point(194, 106);
            this.imgMathMonkeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgMathMonkeys.Name = "imgMathMonkeys";
            this.imgMathMonkeys.Size = new System.Drawing.Size(504, 298);
            this.imgMathMonkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMathMonkeys.TabIndex = 0;
            this.imgMathMonkeys.TabStop = false;
            this.imgMathMonkeys.Click += new System.EventHandler(this.imgMathMonkeys_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 10000;
            this.tmrClock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFormFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFormFont;
            this.txtPassword.Location = new System.Drawing.Point(109, 557);
            this.txtPassword.MaxLength = global::Math_Monkeys.Properties.Settings.Default.NameLengthMax;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(673, 57);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFormFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTitle.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFormFont;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 52);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Login";
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFormFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTodayDate.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFormFont;
            this.lblTodayDate.Location = new System.Drawing.Point(220, 49);
            this.lblTodayDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(463, 52);
            this.lblTodayDate.TabIndex = 4;
            this.lblTodayDate.Text = "MM/DD/YYYY HH:MM";
            this.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBegin
            // 
            this.btnBegin.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFormFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBegin.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFormFont;
            this.btnBegin.Location = new System.Drawing.Point(109, 630);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBegin.MaximumSize = new System.Drawing.Size(675, 105);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(675, 105);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Login";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblPleaseChoose
            // 
            this.lblPleaseChoose.AutoSize = true;
            this.lblPleaseChoose.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFormFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPleaseChoose.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFormFont;
            this.lblPleaseChoose.Location = new System.Drawing.Point(171, 409);
            this.lblPleaseChoose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPleaseChoose.Name = "lblPleaseChoose";
            this.lblPleaseChoose.Size = new System.Drawing.Size(551, 52);
            this.lblPleaseChoose.TabIndex = 2;
            this.lblPleaseChoose.Text = "Please Choose Your Name";
            // 
            // ddlUserName
            // 
            this.ddlUserName.BackColor = System.Drawing.SystemColors.Window;
            this.ddlUserName.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFormFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ddlUserName.DropDownHeight = 165;
            this.ddlUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUserName.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFormFont;
            this.ddlUserName.FormattingEnabled = true;
            this.ddlUserName.IntegralHeight = false;
            this.ddlUserName.ItemHeight = 52;
            this.ddlUserName.Location = new System.Drawing.Point(109, 481);
            this.ddlUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlUserName.MaxDropDownItems = 5;
            this.ddlUserName.Name = "ddlUserName";
            this.ddlUserName.Size = new System.Drawing.Size(673, 60);
            this.ddlUserName.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 785);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblPleaseChoose);
            this.Controls.Add(this.ddlUserName);
            this.Controls.Add(this.imgMathMonkeys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(914, 840);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(914, 840);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Monkeys - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMathMonkeys;
        private System.Windows.Forms.Label lblPleaseChoose;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.ComboBox ddlUserName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

