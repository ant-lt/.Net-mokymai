﻿namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class FilterBookRequest
    {
        public string Pavadinimas { get; set; }

        public string Autorius { get; set; }

        public string KnygosTipas { get; set; }
    }
}