﻿namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class UserLevel
    {
        public UserLevel()
        {
           
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int  PointsLevel { get; set; }

        public virtual LocalUser LocalUser { get; set; }
    }
}
