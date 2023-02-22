using System.Collections.Generic;
using System.Windows.Forms;
using UkrPoshtaQuest.DataGridHelper;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest.Pages.Windows
{
    public partial class FormWithEmployeesFilter : Form
    {
        public List<DataGridEmployee> DataGridEmployees { get; }

        public FormWithEmployeesFilter(List<DataGridEmployee> dataGridEmployees)
        {
            InitializeComponent();
            DataGridEmployees = dataGridEmployees;

        }

    }
}
namespace UkrPoshtaQuest.DataGridHelper
{
    //Чому саме тут ? 
    //> Оскільки далі йде пов'язана інформація
    public class DataGridEmployee : Employee
    {
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public string Address { get; set; }
    }
}