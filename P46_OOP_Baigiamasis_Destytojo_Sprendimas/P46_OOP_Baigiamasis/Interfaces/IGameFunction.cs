using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46_OOP_Baigiamasis.Interfaces
{
    public interface IGameFunction
    {
        bool ApplysTo(string input);
        void Move(string input);
    }
}
