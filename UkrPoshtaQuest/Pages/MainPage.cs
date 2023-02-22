using System.Collections.Generic;
using System.Windows.Forms;
using UkrPoshtaQuest.DbMagick;
using UkrPoshtaQuest.Models;
using UkrPoshtaQuest.Pages.Windows;

namespace UkrPoshtaQuest.Pages
{
    public partial class MainPage : UserControl
    {
        public List<Company> companies;
        public MainPage()
        {
            InitializeComponent();
            GenerateCompaniesDataGrid();
        }

        private void GenerateCompaniesDataGrid()
        {
            //створюємо новий екземпляр DataGridView
            DataGridView dataGridView = CompanyDataGridView;
            /*-------------------*/
            dataGridView.ScrollBars = ScrollBars.Both;
            /*-------------------*/

            //встановлюємо режим відображення DataGridView у вигляді таблиці
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;

            //створюємо колонки для відображення властивостей об'єктів класу Company
            DataGridViewTextBoxColumn companyInfoColumn = new DataGridViewTextBoxColumn();
            companyInfoColumn.DataPropertyName = "CompanyInfo";
            companyInfoColumn.HeaderText = "Інформація про компанію";

            /*-------------------*/
            companyInfoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            /*-------------------*/

            //створюємо колонку для відображення кнопки "Редагувати"
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Редагувати";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Text = "Редагувати";
            //створюємо колонку для відображення кнопки "Видалити"
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Видалити";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Text = "Видалити";

            //додаємо створені колонки до DataGridView
            dataGridView.Columns.Add(companyInfoColumn);
            dataGridView.Columns.Add(editButtonColumn);
            dataGridView.Columns.Add(deleteButtonColumn);

            //встановлюємо джерело даних для DataGridView

            companies = new CompanyRepository<Company>().GetAll();
            dataGridView.DataSource = companies;

        }

        private void CompanyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Невелика пам'ятка:
            //e.ColumnIndex це  колонка того що викликало CellContentClick,
            //e.RowIndex це рядок того що викликало CellContentClick
            var companyRepos = new CompanyRepository<Company>();

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                EditCompanyInfoForm editCompanyInfoForm = new EditCompanyInfoForm(companyRepos, companies[e.RowIndex]);
                editCompanyInfoForm.FormClosed += delegate (object sender1, FormClosedEventArgs e1)
                {
                    UpdateDataGrid();
                };
                editCompanyInfoForm.Show();
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                companyRepos.Delete(companies[e.RowIndex].Id);
                UpdateDataGrid();
            }
        }

        private void AddCompanyInfoBtn_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(CompanyInfoTextBox.Text) || string.IsNullOrWhiteSpace(CompanyInfoTextBox.Text))
            {
                MessageBox.Show("Неможливо додати пустий текст!");
                return;
            }
            var companyRepos = new CompanyRepository<Company>();
            if (companyRepos.GetAll().Exists(x => x.CompanyInfo == CompanyInfoTextBox.Text))
            {
                MessageBox.Show("Неможливо додати дублікат !");
                return;
            }
            companyRepos.Add(new Company { CompanyInfo = CompanyInfoTextBox.Text });
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            var companyRepos = new CompanyRepository<Company>();
            companies = companyRepos.GetAll();//Ось тут я точно не впевнений але і залишати без ID Company не то
            CompanyDataGridView.DataSource = companies;
            CompanyDataGridView.Update();
            CompanyDataGridView.Refresh();
        }
    }
}
