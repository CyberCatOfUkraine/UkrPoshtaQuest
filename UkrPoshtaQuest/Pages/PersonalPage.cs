using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UkrPoshtaQuest.DbMagick;
using UkrPoshtaQuest.Models;
using UkrPoshtaQuest.Pages.Windows;

namespace UkrPoshtaQuest.Pages
{
    public partial class PersonalPage : UserControl
    {
        #region Страшне, але в хвору голову нічого зараз не лізе нормального
        EmployeeRepository<Employee> employeeRepo = new EmployeeRepository<Employee>();
        DepartmentRepository<Department> departmentRepo = new DepartmentRepository<Department>();
        PositionRepository<Position> positionRepo = new PositionRepository<Position>();
        AddressRespository<Address> addressRepo = new AddressRespository<Address>();
        #endregion

        class DataGridEmployee : Employee
        {
            public string DepartmentName { get; set; }
            public string PositionName { get; set; }
            public string Address { get; set; }
        }

        List<DataGridEmployee> dataGridEmployees;
        public PersonalPage()
        {
            InitializeComponent();
            GenerateEmployeesDataGrid();
        }
        private void GenerateEmployeesDataGrid()
        {
            //створюємо новий екземпляр DataGridView
            DataGridView dataGridView = EmployeeDataGridView;
            /*-------------------*/
            dataGridView.ScrollBars = ScrollBars.Both;
            /*-------------------*/

            //встановлюємо режим відображення DataGridView у вигляді таблиці
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;

            //створюємо колонки для відображення властивостей об'єктів класу Employee
            DataGridViewTextBoxColumn fullNameColumn = new DataGridViewTextBoxColumn();
            fullNameColumn.DataPropertyName = "FullName";
            fullNameColumn.HeaderText = "ПІБ";

            DataGridViewTextBoxColumn dateOfBirthColumn = new DataGridViewTextBoxColumn();
            dateOfBirthColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthColumn.HeaderText = "Дата народження";

            DataGridViewTextBoxColumn addressIdColumn = new DataGridViewTextBoxColumn();
            addressIdColumn.DataPropertyName = "Address";
            addressIdColumn.HeaderText = "Адреса";

            DataGridViewTextBoxColumn phoneNumberColumn = new DataGridViewTextBoxColumn();
            phoneNumberColumn.DataPropertyName = "PhoneNumber";
            phoneNumberColumn.HeaderText = "Телефон";

            DataGridViewTextBoxColumn hireDateColumn = new DataGridViewTextBoxColumn();
            hireDateColumn.DataPropertyName = "HireDate";
            hireDateColumn.HeaderText = "Дата взяття на роботу";

            DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn();
            salaryColumn.DataPropertyName = "Salary";
            salaryColumn.HeaderText = "Оклад";

            DataGridViewTextBoxColumn departmentIdColumn = new DataGridViewTextBoxColumn();
            departmentIdColumn.DataPropertyName = "DepartmentName";
            departmentIdColumn.HeaderText = "Відділ";

            DataGridViewTextBoxColumn positionIdColumn = new DataGridViewTextBoxColumn();
            positionIdColumn.DataPropertyName = "PositionName";
            positionIdColumn.HeaderText = "Посада";

            //створюємо колонку для відображення кнопки "Редагувати"
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Картка працівника";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Text = "Картка працівника";

            //створюємо колонку для відображення кнопки "Видалити"
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Видалити";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Text = "Видалити";

            //додаємо створені колонки до DataGridView
            dataGridView.Columns.Add(fullNameColumn);
            dataGridView.Columns.Add(dateOfBirthColumn);
            dataGridView.Columns.Add(addressIdColumn);
            dataGridView.Columns.Add(phoneNumberColumn);
            dataGridView.Columns.Add(hireDateColumn);
            dataGridView.Columns.Add(salaryColumn);
            dataGridView.Columns.Add(departmentIdColumn);
            dataGridView.Columns.Add(positionIdColumn);
            dataGridView.Columns.Add(editButtonColumn);
            dataGridView.Columns.Add(deleteButtonColumn);

            #region Страшне
            //отримуємо оверхед, чимало оверхед, дофіга овехеда
            dataGridEmployees = employeeRepo.GetAll().Select(x =>
            {
                var address = addressRepo.GetById(x.AddressId);
                var appartment = address.Apartment == null ? "" : address.Apartment;
                var addressStr =
                address.Region + " | " +
                address.District + " | " +
                address.Settlement + " | " +
                address.Street + " | " +
                address.House + " | " +
                appartment;
                var department = departmentRepo.GetById(x.DepartmentId).Name;
                var position = positionRepo.GetById(x.PositionId).Name;
                return new DataGridEmployee
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    DateOfBirth = x.DateOfBirth,
                    AddressId = x.AddressId,
                    PhoneNumber = x.PhoneNumber,
                    HireDate = x.HireDate,
                    Salary = x.Salary,
                    DepartmentId = x.DepartmentId,
                    PositionId = x.PositionId,
                    DepartmentName = department,
                    PositionName = position,
                    Address = addressStr
                };
            })
                .ToList();
            #endregion
            //встановлюємо джерело даних для DataGridView
            dataGridView.DataSource = dataGridEmployees;


        }
        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var jab = e;

            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                /*EditCompanyInfoForm editCompanyInfoForm = new EditCompanyInfoForm(companyRepos, companies[e.RowIndex]);
                editCompanyInfoForm.FormClosed += delegate (object sender1, FormClosedEventArgs e1)
                {
                    UpdateDataGrid();
                };
                editCompanyInfoForm.Show();*/
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(employeeRepo,
                    dataGridEmployees[e.RowIndex] as Employee,
                    departmentRepo.GetAll(),
                    positionRepo.GetAll(),
                    addressRepo
                    );
                editEmployeeForm.Show();
                editEmployeeForm.FormClosed += delegate (object sender1, FormClosedEventArgs e2)
                {
                    UpdateDataGrid();
                };
            }
            else if (e.ColumnIndex == 9 && e.RowIndex >= 0)
            {
                employeeRepo.Delete(e.RowIndex);
                UpdateDataGrid();
            }
        }



        private void UpdateDataGrid()
        {
            EmployeeDataGridView.DataSource = employeeRepo.GetAll().Select(x =>
            {
                var address = addressRepo.GetById(x.AddressId);
                var appartment = address.Apartment == null ? "" : address.Apartment;
                var addressStr =
                address.Region + " | " +
                address.District + " | " +
                address.Settlement + " | " +
                address.Street + " | " +
                address.House + " | " +
                appartment;
                var department = departmentRepo.GetById(x.DepartmentId).Name;
                var position = positionRepo.GetById(x.PositionId).Name;
                return new DataGridEmployee
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    DateOfBirth = x.DateOfBirth,
                    AddressId = x.AddressId,
                    PhoneNumber = x.PhoneNumber,
                    HireDate = x.HireDate,
                    Salary = x.Salary,
                    DepartmentId = x.DepartmentId,
                    PositionId = x.PositionId,
                    DepartmentName = department,
                    PositionName = position,
                    Address = addressStr
                };
            })
                .ToList(); ;
            EmployeeDataGridView.Update();
            EmployeeDataGridView.Refresh();
        }
        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скоро буде!");
            UpdateDataGrid();

        }

        private void SearchItBtn_Click(object sender, EventArgs e)
        {
            List<DataGridEmployee> employees = dataGridEmployees;

            bool anyFieldFilled =
    !string.IsNullOrEmpty(FullNameTextBox.Text) ||
    !string.IsNullOrEmpty(AddressTextBox.Text) ||
    !string.IsNullOrEmpty(PhoneTextBox.Text) ||
    !string.IsNullOrEmpty(PositionTextBox.Text) ||
    !string.IsNullOrEmpty(DepartmentTextBox.Text) ||
    (DateTime.Now.Year +
    DateTime.Now.Month +
    DateTime.Now.Day + ""
    !=
    HireDateDateTimePicker.Value.Year +
    HireDateDateTimePicker.Value.Month +
    HireDateDateTimePicker.Value.Day + ""
    );

            if (anyFieldFilled)
            {
                employees = employees.Where(emp =>
                    CheckFullName(emp) &&
                    CheckAddress(emp) &&
                    CheckPhone(emp) &&
                    CheckPosition(emp) &&
                    CheckDepartment(emp) &&
                    CheckHireDate(emp)
                ).ToList();
            }

            EmployeeDataGridView.DataSource = employees;
            EmployeeDataGridView.Update();
            EmployeeDataGridView.Refresh();
        }

        private bool CheckFullName(DataGridEmployee emp)
        {
            return emp.FullName.Contains(FullNameTextBox.Text);
        }
        private bool CheckAddress(DataGridEmployee emp)
        {
            return emp.Address.Contains(AddressTextBox.Text);
        }

        private bool CheckPhone(DataGridEmployee emp)
        {
            return emp.PhoneNumber.Contains(PhoneTextBox.Text);
        }

        private bool CheckPosition(DataGridEmployee emp)
        {
            return emp.PositionName.Contains(PositionTextBox.Text);
        }

        private bool CheckDepartment(DataGridEmployee emp)
        {
            return emp.DepartmentName.Contains(DepartmentTextBox.Text);
        }

        private bool CheckHireDate(DataGridEmployee emp)
        {
            if (HireDateDateTimePicker.Value.ToString("yyyyMMdd") == DateTime.Now.ToString("yyyyMMdd"))
            {
                return true;
            }
            string hireDateStr = emp.HireDate.ToString("yyyyMMdd");
            string chosenDateStr = HireDateDateTimePicker.Value.ToString("yyyyMMdd");
            return hireDateStr == chosenDateStr;
        }
    }
}
