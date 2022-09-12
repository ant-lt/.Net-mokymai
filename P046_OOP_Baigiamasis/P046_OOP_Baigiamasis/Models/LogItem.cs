using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Models
{
    public class LogItem
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public int Move { get; set; }
        public int Disk1 { get; set; }
        public int Disk2 { get; set; }
        public int Disk3 { get; set; }
        public int Disk4 { get; set; }
    }
}
