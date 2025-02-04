namespace FormAssignment2
{
    partial class DictionaryImplementation
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
            this.keyInput = new System.Windows.Forms.TextBox();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fetchKeyInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nextButtonForm2 = new System.Windows.Forms.Button();
            this.backButtonForm2 = new System.Windows.Forms.Button();
            this.fetchValueButton = new System.Windows.Forms.Button();
            this.resetButtonForm2 = new System.Windows.Forms.Button();
            this.addNewItemDict = new System.Windows.Forms.Button();
            this.closeAllPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(155, 96);
            this.keyInput.Multiline = true;
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(158, 41);
            this.keyInput.TabIndex = 0;
            this.keyInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(410, 96);
            this.valueInput.Multiline = true;
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(145, 37);
            this.valueInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // fetchKeyInput
            // 
            this.fetchKeyInput.Location = new System.Drawing.Point(350, 199);
            this.fetchKeyInput.Multiline = true;
            this.fetchKeyInput.Name = "fetchKeyInput";
            this.fetchKeyInput.Size = new System.Drawing.Size(158, 41);
            this.fetchKeyInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Any Key";
            // 
            // nextButtonForm2
            // 
            this.nextButtonForm2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButtonForm2.Location = new System.Drawing.Point(293, 350);
            this.nextButtonForm2.Name = "nextButtonForm2";
            this.nextButtonForm2.Size = new System.Drawing.Size(122, 35);
            this.nextButtonForm2.TabIndex = 12;
            this.nextButtonForm2.Text = "Next";
            this.nextButtonForm2.UseVisualStyleBackColor = false;
            this.nextButtonForm2.Click += new System.EventHandler(this.nextButtonForm2_Click);
            // 
            // backButtonForm2
            // 
            this.backButtonForm2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButtonForm2.Location = new System.Drawing.Point(155, 350);
            this.backButtonForm2.Name = "backButtonForm2";
            this.backButtonForm2.Size = new System.Drawing.Size(122, 35);
            this.backButtonForm2.TabIndex = 13;
            this.backButtonForm2.Text = "Back";
            this.backButtonForm2.UseVisualStyleBackColor = false;
            this.backButtonForm2.Click += new System.EventHandler(this.backButtonForm2_Click);
            // 
            // fetchValueButton
            // 
            this.fetchValueButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fetchValueButton.Location = new System.Drawing.Point(293, 267);
            this.fetchValueButton.Name = "fetchValueButton";
            this.fetchValueButton.Size = new System.Drawing.Size(122, 35);
            this.fetchValueButton.TabIndex = 14;
            this.fetchValueButton.Text = "Fetch";
            this.fetchValueButton.UseVisualStyleBackColor = false;
            this.fetchValueButton.Click += new System.EventHandler(this.fetchValueButton_Click);
            // 
            // resetButtonForm2
            // 
            this.resetButtonForm2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetButtonForm2.Location = new System.Drawing.Point(576, 121);
            this.resetButtonForm2.Name = "resetButtonForm2";
            this.resetButtonForm2.Size = new System.Drawing.Size(125, 35);
            this.resetButtonForm2.TabIndex = 16;
            this.resetButtonForm2.Text = "Reset Fields";
            this.resetButtonForm2.UseVisualStyleBackColor = false;
            this.resetButtonForm2.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // addNewItemDict
            // 
            this.addNewItemDict.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewItemDict.Location = new System.Drawing.Point(576, 73);
            this.addNewItemDict.Name = "addNewItemDict";
            this.addNewItemDict.Size = new System.Drawing.Size(125, 33);
            this.addNewItemDict.TabIndex = 15;
            this.addNewItemDict.Text = "Add ";
            this.addNewItemDict.UseVisualStyleBackColor = false;
            this.addNewItemDict.Click += new System.EventHandler(this.addNewItemDict_Click);
            // 
            // closeAllPrevious
            // 
            this.closeAllPrevious.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeAllPrevious.Location = new System.Drawing.Point(433, 350);
            this.closeAllPrevious.Name = "closeAllPrevious";
            this.closeAllPrevious.Size = new System.Drawing.Size(122, 35);
            this.closeAllPrevious.TabIndex = 17;
            this.closeAllPrevious.Text = "Close All";
            this.closeAllPrevious.UseVisualStyleBackColor = false;
            this.closeAllPrevious.Click += new System.EventHandler(this.closeAllPrevious_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(725, 419);
            this.Controls.Add(this.closeAllPrevious);
            this.Controls.Add(this.resetButtonForm2);
            this.Controls.Add(this.addNewItemDict);
            this.Controls.Add(this.fetchValueButton);
            this.Controls.Add(this.backButtonForm2);
            this.Controls.Add(this.nextButtonForm2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fetchKeyInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.keyInput);
            this.Name = "Form2";
            this.Text = "Dictionary Implementation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fetchKeyInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextButtonForm2;
        private System.Windows.Forms.Button backButtonForm2;
        private System.Windows.Forms.Button fetchValueButton;
        private System.Windows.Forms.Button resetButtonForm2;
        private System.Windows.Forms.Button addNewItemDict;
        private System.Windows.Forms.Button closeAllPrevious;
    }
}