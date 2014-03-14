namespace Math_Monkeys
{
    partial class Form3Remove
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.ddlStudentRemove = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(92, 156);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(364, 62);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ddlStudentRemove
            // 
            this.ddlStudentRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStudentRemove.FormattingEnabled = true;
            this.ddlStudentRemove.Location = new System.Drawing.Point(113, 97);
            this.ddlStudentRemove.Margin = new System.Windows.Forms.Padding(4);
            this.ddlStudentRemove.Name = "ddlStudentRemove";
            this.ddlStudentRemove.Size = new System.Drawing.Size(315, 24);
            this.ddlStudentRemove.TabIndex = 1;
            this.ddlStudentRemove.SelectedIndexChanged += new System.EventHandler(this.ddlStudentRemove_SelectedIndexChanged_1);
            // 
            // Form3Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 295);
            this.Controls.Add(this.ddlStudentRemove);
            this.Controls.Add(this.btnRemove);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 342);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(577, 342);
            this.Name = "Form3Remove";
            this.Text = "Remove User";
            this.Load += new System.EventHandler(this.Form3Remove_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox ddlStudentRemove;
    }
}