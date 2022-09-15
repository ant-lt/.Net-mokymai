using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Domain.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Column(Order = 0)]
        public int BlogId { get; set; }

        // Order == eiliskumas
        [Column(Order = 2)]
        public decimal Rating { get; set; }

        // DataAnnotations aprasinejame virs property, kuriam norim pritaikyti taisykles
        [Column("BlogName", Order = 1)] // Musu stulpelis pavadinimu Name bus sukonstruotas duombazeje kaip BlogName
        public string Name { get; set; }

        // Navigacines property, kad galima butu surasti siam irasui priklausancius kitus irasus
        // virtual sitoje vietoje naudojamas del to, kad mes naudojame Lazy Loading
        // Lazy Loading - tai budas istraukti priklausancius duomenis automatiskai vietoj to, kad mums reiketu
        // darasyti papildoma komanda pvz .include()
        public virtual List<Post> Posts { get; set; } // Lazy loading del virtual zodzio
        public virtual IList<AuthorBlog> AuthorBlogs { get; set; } // Lazy loading del virtual zodzio        

    }
}
