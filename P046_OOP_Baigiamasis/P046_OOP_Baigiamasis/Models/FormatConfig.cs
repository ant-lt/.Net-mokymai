using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Models
{
    internal class FormatConfig
    {
        public bool TXT { get; internal set; } = true;
        public bool HTML { get; internal set; } = false;
        public bool CSV { get; internal set; } = false;
    }
}
