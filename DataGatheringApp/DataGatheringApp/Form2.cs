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
    public partial class Form2 : Form
    {

        private float pleasure = 50;
        private float arousal = 50;

        private String[] sheetLines = new String[6];

        public Form2()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            //opens the start page and closes this page
            FormProvider.StartPage.Show();
            FormProvider.SliderPage.Hide();
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            // puts the values of the sliders into a String array
            sheetLines[0] = String.Format("Pleasure rating: {0}\n", pleasure);
            sheetLines[1] = String.Format("Arousal rating: {0}\n", arousal);
            sheetLines[2] = String.Format("Question 1 answer was: {0}\n", FormProvider.StartPage.Q1);
            sheetLines[3] = String.Format("Question 2 answer was: {0}\n", FormProvider.StartPage.Q2);
            sheetLines[4] = String.Format("Question 3 answer was: {0}\n", FormProvider.StartPage.Q3);
            sheetLines[5] = String.Format("Question 4 answer was: {0}\n", FormProvider.StartPage.Q4);

            //Prints the strings into a text file
            System.IO.File.WriteAllLines(@"C:\Users\Rasmus\Desktop\TestData.txt",sheetLines);
        }

        private void slider_plesure_ValueChanged(object sender, EventArgs e)
        {
            //stores the value of the slider in a variable
            pleasure = slider_plesure.Value;
        }

        private void slider_arousal_ValueChanged(object sender, EventArgs e)
        {
            //stores the value of the slider in a variable
            arousal = slider_arousal.Value;
        }
    }
}
