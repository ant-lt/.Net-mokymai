using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Interfaces
{
    public interface ITool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void PrintName();
    }
}
