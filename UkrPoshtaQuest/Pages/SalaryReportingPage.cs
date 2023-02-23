using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UkrPoshtaQuest.Pages
{
    public partial class SalaryReportingPage : UserControl
    {
        public SalaryReportingPage()
        {
            InitializeComponent();

            GenerateEmployeesDataGrid();
            InitializeComboBox();
        }


        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public DateTime HireDate { get; set; }
            public string Department { get; set; }
            public string Position { get; set; }
        }
        List<Employee> Employees = new List<Employee> {
        new Employee
        {
            Id=0,Name="Іваненко Іван Іванович", Salary=31200,HireDate=DateTime.Now.AddYears(-10), Department="Відділ розробки", Position= "Головний чувак"
        },
        new Employee
        {
            Id=1,Name="Чювак6лвл", Salary=31200,HireDate=DateTime.Now.AddYears(-4), Department="Відділ розробки", Position= "Такий собі чувак"
        },
        new Employee
        {
            Id=2,Name="Чювак5лвл", Salary=77091,HireDate=DateTime.Now.AddYears(-5), Department="Відділ зробити красиво", Position= "Просто чувак"
        },
        new Employee
        {
            Id=3,Name="Чювак4лвл", Salary=43982,HireDate=DateTime.Now.AddYears(-6), Department="Відділ зробити красиво", Position= "Непростий чувак"
        },
        new Employee
        {
            Id=4,Name="Чювак3лвл", Salary=52649,HireDate=DateTime.Now.AddYears(-7), Department="Відділ розробки", Position= "Чууваак"
        },
        new Employee
        {
            Id=5,Name="Чювак2лвл", Salary=96472,HireDate=DateTime.Now.AddYears(-8), Department="Відділ безпеки", Position= "Той самий чувак"
        },
        new Employee
        {
            Id=6,Name="Чювак1лвл", Salary=65261,HireDate=DateTime.Now.AddYears(-9), Department="Відділ безпеки", Position= "Апасний чувак"
        }
        };

        List<string> Departments = new List<string>()
        {
            "Виберіть відділ","Відділ розробки", "Відділ зробити красиво", "Відділ безпеки"
        };
        List<string> Positions = new List<string>()
        {
            "Виберіть посаду","Головний чувак","Такий собі чувак","Просто чувак","Непростий чувак","Чууваак","Той самий чувак","Апасний чувак"
        };

        private void InitializeComboBox()
        {
            DepartmentComboBox.Items.AddRange(Departments.ToArray());
            PositionComboBox.Items.AddRange(Positions.ToArray());

        }
        private void GenerateEmployeesDataGrid()
        {
            // створюємо новий екземпляр DataGridView
            DataGridView dataGridView = EmployeeDataGridView;
            EmployeeDataGridView.ScrollBars = ScrollBars.Both;
            // встановлюємо режим відображення DataGridView у вигляді таблиці
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;

            // створюємо колонки для відображення властивостей об'єктів класу Employee
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Ім'я працівника";

            DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn();
            salaryColumn.DataPropertyName = "Salary";
            salaryColumn.HeaderText = "Зарплата";

            DataGridViewTextBoxColumn hireDateColumn = new DataGridViewTextBoxColumn();
            hireDateColumn.DataPropertyName = "HireDate";
            hireDateColumn.HeaderText = "Дата найму";

            DataGridViewTextBoxColumn departmentColumn = new DataGridViewTextBoxColumn();
            departmentColumn.DataPropertyName = "Department";
            departmentColumn.HeaderText = "Відділ";

            DataGridViewTextBoxColumn positionColumn = new DataGridViewTextBoxColumn();
            positionColumn.DataPropertyName = "Position";
            positionColumn.HeaderText = "Посада";

            // додаємо створені колонки до DataGridView
            dataGridView.Columns.Add(nameColumn);
            dataGridView.Columns.Add(salaryColumn);
            dataGridView.Columns.Add(hireDateColumn);
            dataGridView.Columns.Add(departmentColumn);
            dataGridView.Columns.Add(positionColumn);

            // встановлюємо джерело даних для DataGridView
            dataGridView.DataSource = Employees;
        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        {
            List<Employee> employees = Employees;

            bool anyFieldFilled =
                DepartmentComboBox.SelectedItem != null ||
                PositionComboBox.SelectedItem != null ||
                (DateTime.Now.Year +
                DateTime.Now.Month +
                DateTime.Now.Day + ""
                !=
                HireDateDateTimePicker.Value.Year +
                HireDateDateTimePicker.Value.Month +
                HireDateDateTimePicker.Value.Day + ""
                ) ||
                (!string.IsNullOrEmpty(MinSalaryTextBox.Text)) ||
                (!string.IsNullOrEmpty(MaxSalaryTextBox.Text));

            if (anyFieldFilled)
            {
                employees = employees.Where(emp =>
                    CheckDepartment(emp) &&
                    CheckPosition(emp) &&
                    CheckHireDate(emp) &&
                    CheckMinSalary(emp) &&
                    CheckMaxSalary(emp)
                ).ToList();
            }

            EmployeeDataGridView.DataSource = employees;
            EmployeeDataGridView.Update();
            EmployeeDataGridView.Refresh();
        }

        private bool CheckMinSalary(Employee emp)
        {
            if (string.IsNullOrEmpty(MinSalaryTextBox.Text.Trim()))
            {
                return true;
            }
            return decimal.Parse(MinSalaryTextBox.Text) < emp.Salary;
        }

        private bool CheckMaxSalary(Employee emp)
        {
            if (string.IsNullOrEmpty(MinSalaryTextBox.Text.Trim()))
            {
                return true;
            }
            return decimal.Parse(MaxSalaryTextBox.Text) > emp.Salary;
        }

        private bool CheckDepartment(Employee emp)
        {
            if (DepartmentComboBox.SelectedItem == null)
            {
                return true;
            }
            if (DepartmentComboBox.SelectedItem == Departments[0])
            {
                return true;
            }
            return emp.Department == DepartmentComboBox.SelectedItem;
        }

        private bool CheckPosition(Employee emp)
        {
            if (PositionComboBox.SelectedItem == null)
            {
                return true;
            }
            if (PositionComboBox.SelectedItem == Positions[0])
            {
                return true;
            }
            return emp.Position == PositionComboBox.SelectedItem;
        }

        private bool CheckHireDate(Employee emp)
        {
            if (HireDateDateTimePicker.Value.ToString("yyyyMMdd") == DateTime.Now.ToString("yyyyMMdd"))
            {
                return true;
            }
            string hireDateStr = emp.HireDate.ToString("yyyyMMdd");
            string chosenDateStr = HireDateDateTimePicker.Value.ToString("yyyyMMdd");
            return hireDateStr == chosenDateStr;
        }

        private void MinSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MaxSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExportToTxt_Click(object sender, EventArgs e)
        {
            var dateTimeHash = DateTime.Now.GetHashCode();
            var directoryName = "Test";
            var directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), directoryName);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            var sb = new StringBuilder();

            foreach (var employee in EmployeeDataGridView.DataSource as List<Employee>)
            {
                sb.AppendLine(new string('-', 10));
                sb.AppendLine(employee.Id.ToString());
                sb.AppendLine(employee.Name.ToString());
                sb.AppendLine(employee.Salary.ToString());
                sb.AppendLine(employee.HireDate.ToString());
                sb.AppendLine(employee.Department.ToString());
                sb.AppendLine(employee.Position.ToString());
                sb.AppendLine(new string('-', 10));
            }

            File.WriteAllText(Path.Combine(directoryPath, dateTimeHash + ".txt"), sb.ToString());

            System.Diagnostics.Process.Start("explorer.exe", directoryPath);
        }
    }
}
