using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P053_QueryingSqliteDb_Namu_darbas.Database.Models
{
    //[Table("Sale")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int ShoeSizeId { get; set; }
        public int Pairs { get; set; }

        public virtual ShoeSize ShoeSize { get; set; }

        [NotMapped]
        public virtual decimal PurchaseTotal => ShoeSize.Shoe.Price * Pairs;
        
    }
}
