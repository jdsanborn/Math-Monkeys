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
            this.btnEnterAnswer = new System.Windows.Forms.Button();
            this.lblNumberA = new System.Windows.Forms.Label();
            this.lblNumberB = new System.Windows.Forms.Label();
            this.lblProblemBar = new System.Windows.Forms.Label();
            this.lblOperatorSymbol = new System.Windows.Forms.Label();
            this.imgMathMonkeys = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFeedbackAnswer = new System.Windows.Forms.Label();
            this.txtInsertAnswer = new System.Windows.Forms.TextBox();
            this.gbxMathProblem = new System.Windows.Forms.GroupBox();
            this.lblProblemSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).BeginInit();
            this.gbxMathProblem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnterAnswer
            // 
            this.btnEnterAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterAnswer.Location = new System.Drawing.Point(58, 263);
            this.btnEnterAnswer.MaximumSize = new System.Drawing.Size(375, 164);
            this.btnEnterAnswer.MinimumSize = new System.Drawing.Size(216, 68);
            this.btnEnterAnswer.Name = "btnEnterAnswer";
            this.btnEnterAnswer.Size = new System.Drawing.Size(216, 68);
            this.btnEnterAnswer.TabIndex = 0;
            this.btnEnterAnswer.Text = "Submit";
            this.btnEnterAnswer.UseVisualStyleBackColor = true;
            this.btnEnterAnswer.Click += new System.EventHandler(this.btnEnterAnswer_Click);
            // 
            // lblNumberA
            // 
            this.lblNumberA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNumberA.AutoSize = true;
            this.lblNumberA.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberA.Location = new System.Drawing.Point(170, 35);
            this.lblNumberA.Name = "lblNumberA";
            this.lblNumberA.Size = new System.Drawing.Size(87, 63);
            this.lblNumberA.TabIndex = 1;
            this.lblNumberA.Text = "11";
            this.lblNumberA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumberB
            // 
            this.lblNumberB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNumberB.AutoSize = true;
            this.lblNumberB.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberB.Location = new System.Drawing.Point(170, 103);
            this.lblNumberB.Name = "lblNumberB";
            this.lblNumberB.Size = new System.Drawing.Size(87, 63);
            this.lblNumberB.TabIndex = 3;
            this.lblNumberB.Text = "11";
            this.lblNumberB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProblemBar
            // 
            this.lblProblemBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblProblemBar.AutoSize = true;
            this.lblProblemBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemBar.Location = new System.Drawing.Point(58, 161);
            this.lblProblemBar.Name = "lblProblemBar";
            this.lblProblemBar.Size = new System.Drawing.Size(221, 25);
            this.lblProblemBar.TabIndex = 4;
            this.lblProblemBar.Text = "___________________";
            // 
            // lblOperatorSymbol
            // 
            this.lblOperatorSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblOperatorSymbol.AutoSize = true;
            this.lblOperatorSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorSymbol.Location = new System.Drawing.Point(47, 78);
            this.lblOperatorSymbol.Name = "lblOperatorSymbol";
            this.lblOperatorSymbol.Size = new System.Drawing.Size(88, 91);
            this.lblOperatorSymbol.TabIndex = 5;
            this.lblOperatorSymbol.Text = ":(";
            // 
            // imgMathMonkeys
            // 
            this.imgMathMonkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMathMonkeys.Image = global::Math_Monkeys.Properties.Resources.mathmonkeyslogo2;
            this.imgMathMonkeys.Location = new System.Drawing.Point(628, 12);
            this.imgMathMonkeys.Name = "imgMathMonkeys";
            this.imgMathMonkeys.Size = new System.Drawing.Size(144, 97);
            this.imgMathMonkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMathMonkeys.TabIndex = 6;
            this.imgMathMonkeys.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(556, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(216, 68);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFeedbackAnswer
            // 
            this.lblFeedbackAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackAnswer.Location = new System.Drawing.Point(258, 431);
            this.lblFeedbackAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedbackAnswer.Name = "lblFeedbackAnswer";
            this.lblFeedbackAnswer.Size = new System.Drawing.Size(278, 55);
            this.lblFeedbackAnswer.TabIndex = 8;
            this.lblFeedbackAnswer.Text = "Luck";
            // 
            // txtInsertAnswer
            // 
            this.txtInsertAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsertAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.txtInsertAnswer.Location = new System.Drawing.Point(58, 189);
            this.txtInsertAnswer.MaxLength = 5;
            this.txtInsertAnswer.Name = "txtInsertAnswer";
            this.txtInsertAnswer.Size = new System.Drawing.Size(216, 68);
            this.txtInsertAnswer.TabIndex = 9;
            this.txtInsertAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInsertAnswer.TextChanged += new System.EventHandler(this.txtInsertAnswer_TextChanged_1);
            this.txtInsertAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsertAnswer_KeyPress);
            // 
            // gbxMathProblem
            // 
            this.gbxMathProblem.Controls.Add(this.btnEnterAnswer);
            this.gbxMathProblem.Controls.Add(this.txtInsertAnswer);
            this.gbxMathProblem.Controls.Add(this.lblNumberA);
            this.gbxMathProblem.Controls.Add(this.lblNumberB);
            this.gbxMathProblem.Controls.Add(this.lblProblemBar);
            this.gbxMathProblem.Controls.Add(this.lblOperatorSymbol);
            this.gbxMathProblem.Location = new System.Drawing.Point(230, 71);
            this.gbxMathProblem.Name = "gbxMathProblem";
            this.gbxMathProblem.Size = new System.Drawing.Size(316, 357);
            this.gbxMathProblem.TabIndex = 10;
            this.gbxMathProblem.TabStop = false;
            // 
            // lblProblemSet
            // 
            this.lblProblemSet.AutoSize = true;
            this.lblProblemSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemSet.Location = new System.Drawing.Point(12, 9);
            this.lblProblemSet.Name = "lblProblemSet";
            this.lblProblemSet.Size = new System.Drawing.Size(288, 55);
            this.lblProblemSet.TabIndex = 11;
            this.lblProblemSet.Text = "Problem Set";
            // 
            // Math_Problem_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblProblemSet);
            this.Controls.Add(this.gbxMathProblem);
            this.Controls.Add(this.lblFeedbackAnswer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.imgMathMonkeys);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Math_Problem_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Monkeys - Problem Set";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

    }
}