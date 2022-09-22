using System.ComponentModel.DataAnnotations;

namespace P053_QueryingSqliteDb_Namu_darbas.Database.Models
{
    //[Table("ShoeSize")]
    public class ShoeSize
    {
        [Key]
        public int Id { get; set; }
        public int Size { get; set; }
        public int Quantity { get; set; }
        public int ShoeID { get; set; }

        public virtual Shoes Shoe { get; set; }
    }
}
