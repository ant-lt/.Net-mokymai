using System.ComponentModel.DataAnnotations;

namespace BookWebApiRepo_MSSQL_EF.Models.Dto
{
    public class GetBookDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Apjungtas per tarpą tekstas kgygos pavadinimas + knygos autorius
        /// </summary>
        [MaxLength(255, ErrorMessage = "PavadinimasIrAutorius cannot be longer than 255 characters")]
        public string PavadinimasIrAutorius { get; set; }

        /// <summary>
        /// Knygos leidybos metai
        /// </summary>
        public int LeidybosMetai { get; set; }
    }
}
