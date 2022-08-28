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
        /// Gražinti atgal ar tai filmas, daina ar žaidimas
        /// </summary>
        /// <returns></returns>
        string GetHobbyName();


        /// <summary>
        /// Grąžina atgal informaciją apie pati hobį pvz, kad tai filmas kažkokio žanro, kurio įvertinimas yra X/Y
        /// </summary>
        /// <returns></returns>
        string GetHobbyInformation();
    }
}
