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
    public partial class EndPage : Form
    {
        public EndPage()
        {
            InitializeComponent();
        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            FormProvider.TestNo = FormProvider.TestNo + 1;
            FormProvider.LastPage.Hide();
            FormProvider.StartPage.Show();
        }
    }
}
