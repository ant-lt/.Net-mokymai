using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb_Namu_darbas.Database.Models
{
    //[Table("Shoes")]
    public class Shoes
    {
        [Key]
        public int ShoeId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string Type { get; set; }


        public decimal Price { get; set; }

        public virtual ICollection<ShoeSize> ShoeSizes { get; set; } = new HashSet<ShoeSize>();


    }
}
