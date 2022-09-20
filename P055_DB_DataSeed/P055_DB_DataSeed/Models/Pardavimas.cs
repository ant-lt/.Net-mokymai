using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using P055_DB_DataSeed.Models;

namespace P055_DB_DataSeed.Models
{
    public class Pardavimas
    {
        [Key]
        public int PardavimasId { get; set; }
        public int BatuDydisId { get; set; }
        public int Kiekis { get; set; }
        public virtual BatuDydis BatuDydis { get; set; }

        [NotMapped]
        public virtual decimal Isleista => BatuDydis.Batas.Kaina * Kiekis;

    }
}
