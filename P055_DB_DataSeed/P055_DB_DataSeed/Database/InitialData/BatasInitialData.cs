using P055_DB_DataSeed.Models;

namespace P055_DB_DataSeed.Database.InitialData
{
    public static class BatasInitialData
    {
        public static Batas[] DataSeed => new Batas[]
        {
            new Batas
            {
                BatasId = 1,
                Pavadinimas = "Kedai",
                Tipas = "Vyriški",
                Kaina = 100M,
            },
            new Batas
            {
                BatasId = 2,
                Pavadinimas = "Kedai",
                Tipas = "Moteriški",
                Kaina = 200M,
            },
            new Batas
            {
                BatasId = 3,
                Pavadinimas = "Kroksai",
                Tipas = "Vaikiški",
                Kaina = 20.01M,
            },
        };
    }
}
