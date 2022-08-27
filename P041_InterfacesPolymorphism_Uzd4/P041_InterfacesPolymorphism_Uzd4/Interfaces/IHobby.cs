using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P041_InterfacesPolymorphism_Uzd4.Interfaces
{
    public interface IHobby
    {
        string Name { get; }
        string Publisher { get; }
        string Genre { get; }
        int Rating { get; }

        /// <summary>
        /// Turetu grazinti atgal ar tai filmas, daina ar zaidimas
        /// </summary>
        /// <returns></returns>
        string GetHobbyName();


        /// <summary>
        /// Turetu grazinti atgal informacija apie pati hobi pvz, kad tai filmas kazkokio zanro, kurio ivertinimas yra X/Y
        /// </summary>
        /// <returns></returns>
        string GetHobbyInformation();
    }
}
