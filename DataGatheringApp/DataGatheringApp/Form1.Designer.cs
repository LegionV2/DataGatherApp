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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 482);
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
            this.Q1_Label.Location = new System.Drawing.Point(30, 28);
            this.Q1_Label.Name = "Q1_Label";
            this.Q1_Label.Size = new System.Drawing.Size(58, 13);
            this.Q1_Label.TabIndex = 1;
            this.Q1_Label.Text = "Question 1";
            // 
            // Q1Desc_Label
            // 
            this.Q1Desc_Label.AutoSize = true;
            this.Q1Desc_Label.Location = new System.Drawing.Point(30, 41);
            this.Q1Desc_Label.Name = "Q1Desc_Label";
            this.Q1Desc_Label.Size = new System.Drawing.Size(114, 13);
            this.Q1Desc_Label.TabIndex = 2;
            this.Q1Desc_Label.Text = "Question 1 Description";
            // 
            // Q1_Options
            // 
            this.Q1_Options.CheckOnClick = true;
            this.Q1_Options.FormattingEnabled = true;
            this.Q1_Options.Items.AddRange(new object[] {
            "Option 1",
            "Option 2",
            "Option 3"});
            this.Q1_Options.Location = new System.Drawing.Point(33, 58);
            this.Q1_Options.Name = "Q1_Options";
            this.Q1_Options.Size = new System.Drawing.Size(111, 49);
            this.Q1_Options.TabIndex = 3;
            this.Q1_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q1_Options_ItemCheck);
            // 
            // Q2_Options
            // 
            this.Q2_Options.CheckOnClick = true;
            this.Q2_Options.FormattingEnabled = true;
            this.Q2_Options.Items.AddRange(new object[] {
            "Option 1",
            "Option 2",
            "Option 3"});
            this.Q2_Options.Location = new System.Drawing.Point(33, 158);
            this.Q2_Options.Name = "Q2_Options";
            this.Q2_Options.Size = new System.Drawing.Size(111, 49);
            this.Q2_Options.TabIndex = 6;
            this.Q2_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q2_Options_ItemCheck);
            // 
            // Q2Desc_Label
            // 
            this.Q2Desc_Label.AutoSize = true;
            this.Q2Desc_Label.Location = new System.Drawing.Point(30, 141);
            this.Q2Desc_Label.Name = "Q2Desc_Label";
            this.Q2Desc_Label.Size = new System.Drawing.Size(114, 13);
            this.Q2Desc_Label.TabIndex = 5;
            this.Q2Desc_Label.Text = "Question 2 Description";
            // 
            // Q2_Label
            // 
            this.Q2_Label.AutoSize = true;
            this.Q2_Label.Location = new System.Drawing.Point(30, 128);
            this.Q2_Label.Name = "Q2_Label";
            this.Q2_Label.Size = new System.Drawing.Size(58, 13);
            this.Q2_Label.TabIndex = 4;
            this.Q2_Label.Text = "Question 2";
            // 
            // Q3_Options
            // 
            this.Q3_Options.CheckOnClick = true;
            this.Q3_Options.FormattingEnabled = true;
            this.Q3_Options.Items.AddRange(new object[] {
            "Option 1",
            "Option 2",
            "Option 3"});
            this.Q3_Options.Location = new System.Drawing.Point(33, 250);
            this.Q3_Options.Name = "Q3_Options";
            this.Q3_Options.Size = new System.Drawing.Size(111, 49);
            this.Q3_Options.TabIndex = 9;
            this.Q3_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q3_Options_ItemCheck);
            // 
            // Q3Desc_Label
            // 
            this.Q3Desc_Label.AutoSize = true;
            this.Q3Desc_Label.Location = new System.Drawing.Point(30, 233);
            this.Q3Desc_Label.Name = "Q3Desc_Label";
            this.Q3Desc_Label.Size = new System.Drawing.Size(114, 13);
            this.Q3Desc_Label.TabIndex = 8;
            this.Q3Desc_Label.Text = "Question 3 Description";
            // 
            // Q3_Label
            // 
            this.Q3_Label.AutoSize = true;
            this.Q3_Label.Location = new System.Drawing.Point(30, 220);
            this.Q3_Label.Name = "Q3_Label";
            this.Q3_Label.Size = new System.Drawing.Size(58, 13);
            this.Q3_Label.TabIndex = 7;
            this.Q3_Label.Text = "Question 3";
            // 
            // Q4_Options
            // 
            this.Q4_Options.CheckOnClick = true;
            this.Q4_Options.FormattingEnabled = true;
            this.Q4_Options.Items.AddRange(new object[] {
            "Option 1",
            "Option 2",
            "Option 3"});
            this.Q4_Options.Location = new System.Drawing.Point(33, 351);
            this.Q4_Options.Name = "Q4_Options";
            this.Q4_Options.Size = new System.Drawing.Size(111, 49);
            this.Q4_Options.TabIndex = 12;
            this.Q4_Options.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Q4_Options_ItemCheck);
            // 
            // Q4Desc_Label
            // 
            this.Q4Desc_Label.AutoSize = true;
            this.Q4Desc_Label.Location = new System.Drawing.Point(30, 334);
            this.Q4Desc_Label.Name = "Q4Desc_Label";
            this.Q4Desc_Label.Size = new System.Drawing.Size(114, 13);
            this.Q4Desc_Label.TabIndex = 11;
            this.Q4Desc_Label.Text = "Question 4 Description";
            // 
            // Q4_Label
            // 
            this.Q4_Label.AutoSize = true;
            this.Q4_Label.Location = new System.Drawing.Point(30, 321);
            this.Q4_Label.Name = "Q4_Label";
            this.Q4_Label.Size = new System.Drawing.Size(58, 13);
            this.Q4_Label.TabIndex = 10;
            this.Q4_Label.Text = "Question 4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 457);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 517);
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
    }
}

