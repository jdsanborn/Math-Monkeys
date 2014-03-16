namespace Math_Monkeys
{
    partial class Math_Problem_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Math_Problem_Screen));
            this.lblOperatorSymbol = new System.Windows.Forms.Label();
            this.imgMathMonkeys = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxMathProblem = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblProblemSet = new System.Windows.Forms.Label();
            this.btnEnterAnswer = new System.Windows.Forms.Button();
            this.txtInsertAnswer = new System.Windows.Forms.TextBox();
            this.lblFeedbackAnswer = new System.Windows.Forms.Label();
            this.lblNumberA = new System.Windows.Forms.Label();
            this.lblNumberB = new System.Windows.Forms.Label();
            this.lblProblemBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).BeginInit();
            this.gbxMathProblem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOperatorSymbol
            // 
            this.lblOperatorSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperatorSymbol.AutoSize = true;
            this.lblOperatorSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorSymbol.Location = new System.Drawing.Point(59, 112);
            this.lblOperatorSymbol.Name = "lblOperatorSymbol";
            this.lblOperatorSymbol.Size = new System.Drawing.Size(88, 91);
            this.lblOperatorSymbol.TabIndex = 5;
            this.lblOperatorSymbol.Text = ":(";
            this.lblOperatorSymbol.Click += new System.EventHandler(this.lblOperatorSymbol_Click);
            // 
            // imgMathMonkeys
            // 
            this.imgMathMonkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMathMonkeys.Image = global::Math_Monkeys.Properties.Resources.Math_Monkeys_Logo_2;
            this.imgMathMonkeys.Location = new System.Drawing.Point(1196, 12);
            this.imgMathMonkeys.Name = "imgMathMonkeys";
            this.imgMathMonkeys.Size = new System.Drawing.Size(151, 113);
            this.imgMathMonkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMathMonkeys.TabIndex = 6;
            this.imgMathMonkeys.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1131, 1106);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(216, 68);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxMathProblem
            // 
            this.gbxMathProblem.AutoSize = true;
            this.gbxMathProblem.Controls.Add(this.btnEnterAnswer);
            this.gbxMathProblem.Controls.Add(this.txtInsertAnswer);
            this.gbxMathProblem.Controls.Add(this.lblFeedbackAnswer);
            this.gbxMathProblem.Controls.Add(this.lblNumberA);
            this.gbxMathProblem.Controls.Add(this.lblNumberB);
            this.gbxMathProblem.Controls.Add(this.lblOperatorSymbol);
            this.gbxMathProblem.Controls.Add(this.lblProblemBar);
            this.gbxMathProblem.Location = new System.Drawing.Point(439, 104);
            this.gbxMathProblem.Name = "gbxMathProblem";
            this.gbxMathProblem.Size = new System.Drawing.Size(481, 598);
            this.gbxMathProblem.TabIndex = 10;
            this.gbxMathProblem.TabStop = false;
            this.gbxMathProblem.Enter += new System.EventHandler(this.gbxMathProblem_Enter);
            // 
            // lblProblemSet
            // 
            this.lblProblemSet.AutoSize = true;
            this.lblProblemSet.Font = global::Math_Monkeys.Properties.Settings.Default.studentFont;
            this.lblProblemSet.Location = new System.Drawing.Point(12, 9);
            this.lblProblemSet.Name = "lblProblemSet";
            this.lblProblemSet.Size = new System.Drawing.Size(405, 90);
            this.lblProblemSet.TabIndex = 11;
            this.lblProblemSet.Text = "Problem Set";
            // 
            // btnEnterAnswer
            // 
            this.btnEnterAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterAnswer.AutoSize = true;
            this.btnEnterAnswer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnterAnswer.Font = global::Math_Monkeys.Properties.Settings.Default.studentFont;
            this.btnEnterAnswer.Location = new System.Drawing.Point(117, 351);
            this.btnEnterAnswer.MaximumSize = new System.Drawing.Size(375, 164);
            this.btnEnterAnswer.MinimumSize = new System.Drawing.Size(216, 68);
            this.btnEnterAnswer.Name = "btnEnterAnswer";
            this.btnEnterAnswer.Size = new System.Drawing.Size(261, 100);
            this.btnEnterAnswer.TabIndex = 0;
            this.btnEnterAnswer.Text = "Submit";
            this.btnEnterAnswer.UseVisualStyleBackColor = true;
            this.btnEnterAnswer.Click += new System.EventHandler(this.btnEnterAnswer_Click);
            // 
            // txtInsertAnswer
            // 
            this.txtInsertAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsertAnswer.Font = global::Math_Monkeys.Properties.Settings.Default.studentFont;
            this.txtInsertAnswer.Location = new System.Drawing.Point(117, 240);
            this.txtInsertAnswer.MaxLength = 5;
            this.txtInsertAnswer.Name = "txtInsertAnswer";
            this.txtInsertAnswer.Size = new System.Drawing.Size(258, 97);
            this.txtInsertAnswer.TabIndex = 9;
            this.txtInsertAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInsertAnswer.TextChanged += new System.EventHandler(this.txtInsertAnswer_TextChanged_1);
            this.txtInsertAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsertAnswer_KeyPress);
            // 
            // lblFeedbackAnswer
            // 
            this.lblFeedbackAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeedbackAnswer.AutoSize = true;
            this.lblFeedbackAnswer.Font = global::Math_Monkeys.Properties.Settings.Default.studentFont;
            this.lblFeedbackAnswer.Location = new System.Drawing.Point(76, 462);
            this.lblFeedbackAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedbackAnswer.Name = "lblFeedbackAnswer";
            this.lblFeedbackAnswer.Size = new System.Drawing.Size(343, 90);
            this.lblFeedbackAnswer.TabIndex = 8;
            this.lblFeedbackAnswer.Text = "Good Luck";
            // 
            // lblNumberA
            // 
            this.lblNumberA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberA.AutoSize = true;
            this.lblNumberA.Font = global::Math_Monkeys.Properties.Settings.Default.studentFont;
            this.lblNumberA.Location = new System.Drawing.Point(131, 17);
            this.lblNumberA.Name = "lblNumberA";
            this.lblNumberA.Size = new System.Drawing.Size(233, 90);
            this.lblNumberA.TabIndex = 1;
            this.lblNumberA.Text = "88888";
            this.lblNumberA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumberB
            // 
            this.lblNumberB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberB.AutoSize = true;
            this.lblNumberB.Font = global::Math_Monkeys.Properties.Settings.Default.studentFont;
            this.lblNumberB.Location = new System.Drawing.Point(131, 123);
            this.lblNumberB.Name = "lblNumberB";
            this.lblNumberB.Size = new System.Drawing.Size(233, 90);
            this.lblNumberB.TabIndex = 3;
            this.lblNumberB.Text = "88888";
            this.lblNumberB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNumberB.Click += new System.EventHandler(this.lblNumberB_Click);
            // 
            // lblProblemBar
            // 
            this.lblProblemBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProblemBar.AutoSize = true;
            this.lblProblemBar.BackColor = System.Drawing.SystemColors.Control;
            this.lblProblemBar.Font = global::Math_Monkeys.Properties.Settings.Default.studentFont;
            this.lblProblemBar.Location = new System.Drawing.Point(68, 151);
            this.lblProblemBar.Margin = new System.Windows.Forms.Padding(0);
            this.lblProblemBar.Name = "lblProblemBar";
            this.lblProblemBar.Size = new System.Drawing.Size(358, 90);
            this.lblProblemBar.TabIndex = 4;
            this.lblProblemBar.Text = "________";
            // 
            // Math_Problem_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 685);
            this.Controls.Add(this.lblProblemSet);
            this.Controls.Add(this.gbxMathProblem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.imgMathMonkeys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(535, 288);
            this.Name = "Math_Problem_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Monkeys - Problem Set";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Math_Problem_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).EndInit();
            this.gbxMathProblem.ResumeLayout(false);
            this.gbxMathProblem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterAnswer;
        private System.Windows.Forms.Label lblNumberA;
        private System.Windows.Forms.Label lblNumberB;
        private System.Windows.Forms.Label lblProblemBar;
        private System.Windows.Forms.Label lblOperatorSymbol;
        private System.Windows.Forms.PictureBox imgMathMonkeys;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFeedbackAnswer;
        private System.Windows.Forms.TextBox txtInsertAnswer;
        private System.Windows.Forms.GroupBox gbxMathProblem;
        private System.Windows.Forms.Label lblProblemSet;
        private System.Windows.Forms.FontDialog fontDialog1;

    }
}