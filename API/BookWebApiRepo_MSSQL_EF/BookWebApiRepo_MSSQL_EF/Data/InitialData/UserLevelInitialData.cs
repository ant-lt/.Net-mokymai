using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Data.InitialData
{
    public static class UserLevelInitialData
    {
        public static readonly UserLevel[] userLevelInitialDataSeed = new UserLevel[]
        {
            new UserLevel
            {
                Id= 1,
                Name = "Pradinukas",
                PointsLevel= 0
            },
            new UserLevel
            {
                Id= 2,
                Name = "Megejas",
                PointsLevel= 2000
            },
            new UserLevel
            {
                Id= 3,
                Name = "Ekspertas",
                PointsLevel= 10000
            },
            new UserLevel
            {
                Id= 4,
                Name = "Guru",
                PointsLevel= 25000
            }
        };
    }
}
