using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Interfaces
{
    public interface ICordinate
    {

        /// <summary>
        /// grazina x ir y kordinates viename stringe
        /// </summary>
        /// <returns></returns>
        string GetCordinate();

        /// <summary>
        /// Grazina default reiksmes / metodus. 
        /// </summary>
        void ResetCordinate(); 
    }
}
