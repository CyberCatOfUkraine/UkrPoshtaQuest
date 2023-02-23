using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UkrPoshtaQuest.DbMagick;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest.Pages.Windows
{
    public partial class EditEmployeeForm : Form
    {
        public EmployeeRepository<Employee> EmployeeRepository { get; }
        public Employee Employee { get; set; }
        public List<Department> Departments { get; }
        public List<Position> Positions { get; }
        public AddressRespository<Address> AddressRespository { get; }

        public EditEmployeeForm(EmployeeRepository<Employee> employeeRepository, Employee employee, List<Department> departments, List<Position> positions, AddressRespository<Address> addressRespository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            Employee = employee;
            Departments = departments;
            Positions = positions;
            AddressRespository = addressRespository;

            InitializeFormComponents();
        }

        private void InitializeFormComponents()
        {
            FullNameTextBox.Text = Employee.FullName;
            DepartmentComboBox.Items.AddRange(Departments.Select(x => x.Name).ToArray());
            PositionComboBox.Items.AddRange(Positions.Select(x => x.Name).ToArray());
            PhoneTextBox.Text = Employee.PhoneNumber;
            HireDateDateTimePicker.Value = Employee.HireDate;
            BirthDateDateTimePicker.Value = Employee.DateOfBirth;

            #region Адреса
            var address = AddressRespository.GetById(Employee.AddressId);
            RegionTextBox.Text = address.Region;
            DistrictTextBox.Text = address.District;
            SettlmentTextBox.Text = address.Settlement;
            StreetTextBox.Text = address.Street;
            HouseTextBox.Text = address.House;
            AppartmentTextBox.Text = address.Apartment;
            #endregion

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            #region Адреса
            var address = AddressRespository.GetById(Employee.AddressId);
            if (string.IsNullOrEmpty(RegionTextBox.Text.Trim()))
            {
                MessageBox.Show("Неможливо призначити пусту область");
                return;
            }
            address.Region = RegionTextBox.Text;

            if (string.IsNullOrEmpty(DistrictTextBox.Text.Trim()))
            {
                MessageBox.Show("Неможливо призначити пустий регіон");
                return;
            }
            address.District = DistrictTextBox.Text;

            if (string.IsNullOrEmpty(SettlmentTextBox.Text.Trim()))
            {
                MessageBox.Show("Неможливо призначити пустий населений пункт");
                return;
            }
            address.Settlement = SettlmentTextBox.Text;

            if (string.IsNullOrEmpty(StreetTextBox.Text.Trim()))
            {
                MessageBox.Show("Неможливо призначити пусту вулицю");
                return;
            }
            address.Street = StreetTextBox.Text;

            if (string.IsNullOrEmpty(HouseTextBox.Text.Trim()))
            {
                MessageBox.Show("Неможливо призначити пустий будинок");
                return;
            }
            address.House = HouseTextBox.Text;

            address.Apartment = AppartmentTextBox.Text;
            #endregion

            if (string.IsNullOrEmpty(FullNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Неможливо призначити пустий ПІБ");
                return;
            }


            if (string.IsNullOrEmpty(PhoneTextBox.Text.Trim()))
            {
                MessageBox.Show("Неможливо призначити пустий номер телефону");
                return;
            }
            PhoneTextBox.Text = Employee.PhoneNumber;

            Employee.FullName = FullNameTextBox.Text;

            Employee.DepartmentId = Departments.Find(x => x.Name == DepartmentComboBox.SelectedItem).Id;

            Employee.PositionId = Positions.Find(x => x.Name == PositionComboBox.SelectedItem).Id;


            Employee.HireDate = HireDateDateTimePicker.Value;
            Employee.DateOfBirth = BirthDateDateTimePicker.Value;
            AddressRespository.Update(address);
            EmployeeRepository.Update(Employee);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
