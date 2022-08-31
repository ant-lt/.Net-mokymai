using P045_Generic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Models
{

    // Dictionary implementuoja taip pat du skirtingus generic duomenu tipus
    public class NodeListFilterU<T, U> where T : U
    {
        private List<T> _nodes;

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

    public class NodeListWithMultipleTypes<T, U>
    {
        private Dictionary<T, U> nodeDictionary = new Dictionary<T, U>();
        public T TValue { get; set; }
        public U UValue { get; set; }

        public void Add(T tValue, U uValue)
        {
            nodeDictionary[tValue] = uValue;
        }
    }

    public class NodeListFilterSpecifiedMultipleInterface<T> where T : ITool, IFork
    {
        private List<T> _nodes;

        public void Add(T node)
        {
            // Turedami generic filtra, mes galime pasiekti atributus esancius filtruojamoje klaseje
            node.Id = 10;
            node.Name = "DefaultName";
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

    public class NodeListFilterSpecifiedInterface<T> where T : ITool
    {
        private List<T> _nodes;

        public void Add(T node)
        {
            // Turedami generic filtra, mes galime pasiekti atributus esancius filtruojamoje klaseje
            node.Id = 10;
            node.Name = "DefaultName";
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

    public class NodeListFilterSpecifiedClass<T> where T : Tool
    {
        private List<T> _nodes;

        public void Add(T node)
        {
            // Turedami generic filtra, mes galime pasiekti atributus esancius filtruojamoje klaseje
            node.Id = 10;
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

    // new() reiskia, kad mes galime naudoti tik klases, kurios turi tuscia konstruktoriu
    public class NodeListFilterClassNew<T> where T : class, new()
    {
        private List<T> _nodes;

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

    public class NodeListFilterClass<T> where T : class
    {
        private List<T> _nodes;

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

    public class NodeListFilterStruct<T> where T : struct
    {
        private List<T> _nodes;

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

    // Kad nurodyti jog klase yra generic sintakse musu praso nurodyti <T> prierasa
    // <T> siuo atveju gali buti betkoks duomenu tipas (string, DateTime, int, decimal etc)
    public class NodeList<T> : ICustomList<T>
    {
        public NodeList()
        {
            _nodes = new List<T>();
        }

        // Nurodome, jog musu List bus sudarytas is T duomenu tipo reiksmiu
        private List<T> _nodes;

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
