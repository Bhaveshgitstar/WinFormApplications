using System.Collections.Generic;

namespace CalculatorAssignment
{
    partial class Form1
    {
        private bool _isResult;
        private byte _countDecimal;
        private string _unaryOperator;
        private string _number1;
        private string _number2;
        public string result;
        public bool _isHistoryOpen;

        public List<string>resultList=new List<string>();

        Utility utility = new Utility();

        Publisher publisher = new Publisher();

        Addition addition = new Addition();
        Multiplication multiplication = new Multiplication();
        Subtraction subtraction = new Subtraction();
        Division division = new Division();
        Percentage percentage = new Percentage();
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
        ///

        private void OnLoad() {
            _number1 = null;
            _number2 = null;
        }
        private void InitializeComponent2() {
            _number1 = _number2 = null;
            result = "";
            _isResult = false;
            _countDecimal = 0;
            _unaryOperator = "+";
            _isHistoryOpen = false;

        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DisplayScreenBottom = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UnaryOperationButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubstractionButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.AllClearButton = new System.Windows.Forms.Button();
            this.DisplayScreenTop = new System.Windows.Forms.TextBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DisplayScreenBottom
            // 
            this.DisplayScreenBottom.BackColor = System.Drawing.SystemColors.InfoText;
            this.DisplayScreenBottom.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayScreenBottom.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.DisplayScreenBottom.Location = new System.Drawing.Point(15, 76);
            this.DisplayScreenBottom.Multiline = true;
            this.DisplayScreenBottom.Name = "DisplayScreenBottom";
            this.DisplayScreenBottom.ReadOnly = true;
            this.DisplayScreenBottom.Size = new System.Drawing.Size(334, 79);
            this.DisplayScreenBottom.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClearButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(15, 154);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(79, 69);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "CE";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UnaryOperationButton
            // 
            this.UnaryOperationButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.UnaryOperationButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnaryOperationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnaryOperationButton.Location = new System.Drawing.Point(15, 406);
            this.UnaryOperationButton.Name = "UnaryOperationButton";
            this.UnaryOperationButton.Size = new System.Drawing.Size(79, 65);
            this.UnaryOperationButton.TabIndex = 8;
            this.UnaryOperationButton.Text = "+/-";
            this.UnaryOperationButton.UseVisualStyleBackColor = false;
            this.UnaryOperationButton.Click += new System.EventHandler(this.UnaryOperationButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.FourButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FourButton.Location = new System.Drawing.Point(15, 280);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(79, 65);
            this.FourButton.TabIndex = 9;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SevenButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SevenButton.Location = new System.Drawing.Point(15, 217);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(79, 65);
            this.SevenButton.TabIndex = 10;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.OneButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OneButton.Location = new System.Drawing.Point(15, 343);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(79, 65);
            this.OneButton.TabIndex = 11;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.TwoButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TwoButton.Location = new System.Drawing.Point(100, 343);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(79, 65);
            this.TwoButton.TabIndex = 16;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.EightButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EightButton.Location = new System.Drawing.Point(100, 217);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(79, 65);
            this.EightButton.TabIndex = 15;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.FiveButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FiveButton.Location = new System.Drawing.Point(100, 280);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(79, 65);
            this.FiveButton.TabIndex = 14;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ZeroButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZeroButton.Location = new System.Drawing.Point(100, 406);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(79, 65);
            this.ZeroButton.TabIndex = 13;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ThreeButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThreeButton.Location = new System.Drawing.Point(185, 343);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(79, 65);
            this.ThreeButton.TabIndex = 21;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.NineButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NineButton.Location = new System.Drawing.Point(185, 217);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(79, 65);
            this.NineButton.TabIndex = 20;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SixButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SixButton.Location = new System.Drawing.Point(185, 280);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(79, 65);
            this.SixButton.TabIndex = 19;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.DecimalButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DecimalButton.Location = new System.Drawing.Point(185, 406);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(79, 65);
            this.DecimalButton.TabIndex = 18;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // PercentageButton
            // 
            this.PercentageButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.PercentageButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageButton.ForeColor = System.Drawing.Color.Lime;
            this.PercentageButton.Location = new System.Drawing.Point(185, 154);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(79, 66);
            this.PercentageButton.TabIndex = 17;
            this.PercentageButton.Text = "%";
            this.PercentageButton.UseVisualStyleBackColor = false;
            this.PercentageButton.Click += new System.EventHandler(this.PercentageButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.AdditionButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.AdditionButton.Location = new System.Drawing.Point(270, 343);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(79, 65);
            this.AdditionButton.TabIndex = 26;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = false;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.MultiplyButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.MultiplyButton.Location = new System.Drawing.Point(270, 217);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(79, 65);
            this.MultiplyButton.TabIndex = 25;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SubstractionButton
            // 
            this.SubstractionButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SubstractionButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubstractionButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.SubstractionButton.Location = new System.Drawing.Point(270, 280);
            this.SubstractionButton.Name = "SubstractionButton";
            this.SubstractionButton.Size = new System.Drawing.Size(79, 65);
            this.SubstractionButton.TabIndex = 24;
            this.SubstractionButton.Text = "-";
            this.SubstractionButton.UseVisualStyleBackColor = false;
            this.SubstractionButton.Click += new System.EventHandler(this.SubstractionButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.Lime;
            this.ResultButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultButton.Location = new System.Drawing.Point(270, 406);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(79, 65);
            this.ResultButton.TabIndex = 23;
            this.ResultButton.Text = "=";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.DivideButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.DivideButton.Location = new System.Drawing.Point(270, 154);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(79, 66);
            this.DivideButton.TabIndex = 22;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // AllClearButton
            // 
            this.AllClearButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.AllClearButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClearButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.AllClearButton.Location = new System.Drawing.Point(100, 154);
            this.AllClearButton.Name = "AllClearButton";
            this.AllClearButton.Size = new System.Drawing.Size(79, 66);
            this.AllClearButton.TabIndex = 27;
            this.AllClearButton.Text = "AC";
            this.AllClearButton.UseVisualStyleBackColor = false;
            this.AllClearButton.Click += new System.EventHandler(this.AllClearButton_Click);
            // 
            // DisplayScreenTop
            // 
            this.DisplayScreenTop.BackColor = System.Drawing.SystemColors.InfoText;
            this.DisplayScreenTop.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayScreenTop.ForeColor = System.Drawing.Color.Lime;
            this.DisplayScreenTop.Location = new System.Drawing.Point(12, 12);
            this.DisplayScreenTop.Multiline = true;
            this.DisplayScreenTop.Name = "DisplayScreenTop";
            this.DisplayScreenTop.ReadOnly = true;
            this.DisplayScreenTop.Size = new System.Drawing.Size(280, 61);
            this.DisplayScreenTop.TabIndex = 28;
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.historyButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.Color.Lime;
            this.historyButton.Image = ((System.Drawing.Image)(resources.GetObject("historyButton.Image")));
            this.historyButton.Location = new System.Drawing.Point(298, 12);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(56, 58);
            this.historyButton.TabIndex = 29;
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // historyListBox
            // 
            this.historyListBox.BackColor = System.Drawing.SystemColors.Info;
            this.historyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 29;
            this.historyListBox.Location = new System.Drawing.Point(374, 12);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(336, 439);
            this.historyListBox.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(358, 473);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.DisplayScreenTop);
            this.Controls.Add(this.AllClearButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubstractionButton);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.PercentageButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.UnaryOperationButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DisplayScreenBottom);
            this.Name = "Form1";
            this.Text = "Calculator App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox DisplayScreenBottom;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UnaryOperationButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button PercentageButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubstractionButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button AllClearButton;
        private System.Windows.Forms.TextBox DisplayScreenTop;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.ListBox historyListBox;
    }
}

