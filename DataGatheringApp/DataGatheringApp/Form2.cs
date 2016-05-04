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

        private int pleasure = 50;
        private int arousal = 50;
        private int testNo;

        private String[] sheetLines = new String[14];

        public Form2()
        {
            InitializeComponent();
            testNo = FormProvider.TestNo % 2;
            if (testNo == 0)
            {
                button_finish.Text = "Next";
            }else if (testNo == 1)
            {
                button_finish.Text = "Done";
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            testNo = FormProvider.TestNo % 2;
            if (testNo == 0)
            {
                //opens the start page and closes this page
                FormProvider.StartPage.Show();
                FormProvider.SliderPage1.Hide();                
            }
            else if (testNo == 1)
            {
                FormProvider.SliderPage2.Show();
                FormProvider.SliderPage1.Hide();
            }


        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            if (testNo == 0)
            {
                FormProvider.SliderPage2.Show();
                FormProvider.SliderPage1.Hide();

            } else if (testNo == 1)
            {
                // puts the values of the sliders into a String array

                sheetLines[0] = String.Format("Question 1 answer was: {0}\n", FormProvider.StartPage.Q1);
                sheetLines[1] = String.Format("Question 2 answer was: {0}\n", FormProvider.StartPage.Q2);
                sheetLines[2] = String.Format("Question 3 answer was: {0}\n", FormProvider.StartPage.Q3);
                sheetLines[3] = String.Format("Question 4 answer was: {0}\n", FormProvider.StartPage.Q4);
                sheetLines[4] = String.Format("Question 5 answer was: {0}\n", FormProvider.StartPage.Q5);
                sheetLines[5] = String.Format("Question 6 answer was: {0}\n", FormProvider.StartPage.Q6);
                sheetLines[6] = String.Format("Question 7 answer was: {0}\n", FormProvider.StartPage.Q7);
                sheetLines[7] = String.Format("Question 8 answer was: {0}\n", FormProvider.StartPage.Q8);
                sheetLines[8] = "Rate how you felt about the Companion Artificial Intelligence after the testing session";
                sheetLines[9] = String.Format("Pleasure rating: {0}\n", pleasure);
                sheetLines[10] = String.Format("Arousal rating: {0}\n", arousal);
                sheetLines[11] = "Rate how you felt about the Companion Artificial Intelligence's Logic after the testing session";
                sheetLines[12] = String.Format("Pleasure rating: {0}\n", FormProvider.SliderPage2.Pleasure);
                sheetLines[13] = String.Format("Arousal rating: {0}\n", FormProvider.SliderPage2.Arousal);

                //Prints the strings into a text file
                System.IO.File.WriteAllLines(@"C:\Users\Rasmus\Desktop\TestData" + FormProvider.TestNo + ".txt", sheetLines);

                FormProvider.TestNo = FormProvider.TestNo + 1;
                FormProvider.SliderPage1.Hide();
                FormProvider.StartPage.Show();
            }
    
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

        public int Pleasure
        {
            get { return pleasure; }
        }

        public int Arousal
        {
            get { return arousal; }
        }

    }
}
