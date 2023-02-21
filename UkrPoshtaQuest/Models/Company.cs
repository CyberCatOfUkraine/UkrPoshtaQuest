using System.ComponentModel.DataAnnotations;

namespace UkrPoshtaQuest.Models
{
    /// <summary>
    /// Таблиця компанії
    /// </summary>
    public class Company
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Інформація про компанію
        /// </summary>
        public string CompanyInfo { get; set; }
    }
}
