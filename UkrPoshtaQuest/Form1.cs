using System;
using System.Windows.Forms;

namespace UkrPoshtaQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainPageMenuItem_Click(null, null);
        }

        private void MainPageMenuItem_Click(object sender, EventArgs e)
        {
            /*Label label1 = new Label();

            // Initialize the Label and TextBox controls.
            label1.Location = new Point(16, 16);
            label1.Text = "label1";
            label1.Size = new Size(104, 16);*/
            SetPage(new Pages.MainPage());
        }

        private void PersonalMenuItem_Click(object sender, EventArgs e)
        {
            SetPage(new Pages.PersonalPage());
            //SQLManager sQLManager = new SQLManager();
            //sQLManager.Test();
        }

        private void SalaryReportingMenuItem_Click(object sender, EventArgs e)
        {
            SetPage(new Pages.SalaryReportingPage());
        }

        private void SetPage(UserControl page)
        {
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(page);
        }
    }
}