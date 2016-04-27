using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGatheringApp
{
    public partial class Form1 : Form
    {
        private bool[] answered = { false, false, false, false };

        public Form1()
        {
            InitializeComponent();
        }



        private void Next_Page_Click(object sender, EventArgs e)
        {
            if (answered[0] && answered[1] && answered[2] && answered[3])
            {
                FormProvider.SliderPage.Show();
                FormProvider.StartPage.Hide();
                textBox1.Text = null;
            }else
            {
                textBox1.Text = "Please answer all questions";
            }
        }

        private void Q1_Options_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Ensure that we are checking an item
            if(e.NewValue != CheckState.Checked)
            {
                answered[0] = false;
                return;
            }

            //Get the items that are selected
            CheckedListBox.CheckedIndexCollection selectedItems = this.Q1_Options.CheckedIndices;

            //Check that we have at least 1 item selected
            if (selectedItems.Count > 0)
            {
                //uncheck other items
                this.Q1_Options.SetItemChecked(selectedItems[0], false);
            }

            //mark question as answered if not already
            if (answered[0] != true)
            {
                answered[0] = true;
            }
        }

        private void Q2_Options_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Ensure that we are checking an item
            if (e.NewValue != CheckState.Checked)
            {
                answered[1] = false;
                return;
            }

            //Get the items that are selected
            CheckedListBox.CheckedIndexCollection selectedItems = this.Q2_Options.CheckedIndices;

            //Check that we have at least 1 item selected
            if (selectedItems.Count > 0)
            {
                //uncheck other items
                this.Q2_Options.SetItemChecked(selectedItems[0], false);
            }

            //mark question as answered if not already
            if (answered[1] != true)
            {
                answered[1] = true;
            }
        }

        private void Q3_Options_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Ensure that we are checking an item
            if (e.NewValue != CheckState.Checked)
            {
                answered[2] = false;
                return;
            }

            //Get the items that are selected
            CheckedListBox.CheckedIndexCollection selectedItems = this.Q3_Options.CheckedIndices;

            //Check that we have at least 1 item selected
            if (selectedItems.Count > 0)
            {
                //uncheck other items
                this.Q3_Options.SetItemChecked(selectedItems[0], false);
            }

            //mark question as answered if not already
            if (answered[2] != true)
            {
                answered[2] = true;
            }
        }

        private void Q4_Options_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Ensure that we are checking an item
            if (e.NewValue != CheckState.Checked)
            {
                answered[3] = false;
                return;
            }

            //Get the items that are selected
            CheckedListBox.CheckedIndexCollection selectedItems = this.Q4_Options.CheckedIndices;

            //Check that we have at least 1 item selected
            if (selectedItems.Count > 0)
            {
                //uncheck other items
                this.Q4_Options.SetItemChecked(selectedItems[0], false);
            }

            //mark question as answered if not already
            if (answered[3] != true)
            {
                answered[3] = true;
            }
        }

        public String Q1
        {
            get { return this.Q1_Options.Items[this.Q1_Options.CheckedIndices[0]].ToString(); }
        }
        public String Q2
        {
            get { return this.Q2_Options.Items[this.Q2_Options.CheckedIndices[0]].ToString(); }
        }
        public String Q3
        {
            get { return this.Q3_Options.Items[this.Q3_Options.CheckedIndices[0]].ToString(); }
        }
        public String Q4
        {
            get { return this.Q4_Options.Items[this.Q4_Options.CheckedIndices[0]].ToString(); }
        }
    }
}
