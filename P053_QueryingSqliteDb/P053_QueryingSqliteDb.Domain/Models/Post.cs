using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Domain.Models
{
    [Table("Post")]
    public class Post
    {
        // Naujausioje versijoje EF nebereikia naudoti [Key] jei musu primary key property vadinasi ClassNameId arba Id
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }

        // One to many relationship
        public int BlogId { get; set; } // Fizinis relationship property (Turesim savo Post lenteleje)
        public virtual Blog Blog { get; set; } // Navigacinis relationship property (Naudojamas tam, kad mes galetume naviguoti kode per Blog properties)

    }
}
