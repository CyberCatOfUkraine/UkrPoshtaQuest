using System;
using System.Windows.Forms;
using UkrPoshtaQuest.DbMagick;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainPageMenuItem_Click(null, null);

            MakeMagicGreatAgain();
        }

        private void MakeMagicGreatAgain()
        {
            var employeeRepository = new EmployeeRepository<Employee>();
            if (employeeRepository.Count == 0)
            {
                DepartmentRepository<Department> departmentRepository = new DepartmentRepository<Department>();

                departmentRepository.Add(new Department() { Name = "IT Department" });
                departmentRepository.Add(new Department() { Name = "Jab1" });
                departmentRepository.Add(new Department() { Name = "Jab2" });
                departmentRepository.Add(new Department() { Name = "Jab3" });


                AddressRespository<Address> addressRespository = new AddressRespository<Address>();
                addressRespository.Add(
                    new Address
                    {
                        Region = "Область1",
                        District = "Район1",
                        Settlement = "Село",
                        Street = "Вулиця1",
                        House = "Будинок"
                    });
                addressRespository.Add(
                    new Address
                    {
                        Region = "Область2",
                        District = "Район2",
                        Settlement = "Місто",
                        Street = "Вулиця2",
                        House = "Будинок2",
                        Apartment = "Квартира"
                    });
                addressRespository.Add(
                    new Address
                    {
                        Region = "Область3",
                        District = "Район3",
                        Settlement = "Місто",
                        Street = "Вулиця1",
                        House = "Будинок"
                    });


                PositionRepository<Position> positionRepository = new PositionRepository<Position>();
                positionRepository.Add(new Position { Name = "Інжнер" });
                positionRepository.Add(new Position { Name = "Завхоз" });
                positionRepository.Add(new Position { Name = "Начальник" });


                employeeRepository.Add(new Employee()
                {
                    FullName = "Чювак",
                    AddressId = 1,
                    DateOfBirth = System.DateTime.Now.AddYears(-25),
                    DepartmentId = 1,
                    HireDate = System.DateTime.Now.AddYears(-5),
                    PhoneNumber = "+380 324 23 32",
                    PositionId = 1,
                    Salary = 5000
                });
                employeeRepository.Add(new Employee()
                {
                    FullName = "Чювак 2 ",
                    AddressId = 1,
                    DateOfBirth = System.DateTime.Now.AddYears(-26),
                    DepartmentId = 1,
                    HireDate = System.DateTime.Now.AddYears(-5),
                    PhoneNumber = "+380 524 23 32",
                    PositionId = 3,
                    Salary = 5000
                });
                employeeRepository.Add(new Employee()
                {
                    FullName = "Чювак 3",
                    AddressId = 1,
                    DateOfBirth = System.DateTime.Now.AddYears(-24),
                    DepartmentId = 1,
                    HireDate = System.DateTime.Now.AddYears(-5),
                    PhoneNumber = "+380 364 23 32",
                    PositionId = 2,
                    Salary = 5000
                });

                CompanyRepository<Company> companyRepository = new CompanyRepository<Company>();
                companyRepository.Add(new Company { CompanyInfo = "Цікава команда" });
                companyRepository.Add(new Company { CompanyInfo = "Дружня інфраструктура" });
                companyRepository.Add(new Company { CompanyInfo = "Це моя гвинтівка! Таких багато але ця моя!" });
                companyRepository.Add(new Company { CompanyInfo = "Пиво по вихідним за рахунок бонусів на арматизацію" });
                companyRepository.Add(new Company { CompanyInfo = "Потрібно виправити N030SR41 до RT56 інакше буде JKR7832" });
                companyRepository.Add(new Company { CompanyInfo = "Програміст козел! Не дав прибухнуть на роботі" });
                companyRepository.Add(new Company { CompanyInfo = "Сам козел! Або нефіг себе електриком звати!" });
            }
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

        private void відділиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скоро буде!");
        }

        private void посадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скоро буде!");
        }
    }
}