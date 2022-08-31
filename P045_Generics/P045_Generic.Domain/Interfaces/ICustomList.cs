using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Interfaces
{
    public interface ICustomList<T>
    {
        public void Add(T itemToAdd);

        public void DeleteNode(T itemToDelete);

        public void ProcessAllNodes();

    }
}
