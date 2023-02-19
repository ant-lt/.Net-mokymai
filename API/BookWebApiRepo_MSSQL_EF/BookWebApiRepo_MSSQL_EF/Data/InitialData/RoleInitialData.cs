﻿using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Data.InitialData
{
    public static class RoleInitialData
    {
        public static readonly Role[] rolesInitialDataSeed = new Role[]
        {
            new Role
            {
                Id= 1,
                Name = "Administrator"
            },
            new Role
            { 
                Id= 2,
                Name = "Secretary"
            },
            new Role
            {
                Id= 3,
                Name = "Librarian"
            },
            new Role
            { 
                Id= 4,
                Name = "Reader"
            }
        };
    }
}