using System.ComponentModel.DataAnnotations;

namespace UkrPoshtaQuest.Models
{
    /// <summary>
    /// Посада
    /// </summary>
    public class Position
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Назва посади
        /// </summary>
        public string Name { get; set; }
    }
}
