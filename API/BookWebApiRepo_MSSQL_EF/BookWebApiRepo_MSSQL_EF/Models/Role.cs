using System.Diagnostics;

namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Role
    {
        public Role()
        {
      //      LocalUsers = new HashSet<LocalUser>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

   //    public virtual ICollection<LocalUser> LocalUsers { get; set; }
    }
}
