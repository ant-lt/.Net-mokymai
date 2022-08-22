using P038_Praktika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Praktika.InitialData
{
    public static partial class ProfessionInitialData
    {
        public static readonly Profession[] DataSeed =
            {
                new Profession(1){ Text="Accountant",      TextLt = "Buhalteris",  },
                new Profession(2) { Text="Actor",           TextLt = "Aktorius",  },
                new Profession(3) { Text="Architect",       TextLt = "Architektas",  },
                new Profession(4) { Text="Pharmacist",      TextLt = "Vaistininkas",  },
                new Profession(5) { Text="Programmer",      TextLt = "Programuotojas",  },
                new Profession(6) { Text="Designer",        TextLt = "Dizaineris",  },
                new Profession(7) { Text="Manager",          TextLt = "Vadybininkas",  },
                new Profession(8) { Text="Engineer",         TextLt = "Inžinierius",  },
                new Profession(9) { Text="Farmer",           TextLt = "Ūkinintas",  },
                new Profession(10) { Text="Teacher",         TextLt = "Mokytojas",  },
                new Profession(11) { Text="Judge",           TextLt = "Teisėjas",  },
                new Profession(12) { Text="Lawyer",          TextLt = "Advokatas",  },
                new Profession(13) { Text="Lecturer",        TextLt = "Lektorius",  },
                new Profession(14) { Text="Model",           TextLt = "Modelis",  },
                new Profession(15) { Text="Photographer",    TextLt = "Fotografas",  },
                new Profession(16) { Text="Scientist",       TextLt = "Mokslininkas",  },
                new Profession(17) { Text="Medical doctor",  TextLt = "Daktaras",  },
                new Profession(18) { Text="Singer",          TextLt = "Dainininkas",  },
                new Profession(19) { Text="Sports coach",    TextLt = "Treneris",  },
                new Profession(20) { Text="Artist",          TextLt = "Menininkas",  },

            };

        public static readonly string[] DataSeedCsvSemicolon =
                {
                "1;Accountant;Buhalteris",
                "2;Actor;Aktorius",
                "3;Architect;Architektas",
                "4;Pharmacist;Vaistininkas",
                "5;Programmer;Programuotojas",
                "6;Designer;Dizaineris",
                "7;Manager;Vadybininkas",
                "8;Engineer;Inžinierius",
                "9;Farmer;Ūkinintas",
                "10;Teacher;Mokytojas",
                "11;Judge;Teisėjas",
                "12;Lawyer;Advokatas",
                "13;Lecturer;Lektorius",
                "14;Model;Modelis",
                "15;Photographer;Fotografas",
                "16;Scientist;Mokslininkas",
                "17;Medical doctor;Daktaras",
                "18;Singer;Dainininkas",
                "19;Sports coach;Treneris",
                "20;Artist;Menininkas",
        };

        public static readonly string[] DataSeedCsvComma = {
                "1,Accountant,Buhalteris",
                "2,Actor,Aktorius",
                "3,Architect,Architektas",
                "4,Pharmacist,Vaistininkas",
                "5,Programmer,Programuotojas",
                "6,Designer,Dizaineris",
                "7,Manager,Vadybininkas",
                "8,Engineer,Inžinierius",
                "9,Farmer,Ūkinintas",
                "10,Teacher,Mokytojas",
                "11,Judge,Teisėjas",
                "12,Lawyer,Advokatas",
                "13,Lecturer,Lektorius",
                "14,Model,Modelis",
                "15,Photographer,Fotografas",
                "16,Scientist,Mokslininkas",
                "17,Medical doctor,Daktaras",
                "18,Singer,Dainininkas",
                "19,Sports coach,Treneris",
                "20,Artist,Menininkas",
        };
    }
}
