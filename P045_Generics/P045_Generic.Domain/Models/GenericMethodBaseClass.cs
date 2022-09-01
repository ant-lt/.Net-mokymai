using P045_Generic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Models
{
    public class GenericMethodBaseClass
    {
        public bool Post<TPost> (TPost post) where TPost : IPost
        {
            if(typeof(TPost) == typeof(Tool) 
                || typeof(TPost) == typeof(DateTime))
            {
                return false;
            }

            return true;
        }

        public void Print<T>(T printableData)
        {
            Console.WriteLine(printableData);
        }
    }
}
