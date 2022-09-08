using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_Extensions.Domain.Models
{
    public static class CharacterInitialData
    {
        public static List<string> DataSeedCSV => new List<string>
        {
            //FirstName, LastName, Race, ProfessionId, Gender (0-Male, 1-Female)
            $"Keanu, Horton, Human,1,0",
            $"Sia, Bains, Human,1,1",
            $"Blane,Thompson,Human,1,1",
            $"Jesse,Lyons,Human,1,1",
            $"Shiloh,Sandoval,Human,1,0",
            $"Arjun,Fry,Human,1,0",
            $"Jasper,Allman,Human,1,0",
            $"Sydney,Keeling,Human,1,0",
            $"Viktor,Rojas,Human,18,0",
            $"Callie,Spears,Human,13,1",
            $"Halima,English,Human,15,1",
            $"Shelley,Franklin,Human,11,1",
            $"Mitchel,Jenkins,Human,19,0",
            $"Mairead,Long,Human,2,1",
            $"Rodney,Burn,Human,2,0",
            $"Billie-Jo,Hopkins,Human,3,0",
            $"Jordan,Ellwood,Human,4,0",
            $"Isa,Duggan,Human,4,1",
            $"Tiya,Leal,Human,4,1",
            $"Dale,Mccullough,Human,5,1",
            $"Kaeden,Baker,Human,5,0",
            $"Amit,Squires,Human,5,0",
            $"Thelma,Hoffman,Human,5,1",
            $"Farhaan,Bradford,Human,5,0",
            $"Tahmina,Keenan,Human,6,0",
            $"Elize,Ferry,Human,6,1",
            $"Cloe,Carpenter,Human,6,0",
            $"Husna,Esquivel,Human,7,0",
            $"Cecelia,Mackenzie,Human,8,1",
            $"Ruqayyah,Boone,Human,23,0",
            $"Alanah,Vaughan,Human,24,0",
            $"Mustafa,Arnold,Human,25,0",
            $"Ella-Grace,Hayden,Human,26,1",
            $"Lacey-Mai,Beltran,Human,27,1",
            $"Bryn, Mosley,Human,28,0",
            $"Charlie, Riddle,Human,28,1",
            $"Gregory,Powell,Human,1,0",       //Isaac Asimov
            $"Mike,Donovan,Human,1,0",         //Isaac Asimov
            $"Clinton,Madarian,Human,29,1",    //Isaac Asimov
            //https://en.wikipedia.org/wiki/List_of_Foundation_series_characters
            $"Arcadia,Darell,Human,30,1",      //Isaac Asimov Fontadion
            $"Ammel,Brodrig,Human,30,0",       //Isaac Asimov Fontadion
            $"Anselm,haut Rodric,Human,24,0",  //Isaac Asimov Fontadion
            $"Bail,Channis,Human,6,0",         //Isaac Asimov Fontadion
            $"Bel,Arvardan,Human,31,0",        //Isaac Asimov Fontadion
            $"Bel,Riose,Human,6,0",            //Isaac Asimov Fontadion
            $"Bor,Alurin,Human,29,0",          //Isaac Asimov Fontadion
            $"Dors,Venabili,Human,32,1",       //Isaac Asimov Fontadion
            $"Hari,Seldon,Human,7,0",          //Isaac Asimov Fontadion
            $"Janov,Pelorat,Human,32,0",       //Isaac Asimov Fontadion
            $"King Lepold I,,Human,25,0",      //Isaac Asimov Fontadion
            $"Salvor,Hardin,Human,25,0",       //Isaac Asimov Fontadion
            //-----
            $"Al'arok,,Skrull,5,0",
            $"Ard'ran,,Skrull,1,0",
            $"Cadre,K,Skrull,5,1",
            $"Ch'gra,,Skrull,17,0",
            $"Ch'rith,,Skrull,5,0",
            $"Dalx,,Skrull,24,0",
            $"Gorth,,Skrull,25,0",
            $"Grrix,,Skrull,26,0",
            $"Hagar,,Skrull,17,0",
            $"H'kurrek,,Skrull,6,0",
            $"Jora'thrll,,Skrull,5,0",
            $"K'and'rr,,Skrull,6,0",
            $"K'vvvr,,Skrull,6,1",
            $"Nenora,,Skrull,27,0",
            $"Zedrao,,Skrull,6,1",
            $"Zirksu,,Skrull,27,1",
            //----
            $"Elleanor,Park,Kree,5,1",
            $"Bryn,Barton,Kree,5,0",
            $"Arielle,Cullen,Kree,6,1",
            $"Aiza,Avery,Kree,8,1",
            $"Abbie,Jenkins,Kree,9,1",
            $"Toyah,Irwin,Kree,9,0",
            $"Esmai,Haynes,Kree,1,1",
            //----
            $"Caspian,Carroll,Chitauri,1,0",
            $"Danniella,Dalby,Chitauri,1,0",
            $"Eisa,Rich,Chitauri,4,0",
            $"Reema,Frame,Chitauri,6,0",
            $"Kaitlan,Winters,Chitauri,7,0",
            $"Sue,Hahn,Chitauri,1,0",
            $"Viktoria,Wynn,Chitauri,9,0",
            $"Mayson,Cortez,Chitauri,1,0",
            //----
            $"Apocolothoth,,OldOne,,", //H. P. Lovecraft fictional universe, Cthulhu Mythos deities
            $"Bokrug,,OldOne,,", //H. P. Lovecraft fictional universe, Cthulhu Mythos deities
            $"Cthulhu,,OldOne,,",//H. P. Lovecraft fictional universe, Cthulhu Mythos deities
            $"Hypnos,,OldOne,,", //H. P. Lovecraft fictional universe, Cthulhu Mythos deities
            $"Oryx,,OldOne,,",   //H. P. Lovecraft fictional universe, Cthulhu Mythos deities
          

        };
    }
}
