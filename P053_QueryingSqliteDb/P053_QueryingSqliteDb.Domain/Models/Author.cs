using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Domain.Models
{
    [Table("Author")]

    public class Author
    {
        [Key] // Nurodo Primary key
        public int AuthorId { get; set; }

        [MaxLength(150)] // Nurodo maksimalu char kieki, kuri galime paduoti savo lenteles stulpeliui
        [Required] // Padaro lauka privalomu SQL ir EF pusese
        public string FirstName { get; set; }

        [MaxLength(150)]
        public string LastName { get; set; }

        public virtual IList<AuthorBlog> AuthorBlogs { get; set; }
    }
}
