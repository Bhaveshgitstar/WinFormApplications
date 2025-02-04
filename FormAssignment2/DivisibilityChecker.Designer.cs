namespace FormAssignment2
{
    partial class DivisibilityChecker
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
            this.dividendInput = new System.Windows.Forms.TextBox();
            this.divisorInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButtonForm3 = new System.Windows.Forms.Button();
            this.divisibilitycheck = new System.Windows.Forms.Button();
            this.resetFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dividendInput
            // 
            this.dividendInput.Location = new System.Drawing.Point(198, 143);
            this.dividendInput.Multiline = true;
            this.dividendInput.Name = "dividendInput";
            this.dividendInput.Size = new System.Drawing.Size(158, 41);
            this.dividendInput.TabIndex = 12;
            // 
            // divisorInput
            // 
            this.divisorInput.Location = new System.Drawing.Point(488, 143);
            this.divisorInput.Multiline = true;
            this.divisorInput.Name = "divisorInput";
            this.divisorInput.Size = new System.Drawing.Size(158, 41);
            this.divisorInput.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dividend";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Divisor";
            // 
            // backButtonForm3
            // 
            this.backButtonForm3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButtonForm3.Location = new System.Drawing.Point(206, 341);
            this.backButtonForm3.Name = "backButtonForm3";
            this.backButtonForm3.Size = new System.Drawing.Size(150, 47);
            this.backButtonForm3.TabIndex = 11;
            this.backButtonForm3.Text = "Back";
            this.backButtonForm3.UseVisualStyleBackColor = false;
            this.backButtonForm3.Click += new System.EventHandler(this.backButtonForm3_Click);
            // 
            // divisibilitycheck
            // 
            this.divisibilitycheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.divisibilitycheck.Location = new System.Drawing.Point(329, 239);
            this.divisibilitycheck.Name = "divisibilitycheck";
            this.divisibilitycheck.Size = new System.Drawing.Size(150, 47);
            this.divisibilitycheck.TabIndex = 16;
            this.divisibilitycheck.Text = "Check Divisible";
            this.divisibilitycheck.UseVisualStyleBackColor = false;
            this.divisibilitycheck.Click += new System.EventHandler(this.divisibilitycheck_Click);
            // 
            // resetFields
            // 
            this.resetFields.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetFields.Location = new System.Drawing.Point(452, 341);
            this.resetFields.Name = "resetFields";
            this.resetFields.Size = new System.Drawing.Size(150, 47);
            this.resetFields.TabIndex = 17;
            this.resetFields.Text = "Reset Fields";
            this.resetFields.UseVisualStyleBackColor = false;
            this.resetFields.Click += new System.EventHandler(this.resetFields_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetFields);
            this.Controls.Add(this.divisibilitycheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divisorInput);
            this.Controls.Add(this.dividendInput);
            this.Controls.Add(this.backButtonForm3);
            this.Name = "Form3";
            this.Text = "Divisibility Checker";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dividendInput;
        private System.Windows.Forms.TextBox divisorInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButtonForm3;
        private System.Windows.Forms.Button divisibilitycheck;
        private System.Windows.Forms.Button resetFields;
    }
}