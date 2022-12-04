namespace BookWebApiRepo_MSSQL_EF.Models.Dto
{
    public class UpdateBookDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Knygos išleidimos metai
        /// </summary>
        public DateTime Isleista { get; set; }


        /// <summary>
        /// Knygos autorius
        /// </summary>
        public string Autorius { get; set; }

        /// <summary>
        /// Knygos pavadinimas
        /// </summary>
        public string Pavadinimas { get; set; }

        /// <summary>
        /// Knygos tipas, leidžiamos reikšmės: Hardcover, Paperback, Electronic.
        /// </summary>
        public string KnygosTipas { get; set; }
    }
}
