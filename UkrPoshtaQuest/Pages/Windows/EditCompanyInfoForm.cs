using System;
using System.Windows.Forms;
using UkrPoshtaQuest.DbMagick;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest.Pages.Windows
{
    public partial class EditCompanyInfoForm : Form
    {
        private CompanyRepository<Company> _companyRepository;
        private readonly Company _company;

        public EditCompanyInfoForm(CompanyRepository<Company> companyRepository, Company company)
        {
            InitializeComponent();
            _companyRepository = companyRepository;
            _company = company;

            OldInfoLabel.Text = company.CompanyInfo;
            NewInfoTextBox.Text = company.CompanyInfo;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewInfoTextBox.Text) || string.IsNullOrWhiteSpace(NewInfoTextBox.Text))
            {
                MessageBox.Show("Неможливо замінити на пустий текст!");
                return;
            }
            var allCompany = _companyRepository.GetAll();
            if (allCompany.Exists(x => x.CompanyInfo == NewInfoTextBox.Text))
            {
                MessageBox.Show("Неможливо додати дублікат !");
                return;
            }
            _company.CompanyInfo = NewInfoTextBox.Text;
            _companyRepository.Update(_company);
            this.Close();
        }
    }
}
