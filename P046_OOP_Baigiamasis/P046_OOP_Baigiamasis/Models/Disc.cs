using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Models
{
    public class Disc
    {
        private const int diskWidth = 6;
        public Disc(int countOfElements)
        {
            if (countOfElements < 0) countOfElements = 0;
            CountOfElements = countOfElements;
        }

        public int CountOfElements { get; private set; }

        private string DiskElements()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < CountOfElements; i++)
            {
                sb.Append('#');
            }
            return sb.ToString();
        }

        public string PrintDiskElements()
        {
            return string.Format($"{DiskElements(),diskWidth}|{DiskElements(),-diskWidth}");

        }
    }
}
