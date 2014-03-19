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
            this.ddlUserName = new System.Windows.Forms.ComboBox();
            this.lblPleaseChoose = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMathMonkeys
            // 
            this.imgMathMonkeys.Image = global::Math_Monkeys.Properties.Resources.Math_Monkeys_Logo_2;
            this.imgMathMonkeys.Location = new System.Drawing.Point(99, 105);
            this.imgMathMonkeys.Name = "imgMathMonkeys";
            this.imgMathMonkeys.Size = new System.Drawing.Size(336, 194);
            this.imgMathMonkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMathMonkeys.TabIndex = 0;
            this.imgMathMonkeys.TabStop = false;
            this.imgMathMonkeys.Click += new System.EventHandler(this.imgMathMonkeys_Click);
            // 
            // ddlUserName
            // 
            this.ddlUserName.BackColor = System.Drawing.SystemColors.Window;
            this.ddlUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlUserName.FormattingEnabled = true;
            this.ddlUserName.Location = new System.Drawing.Point(42, 338);
            this.ddlUserName.Name = "ddlUserName";
            this.ddlUserName.Size = new System.Drawing.Size(450, 41);
            this.ddlUserName.TabIndex = 0;
            // 
            // lblPleaseChoose
            // 
            this.lblPleaseChoose.AutoSize = true;
            this.lblPleaseChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseChoose.Location = new System.Drawing.Point(93, 302);
            this.lblPleaseChoose.Name = "lblPleaseChoose";
            this.lblPleaseChoose.Size = new System.Drawing.Size(368, 33);
            this.lblPleaseChoose.TabIndex = 2;
            this.lblPleaseChoose.Text = "Please Choose Your Name";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(42, 385);
            this.btnBegin.MaximumSize = new System.Drawing.Size(450, 68);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(450, 68);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Login";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.Location = new System.Drawing.Point(116, 69);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(307, 33);
            this.lblTodayDate.TabIndex = 4;
            this.lblTodayDate.Text = "MM/DD/YYYY HH:MM";
            this.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 10000;
            this.tmrClock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblPleaseChoose);
            this.Controls.Add(this.ddlUserName);
            this.Controls.Add(this.imgMathMonkeys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 500);
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
    }
}

