using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Models
{
    public class Tower
    {
        internal bool IsTowerFromSelected { get; set; } = false;
        public Tower()
        {
         
        }
        public List<Disc> Disks { get; set; } = new List<Disc>();

    }
}
