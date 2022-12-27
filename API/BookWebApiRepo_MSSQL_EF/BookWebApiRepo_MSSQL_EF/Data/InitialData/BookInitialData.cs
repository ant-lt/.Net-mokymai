using BookWebApiRepo_MSSQL_EF.Enums;
using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Data.InitialData
{
    public static class BookInitialData
    {
        public static readonly Book[] booksInitialDataSeed = new Book[]
        {
            new Book { Id = 1, Title = "Ant medinės lentelės II", Author = "Kristina Pišniukaitė - Šimkienė", Years = 2022, CoverType = ECoverType.Hardcover, OwnedQty = 1, GenreId = GenreInitialData.genreInitialDataSeed[0].Id }
            ,new Book { Id = 2, Title = "Kakė Makė ir magiška kelionė", Author = "Lina Žutautė", Years = 2022, CoverType = ECoverType.Paperback, OwnedQty = 2,  GenreId = GenreInitialData.genreInitialDataSeed[0].Id}
            ,new Book { Id = 3, Title = "Tolimi krantai", Author = "Santa Montefiore", Years = 2022, CoverType = ECoverType.Electronic, OwnedQty = 3,  GenreId = GenreInitialData.genreInitialDataSeed[0].Id}
            ,new Book { Id = 4, Title = "Aštuntas gyvenimas (Brilkai)", Author = "Nino Haratischwili", Years = 2022, CoverType = ECoverType.Electronic, OwnedQty = 1,  GenreId = GenreInitialData.genreInitialDataSeed[1].Id}
            ,new Book { Id = 5, Title = "Ant medinės lentelės III", Author = "Kristina Pišniukaitė - Šimkienė", Years = 2022, CoverType = ECoverType.Electronic, OwnedQty = 2,  GenreId = GenreInitialData.genreInitialDataSeed[2].Id}
            ,new Book { Id = 6, Title = "Kichotas", Author = "Salman Rushdie", Years = 2020, CoverType = ECoverType.Paperback , OwnedQty = 3,  GenreId = GenreInitialData.genreInitialDataSeed[3].Id }
            ,new Book { Id = 7, Title = "Ant medinės lentelės IIV", Author = "Kristina Pišniukaitė - Šimkienė", Years = 2022, CoverType = ECoverType.Electronic , OwnedQty = 1,  GenreId = GenreInitialData.genreInitialDataSeed[4].Id}
        };
    }
}
