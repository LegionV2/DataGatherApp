﻿using System;
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
    }
}
