using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_MUSIC_SHOP.Infrastrukture.Services
{
    public class MusisShopMenu
    {
        private KeyboardInput _keyboardInput = new KeyboardInput();

        internal int EntryMenu()
        {
            string menuText = @"--------------------------------------------------------------" + Environment.NewLine 
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Prisijungti                                          |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Registruotis                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 3.  | Darbuotojų Parinktys                                 |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine;

            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 3, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen:true);
        }


        /// <summary>
        /// Pirkimo ekrano pasirinkimas:
        /// 1 - Peržiūrėti katalogą
        /// 2 - Įdėti į krepšelį
        /// 3 - Peržiūrėti krepšelį
        /// 4 - Peržiūrėti pirkimų istorija (Išrašai) 
        /// </summary>
        /// <returns></returns>
        internal int PurchaseMenu()
        {
            string menuText = @"[PIRKIMO EKRANAS]:" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Peržiūrėti katalogą                                  |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Įdėti į krepšelį                                     |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 3.  | Peržiūrėti krepšelį                                  |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 4.  | Peržiūrėti pirkimų istorija (Išrašai)                |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine;


            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 4, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: true);
        }


        /// <summary>
        /// rikiavimo funkcijos:
        /// 1 - Pagal Name abecėlės tvarka
        /// 2 - Pagal Name atvirkštine abecėlės tvarka
        /// 3 - Pagal Composer
        /// 4 - Pagal Genre
        /// 5 - Pagal Composer ir Album  
        /// </summary>
        /// <returns></returns>
        internal int TracksSortingFunctions()
        {
            string menuText = @"{Pagrindinės rikiavimo funkcijos}:" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Pagal Name abecėlės tvarka                           |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Pagal Name atvirkštine abecėlės tvarka               |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 3.  | Pagal Composer                                       |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 4.  | Pagal Genre                                          |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 5.  | Pagal Composer ir Album                              |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             ;

            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 5, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: true);
        }

        /// <summary>
        /// Paieškos funkcijos:
        /// 1 - Pagal Id
        /// 2 - Pagal Name 
        /// 3 - Pagal Composer
        /// 4 - Pagal Genre
        /// 5 - Pagal Composer ir Album 
        /// 6 - Pagal Milliseconds (Mažiau nei X arba daugiau nei X)
        /// </summary>
        /// <returns></returns>
        internal int TrackSearchFunctions()
        {
            string menuText = @"{Pagrindinės paieškos funkcijos}:" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Pagal Id                                             |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Pagal Name                                           |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 3.  | Pagal Composer                                       |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 4.  | Pagal Genre                                          |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 5.  | Pagal Composer ir Album                              |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 6.  | Pagal Milliseconds (Mažiau nei X arba daugiau nei X) |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             ;
            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 6, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: true);
        }

        /// <summary>
        /// Įdėti į krepšelį:
        /// 1 - Pagal Id
        /// 2 - Pagal Name 
        /// 3 - Pagal albumo Id
        /// 4 - Pagal albumo pavadinimą
        /// </summary>
        /// <returns></returns>
        internal int AddToCardTracksSearchOptions()
        {
            string menuText = @"[PIRKIMO EKRANAS->Įdėti į krepšelį]:" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Rasti dainą pagal Id                                 |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Rasti dainą pagal pavadinimą                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 3.  | Rasti dainas pagal albumo Id                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 4.  | Rasti dainas pagal albumo pavadinimą                 |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             ;
 
            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 4, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: true);
        }

        /// <summary>
        /// DARBUOTOJU PARINKTYS:
        /// 1 - Keisti klientų duomenis
        /// 2 - Pakeisti dainos statusą
        /// 3 - Statistika (Darbuotojams)
        /// </summary>
        /// <returns></returns>
        internal int EmployeesOptions()
        {
            string menuText = @"[DARBUOTOJU PARINKTYS EKRANAS]:" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Keisti klientų duomenis                              |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Pakeisti dainos statusą                              |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 3.  | Statistika (Darbuotojams)                            |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             ;

            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 3, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: true);
        }


        /// <summary>
        /// Keisti klientų duomenis
        /// 1 - Gauti pirkėjų sąrašą
        /// 2 - Pašalinti pirkėją pagal ID
        /// 3 - Modifikuoti pirkėjo duomenis
        /// </summary>
        /// <returns></returns>
        internal int ChangeCustomerDataOptions()
        {
            string menuText = @"[DARBUOTOJU PARINKTYS EKRANAS->Keisti klientų duomenis]:" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Gauti pirkėjų sąrašą                                 |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Pašalinti pirkėją pagal ID                           |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 3.  | Modifikuoti pirkėjo duomenis                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             ;

            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 3, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: true);
        }

        /// <summary>
        /// Pakeisti dainos statusą:
        /// 1 - Gauti dainų sąrašą
        /// 2 - Keisti dainos statusą
        /// </summary>
        /// <returns></returns>
        internal int ChangeTrackStatusOptions()
        {
            string menuText = @"[DARBUOTOJU PARINKTYS EKRANAS->Pakeisti dainos statusą]:" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Gauti dainų sąrašą                                   |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Keisti dainos statusą                                |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             ;

            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 2, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal int TrackStatusOptions()
        {
            string menuText = @"[Pakeisti dainos statusą į]:" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                         |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Active                                               |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Inactive                                             |" + Environment.NewLine
                             + "--------------------------------------------------------------" + Environment.NewLine
                             ;

            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 2, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: false);
        }


        /// <summary>
        /// Statistika (Darbuotojams):
        /// 1 - Išgauti visas kliento atąskaitas pagal kliento ID
        /// 2 - Išgauti veiklos pelna (Neatskaičius mokesčių pilna suma)
        /// 3 - Išgauti veiklos pelną pagal paduotus metus
        /// 4 - Išgauti kiek kokio žanro kūrinių buvo nupirkta
        /// 5 - Išgauti kiek kiekvienas klienas išleido pinigų
        /// </summary>
        /// <returns></returns>
        internal int EmployeesStatistics()
        {
            string menuText = @"[DARBUOTOJU PARINKTYS EKRANAS->Statistika (Darbuotojams)]:" + Environment.NewLine
                             + "----------------------------------------------------------------" + Environment.NewLine
                             + "| #   | Pasirinkimas                                            |" + Environment.NewLine
                             + "----------------------------------------------------------------" + Environment.NewLine
                             + "| 1.  | Išgauti visas kliento atąskaitas pagal kliento ID       |" + Environment.NewLine
                             + "----------------------------------------------------------------" + Environment.NewLine
                             + "| 2.  | Išgauti veiklos pelna (Neatskaičius mokesčių pilna suma)|" + Environment.NewLine
                             + "----------------------------------------------------------------" + Environment.NewLine
                             + "| 3.  | Išgauti veiklos pelną pagal paduotus metus              |" + Environment.NewLine
                             + "----------------------------------------------------------------" + Environment.NewLine
                             + "| 4.  | Išgauti kiek kokio žanro kūrinių buvo nupirkta          |" + Environment.NewLine
                             + "----------------------------------------------------------------" + Environment.NewLine
                             + "| 5.  | Išgauti kiek kiekvienas klientas išleido pinigų         |" + Environment.NewLine
                             + "----------------------------------------------------------------" + Environment.NewLine
                             ;

            return _keyboardInput.GetMenuChoose(menuText: menuText, maxMenuItemsCount: 5, inputVisible: false, addKeyActive: false, addKeyText: "", sortKeyActive: false, searchKeyActive: false, clearScreen: true);
        }


    }
}
