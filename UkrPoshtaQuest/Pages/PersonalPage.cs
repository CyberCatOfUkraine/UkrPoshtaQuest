﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UkrPoshtaQuest.DataGridHelper;
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
            editButtonColumn.HeaderText = "Редагувати";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Text = "Редагувати";

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
                MessageBox.Show("edit");
            }
            else if (e.ColumnIndex == 9 && e.RowIndex >= 0)
            {
                /*companyRepos.Delete(companies[e.RowIndex].Id);
                UpdateDataGrid();*/
                MessageBox.Show("del");
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

            UpdateDataGrid();

        }
        #region Далі не зовсім зручний інтерфейс (жесть)

        private void FilterOpenBtn_Click(object sender, EventArgs e)
        {
            FormWithEmployeesFilter editCompanyInfoForm = new FormWithEmployeesFilter(dataGridEmployees);
            editCompanyInfoForm.Show();
        }
        #endregion

    }
}
