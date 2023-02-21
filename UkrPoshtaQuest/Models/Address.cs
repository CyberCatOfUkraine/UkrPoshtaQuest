using System.ComponentModel.DataAnnotations;

namespace UkrPoshtaQuest.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Область
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Населений пункт
        /// </summary>
        public string Settlement { get; set; }

        /// <summary>
        /// Вулиця
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Будинок
        /// </summary>
        public string House { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        public string Apartment { get; set; }
    }
}
