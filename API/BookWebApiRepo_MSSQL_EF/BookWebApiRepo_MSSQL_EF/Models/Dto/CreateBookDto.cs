namespace BookWebApiRepo_MSSQL_EF.Models.Dto
{
    public class CreateBookDto
    {
        /// <summary>
        /// Knygos pavadinimas
        /// </summary>
        public string Pavadinimas { get; set; }

        /// <summary>
        /// Knygos autorius
        /// </summary>
        public string Autorius { get; set; }

        /// <summary>
        /// Knygos išledimo metai
        /// </summary>
        public DateTime Isleista { get; set; }

        /// <summary>
        /// Knygos tipas:  Hardcover, Paperback, Electronic
        /// </summary>
        public string KnygosTipas { get; set; }

    }
}
