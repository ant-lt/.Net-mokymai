using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Data.InitialData
{
    public static class GenreInitialData
    {
        public static readonly Genre[] genreInitialDataSeed = new Genre[]
        {
            new Genre
            {
                Id= 1,
                Name = "Pasaka"
            },

            new Genre
            {
                Id= 2,
                Name ="Legenda"
            },

            new Genre
            {
                Id= 3,
                Name = "Romanas"
            },

            new Genre
            {
                Id= 4,
                Name = "Fantastika"
            },

            new Genre
            {
                Id= 5,
                Name = "Drama"
            }
        };
    }
}
