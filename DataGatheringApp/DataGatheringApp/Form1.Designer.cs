namespace DataGatheringApp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Q1_Label = new System.Windows.Forms.Label();
            this.Q1Desc_Label = new System.Windows.Forms.Label();
            this.Q1_Options = new System.Windows.Forms.CheckedListBox();
            this.Q2_Options = new System.Windows.Forms.CheckedListBox();
            this.Q2Desc_Label = new System.Windows.Forms.Label();
            this.Q2_Label = new System.Windows.Forms.Label();
            this.Q3_Options = new System.Windows.Forms.CheckedListBox();
            this.Q3Desc_Label = new System.Windows.Forms.Label();
            this.Q3_Label = new System.Windows.Forms.Label();
            this.Q4_Options = new System.Windows.Forms.CheckedListBox();
            this.Q4Desc_Label = new System.Windows.Forms.Label();
            this.Q4_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Q5_Options = new System.Windows.Forms.CheckedListBox();
            this.Q6_Options = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Q7_Options = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Q8_Options = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Next_Page_Click);
            // 
            // Q1_Label
            // 
            this.Q1_Label.AutoSize = true;
            this.Q1_Label.Location = new System.Drawing.Point(30, 57);
            this.Q1_Label.Name = "Q1_Label";
            this.Q1_Label.Size = new System.Drawing.Size(58, 13);
            this.Q1_Label.TabIndex = 1;
            this.Q1_Label.Text = "Question 1";
            // 
            // Q1Desc_Label
            // 
            this.Q1Desc_Label.AutoSize = true;
            this.Q1Desc_Label.Location = new System.Drawing.Point(30, 70);
            this.Q1Desc_Label.Name = "Q1Desc_Label";
            this.Q1Desc_Label.Size = new System.Drawing.Size(188, 13);
            this.Q1Desc_Label.TabIndex = 2;
            this.Q1Desc_Label.Text = "The companion did what I told it to do.";
            // 
            // Q1_Options
            // 
            this.Q1_Options.CheckOnClick = true;
            this.Q1_Options.ColumnWidth = 103;
            this.Q1_Options.FormattingEnabled = true;
            this.Q1_Options.Items.AddRange(new object[] {
            "Strongly Agree",
            "Agree",
            "Neutral",
            "Disagree",
            "Strongly Disagree"});
            this.Q1_Options.Location = new System.Drawing.Point(12, 86);
            this.Q1_Options.MultiColumn = true;
            this.Q1_Options.Name = "Q1_Options";
            this.Q1_Options.Size = new System.Drawing.Size(520, 19);
            this.Q1_Options.TabIndex = 3;
            this.Q1_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q1_Options_ItemCheck);
            // 
            // Q2_Options
            // 
            this.Q2_Options.CheckOnClick = true;
            this.Q2_Options.ColumnWidth = 103;
            this.Q2_Options.FormattingEnabled = true;
            this.Q2_Options.Items.AddRange(new object[] {
            "Strongly Agree",
            "Agree",
            "Neutral",
            "Disagree",
            "Strongly Disagree"});
            this.Q2_Options.Location = new System.Drawing.Point(12, 149);
            this.Q2_Options.MultiColumn = true;
            this.Q2_Options.Name = "Q2_Options";
            this.Q2_Options.Size = new System.Drawing.Size(520, 19);
            this.Q2_Options.TabIndex = 6;
            this.Q2_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q2_Options_ItemCheck);
            // 
            // Q2Desc_Label
            // 
            this.Q2Desc_Label.AutoSize = true;
            this.Q2Desc_Label.Location = new System.Drawing.Point(30, 132);
            this.Q2Desc_Label.Name = "Q2Desc_Label";
            this.Q2Desc_Label.Size = new System.Drawing.Size(304, 13);
            this.Q2Desc_Label.TabIndex = 5;
            this.Q2Desc_Label.Text = "The Companion acted logically according to its emotional state.";
            // 
            // Q2_Label
            // 
            this.Q2_Label.AutoSize = true;
            this.Q2_Label.Location = new System.Drawing.Point(30, 119);
            this.Q2_Label.Name = "Q2_Label";
            this.Q2_Label.Size = new System.Drawing.Size(58, 13);
            this.Q2_Label.TabIndex = 4;
            this.Q2_Label.Text = "Question 2";
            // 
            // Q3_Options
            // 
            this.Q3_Options.CheckOnClick = true;
            this.Q3_Options.ColumnWidth = 103;
            this.Q3_Options.FormattingEnabled = true;
            this.Q3_Options.Items.AddRange(new object[] {
            "Strongly Agree",
            "Agree",
            "Neutral",
            "Disagree",
            "Strongly Disagree"});
            this.Q3_Options.Location = new System.Drawing.Point(12, 211);
            this.Q3_Options.MultiColumn = true;
            this.Q3_Options.Name = "Q3_Options";
            this.Q3_Options.Size = new System.Drawing.Size(520, 19);
            this.Q3_Options.TabIndex = 9;
            this.Q3_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q3_Options_ItemCheck);
            // 
            // Q3Desc_Label
            // 
            this.Q3Desc_Label.AutoSize = true;
            this.Q3Desc_Label.Location = new System.Drawing.Point(30, 194);
            this.Q3Desc_Label.Name = "Q3Desc_Label";
            this.Q3Desc_Label.Size = new System.Drawing.Size(230, 13);
            this.Q3Desc_Label.TabIndex = 8;
            this.Q3Desc_Label.Text = "The Companion rebeled against my commands.";
            // 
            // Q3_Label
            // 
            this.Q3_Label.AutoSize = true;
            this.Q3_Label.Location = new System.Drawing.Point(30, 181);
            this.Q3_Label.Name = "Q3_Label";
            this.Q3_Label.Size = new System.Drawing.Size(58, 13);
            this.Q3_Label.TabIndex = 7;
            this.Q3_Label.Text = "Question 3";
            // 
            // Q4_Options
            // 
            this.Q4_Options.CheckOnClick = true;
            this.Q4_Options.ColumnWidth = 103;
            this.Q4_Options.FormattingEnabled = true;
            this.Q4_Options.Items.AddRange(new object[] {
            "Strongly Agree",
            "Agree",
            "Neutral",
            "Disagree",
            "Strongly Disagree"});
            this.Q4_Options.Location = new System.Drawing.Point(12, 278);
            this.Q4_Options.MultiColumn = true;
            this.Q4_Options.Name = "Q4_Options";
            this.Q4_Options.Size = new System.Drawing.Size(520, 19);
            this.Q4_Options.TabIndex = 12;
            this.Q4_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q4_Options_ItemCheck);
            // 
            // Q4Desc_Label
            // 
            this.Q4Desc_Label.AutoSize = true;
            this.Q4Desc_Label.Location = new System.Drawing.Point(30, 458);
            this.Q4Desc_Label.Name = "Q4Desc_Label";
            this.Q4Desc_Label.Size = new System.Drawing.Size(151, 13);
            this.Q4Desc_Label.TabIndex = 11;
            this.Q4Desc_Label.Text = "I could relie on my Companion.";
            // 
            // Q4_Label
            // 
            this.Q4_Label.AutoSize = true;
            this.Q4_Label.Location = new System.Drawing.Point(30, 249);
            this.Q4_Label.Name = "Q4_Label";
            this.Q4_Label.Size = new System.Drawing.Size(58, 13);
            this.Q4_Label.TabIndex = 10;
            this.Q4_Label.Text = "Question 4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 585);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Please rate how much you agree or disagree with the following statements:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "The companion did not do as I told it to.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Question 5";
            // 
            // Q5_Options
            // 
            this.Q5_Options.CheckOnClick = true;
            this.Q5_Options.ColumnWidth = 103;
            this.Q5_Options.FormattingEnabled = true;
            this.Q5_Options.Items.AddRange(new object[] {
            "Strongly Agree",
            "Agree",
            "Neutral",
            "Disagree",
            "Strongly Disagree"});
            this.Q5_Options.Location = new System.Drawing.Point(12, 347);
            this.Q5_Options.MultiColumn = true;
            this.Q5_Options.Name = "Q5_Options";
            this.Q5_Options.Size = new System.Drawing.Size(520, 19);
            this.Q5_Options.TabIndex = 17;
            this.Q5_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q5_Options_ItemCheck);
            // 
            // Q6_Options
            // 
            this.Q6_Options.CheckOnClick = true;
            this.Q6_Options.ColumnWidth = 103;
            this.Q6_Options.FormattingEnabled = true;
            this.Q6_Options.Items.AddRange(new object[] {
            "Strongly Agree",
            "Agree",
            "Neutral",
            "Disagree",
            "Strongly Disagree"});
            this.Q6_Options.Location = new System.Drawing.Point(12, 413);
            this.Q6_Options.MultiColumn = true;
            this.Q6_Options.Name = "Q6_Options";
            this.Q6_Options.Size = new System.Drawing.Size(520, 19);
            this.Q6_Options.TabIndex = 20;
            this.Q6_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q6_Options_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "I was helped by my Companion.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Question 6";
            // 
            // Q7_Options
            // 
            this.Q7_Options.CheckOnClick = true;
            this.Q7_Options.ColumnWidth = 103;
            this.Q7_Options.FormattingEnabled = true;
            this.Q7_Options.Items.AddRange(new object[] {
            "Strongly Agree",
            "Agree",
            "Neutral",
            "Disagree",
            "Strongly Disagree"});
            this.Q7_Options.Location = new System.Drawing.Point(12, 474);
            this.Q7_Options.MultiColumn = true;
            this.Q7_Options.Name = "Q7_Options";
            this.Q7_Options.Size = new System.Drawing.Size(520, 19);
            this.Q7_Options.TabIndex = 23;
            this.Q7_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q7_Options_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "My companion\'s actions never made any sense.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Question 7";
            // 
            // Q8_Options
            // 
            this.Q8_Options.CheckOnClick = true;
            this.Q8_Options.ColumnWidth = 103;
            this.Q8_Options.FormattingEnabled = true;
            this.Q8_Options.Items.AddRange(new object[] {
            "Strongly Agree",
            "Agree",
            "Neutral",
            "Disagree",
            "Strongly Disagree"});
            this.Q8_Options.Location = new System.Drawing.Point(12, 541);
            this.Q8_Options.MultiColumn = true;
            this.Q8_Options.Name = "Q8_Options";
            this.Q8_Options.Size = new System.Drawing.Size(520, 19);
            this.Q8_Options.TabIndex = 26;
            this.Q8_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q8_Options_ItemCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "The Companion always did what I expected it would do.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Question 8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 645);
            this.Controls.Add(this.Q8_Options);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Q7_Options);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Q6_Options);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Q5_Options);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Q4_Options);
            this.Controls.Add(this.Q4Desc_Label);
            this.Controls.Add(this.Q4_Label);
            this.Controls.Add(this.Q3_Options);
            this.Controls.Add(this.Q3Desc_Label);
            this.Controls.Add(this.Q3_Label);
            this.Controls.Add(this.Q2_Options);
            this.Controls.Add(this.Q2Desc_Label);
            this.Controls.Add(this.Q2_Label);
            this.Controls.Add(this.Q1_Options);
            this.Controls.Add(this.Q1Desc_Label);
            this.Controls.Add(this.Q1_Label);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Q1_Label;
        private System.Windows.Forms.Label Q1Desc_Label;
        private System.Windows.Forms.CheckedListBox Q1_Options;
        private System.Windows.Forms.CheckedListBox Q2_Options;
        private System.Windows.Forms.Label Q2Desc_Label;
        private System.Windows.Forms.Label Q2_Label;
        private System.Windows.Forms.CheckedListBox Q3_Options;
        private System.Windows.Forms.Label Q3Desc_Label;
        private System.Windows.Forms.Label Q3_Label;
        private System.Windows.Forms.CheckedListBox Q4_Options;
        private System.Windows.Forms.Label Q4Desc_Label;
        private System.Windows.Forms.Label Q4_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox Q5_Options;
        private System.Windows.Forms.CheckedListBox Q6_Options;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox Q7_Options;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox Q8_Options;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

