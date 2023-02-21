using System;
using System.ComponentModel.DataAnnotations;

namespace UkrPoshtaQuest.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ПІБ
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Дата народження
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Адреса
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Дата взяття на роботу
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Оклад
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Відділ
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Посада
        /// </summary>
        public int PositionId { get; set; }
    }
}
