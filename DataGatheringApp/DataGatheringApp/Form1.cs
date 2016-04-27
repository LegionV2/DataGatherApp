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
        public Form1()
        {
            InitializeComponent();
        }

        private void Next_Page_Click(object sender, EventArgs e)
        {
            FormProvider.SliderPage.Show();
            FormProvider.StartPage.Hide();
        }

        private void Q1_Options_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Ensure that we are checking an item
            if(e.NewValue != CheckState.Checked)
            {
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
        }

        private void Q2_Options_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Ensure that we are checking an item
            if (e.NewValue != CheckState.Checked)
            {
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

        }

        private void Q3_Options_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Ensure that we are checking an item
            if (e.NewValue != CheckState.Checked)
            {
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

        }

        private void Q4_Options_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Ensure that we are checking an item
            if (e.NewValue != CheckState.Checked)
            {
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

        }
    }
}
