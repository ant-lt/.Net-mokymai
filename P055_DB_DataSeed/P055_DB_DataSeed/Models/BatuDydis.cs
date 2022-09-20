using System.ComponentModel.DataAnnotations;
using P055_DB_DataSeed.Models;

namespace P055_DB_DataSeed.Models
{
    public class BatuDydis
    {
        [Key]
        public int Id { get; set; }
        public int Dydis { get; set; }
        public int Kiekis { get; set; }
        public int BatasId { get; set; }
        public virtual Batas Batas { get; set; }

    }
}
