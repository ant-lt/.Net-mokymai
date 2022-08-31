using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Models
{


    /// <summary>
    /// Kad nurodyti jog klase yra generic sintakse musu praso nurodyti <T> prierasa
    /// </summary>
    /// <typeparam name="T">Bet koks duomenu tipas</typeparam>
    public class NodeList<T>
    {
        public NodeList()
        {
            _nodes = new List<T>(); 
        }

        // Nurodome, jog musu List bus sudarytas is 
        private List<T> _nodes;

        /// <summary>
        /// Pridejimas T i sarasa
        /// </summary>
        /// <param name="node"></param>
        public void Add(T node)
        {
            _nodes.Add(node);
        }

        public void DeleteNode(T nodeToRemove)
        {
            _nodes.Remove(nodeToRemove);
        }

        public void ProcessAllNodes()
        {
            foreach (var node in _nodes)
            {
                Console.WriteLine(node.ToString());
            }
        }
    }
}
