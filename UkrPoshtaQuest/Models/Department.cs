using System.ComponentModel.DataAnnotations;

namespace UkrPoshtaQuest.Models
{
    /// <summary>
    /// Відділ
    /// </summary>
    public class Department
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Назва відділу
        /// </summary>
        public string Name { get; set; }
    }
}
