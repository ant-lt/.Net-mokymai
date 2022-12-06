using System.ComponentModel.DataAnnotations;

namespace BookWebApiRepo_MSSQL_EF.Models.Dto
{
    public class UpdateBookDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Knygos išleidimos metai
        /// </summary>
        [Range(typeof(DateTime), "1900-01-01", "2023-01-01", ErrorMessage = "Isleista must be between 1900-01-01 and 2023-01-01")]
        public DateTime Isleista { get; set; }


        /// <summary>
        /// Knygos autorius
        /// </summary>
        [MaxLength(255, ErrorMessage = "Autorius cannot be longer than 255 characters")]
        public string Autorius { get; set; }

        /// <summary>
        /// Knygos pavadinimas
        /// </summary>
        [MaxLength(255, ErrorMessage = "Pavadinimas cannot be longer than 255 characters")]
        public string Pavadinimas { get; set; }

        /// <summary>
        /// Knygos tipas, leidžiamos reikšmės: Hardcover, Paperback, Electronic.
        /// </summary>
        [MaxLength(15, ErrorMessage = "Knygos tipas cannot be longer than 15 characters")]
        public string KnygosTipas { get; set; }
    }
}
