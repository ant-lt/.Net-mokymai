using P049_LINQ_Extensions.Domain.Enums;
using P049_LINQ_Extensions.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_Extensions.Domain.Models
{
    public class HumanFactory : IHumanFactory
    {
        public IEnumerable<Human> Bing()
        {
            foreach (var character in CharacterInitialData.DataSeedCSV.Where(c => c.Contains("Human")))
            {
                var characterArray = character.Split(",");
                yield return new Human(characterArray[0].Trim(), characterArray[1].Trim(), (EGender)int.Parse(characterArray[4].Trim()));
            }
        }
    }
}
