namespace BookWebApiRepo_MSSQL_EF.Models.Dto
{
    public class GetBookDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Apjungtas per tarpą tekstas kgygos pavadinimas + knygos autorius
        /// </summary>
        public string PavadinimasIrAutorius { get; set; }

        /// <summary>
        /// Knygos leidybos metai
        /// </summary>
        public int LeidybosMetai { get; set; }
    }
}
