﻿using P46_OOP_Baigiamasis.Interfaces;
using P46_OOP_Baigiamasis.Models;
using P46_OOP_Baigiamasis.Services;
using P46_OOP_Baigiamasis.Services.LogHandlers;
using System.Reflection.Metadata;

namespace P46_OOP_Baigiamasis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            var game = new Game(3, 4);
            
            game.Build(new List<Disk>
            {
                new Disk(1,0,1),
                new Disk(2,0,2),
                new Disk(3,0,3),
                new Disk(4,0,4),
            });
            GameUi ui = new GameConsoleUi(game);
            GameOptions options = (new OptionsManager("game.cfg")).Read();
            IGameLogManagerFactory gameLogMangerFactory = new GameLogManagerFactory(options, now);
            IGameLogManager logger = gameLogMangerFactory.Build();

            IGameLogManager logReader = new GameLogManager(new List<IGameLogHandler>
            {
                new HtmlGameLogHandler(now, new FileManager("game.html")),
                new SpeechGameLogHadler(now, new FileManager("game.txt")),
                new CsvGameLogHandler(now, new FileManager("game.csv")),
            });

            IGameFunctionManager functionManager = new GameFunctionManager(new List<IGameFunction>
            {
                new GameFunctionManager.TakeDisk(game,logger),
                new GameFunctionManager.PutDiskToEmptyPile(game,logger),
                new GameFunctionManager.PutDiskToNonEmptyPile(game,logger),
                new GameFunctionManager.Help(game, logReader),
            });
            
            IGameFunctionValidator validator = new GameFunctionValidator(new List<IConcreteGameFunctionValidator>
            {
                new GameFunctionValidator.InvalidSymbol(game, "qwertyuiop[]asdfgjkl;zxcvbnm,./"),
                new GameFunctionValidator.WrongPileNo(game),
                new GameFunctionValidator.PileContainsSmallerDisk(game),
                new GameFunctionValidator.PileEmpty(game),
            });



            ConsoleKeyInfo input = default;
            while (input.Key != ConsoleKey.Escape)
            {
                ui.Display();
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    if (validator.Validate(input.KeyChar.ToString()))
                        functionManager.Invoke(input.KeyChar.ToString());
                }
            }
        }
        
    }


    
    /*
SUKURTI ŽAIDIMĄ TOWER OF HANOI
 Tower Of Hanoi
  Ėjimas 0

   Diskas rankoje: 

  1eil.       |            |            |      
  2eil.      #|#           |            |      
  3eil.     ##|##          |            |      
  4eil.    ###|###         |            |      
  5eil.   ####|####        |            |      
        -----[1]----------[2]----------[3]------

  Norėdami išeiti paspauskite 'Esc' 
  Pagalbai paspauskite 'H' 
  Pasirinkite stulpelį iš kurio paimti


ŽAIDIMO TAISYKLĖS:
- ŽAIDŽIAMAS 4 DISKŲ IR 3 STULPELIŲ ŽAIDIMAS
- NUDOTOJAS ĮVEDA STULPELIO NR IŠ KURIO PAIMTI VIRŠUTINĮ DISKĄ
- PAIMTI GALIMA TIK VIENĄ IR TIK VIRŠUTINĮ DISKĄ
- NAUDOTOJAS TURI MATYTI KOKĮ DISKĄ PAĖMĖ
- NAUDOTOJAS TURI MATYTI IŠ KURIO STULPELIO PAĖMĖ DISKĄ KURĮ TURI RANKOJE
- VIENĄ ĖJIMĄ SUDARO VIRŠUTINIO DISKO PAĖMIMAS IR PADĖJIMAS
- ĖJIMAI TURI BŪTI SKAIČIUOJAMI
- NEGALIMA DIDESNĮ DISKĄ PADĖTI ANT MAŽESNIO 
   (TOKES ĖJIMAS NESKAIČIUOJAMAS)
   (RAUDONA SPALVA IŠVESTI 'NEGALIMA DIDESNIO DISKO DĖTI ANT MAŽESNIO')
- JEI SULPELYJE NĖRA DISKŲ NIEKO PAIMTI NEGALIMA
   (TOKES ĖJIMAS NESKAIČIUOJAMAS)
   (RAUDONA SPALVA IŠVESTI 'STULPELYJE NĖRA DISKO')
- JEI ĮVESTAS NEEGZISTUOJANTIS SULPELIS 
   (TOKES ĖJIMAS NESKAIČIUOJAMAS)
   (RAUDONA SPALVA IŠVESTI 'NETEISINGA ĮVESTIS')
- NUSPAUDUS 'ESC' KLAVIŠĄ ŽAIDIMAS TURI BAIGTIS
- NUSPAUDUS 'H' KLAVIŠĄ IŠKVIEČIAMA PAGALBA (APRAŠYMAS TOLIAU)

UŽDUOTYS:
1. KIEKVIENAS ĖJIMAS TURI BŪTI ĮRAŠOMAS. 
  - ĮRAŠYMAS VYKDOMAS Į SKIRTINGUS FAILĄ(-US) (IŠPLĖTIMAS NURODYTAS) 
  - GALIMO FAILŲ TURINIO FORMATAI (TIKSLŪS KONTRAKTAI APRAŠYTI ŽEMIAU):
  (.csv) CSV  
  (.html) HTML <table>....</table> 
  (.txt) NATŪRALI KALBA PVZ: "žaidime kuris pradėtas 2022-01-01 12:00, ėjimu nr 2 dviejų dalių diskas buvo paimtas iš pirmo stulpelio ir padėtas į trečią" 
  - BŪTINAS UNIT-TEST AR TEISINGAI SUFORMUOTAS FAILO TURINYS
  - GALI BŪTI PASIRINKTAS VIENAS ARBA VISI FORMATAI. 
  - NEGALIMA NEPASIRINKTI NEI VIENO. 
  - PASIRINKIMAS PADAROMAS PROGRAMOS PALEIDIMO METU PESKAIČIUS KONFIGURACINĮ FAILĄ game.config

2. TURI BŪTI GALIMYBĖ PERŽIŪRĖTI ŽAIDIMO STATISTIKĄ.
  - SKAITANT ŽAIDIMŲ ĮRAŠUS TURI BŪTI GALIMA SUGENERUTUOTI IR PAMATYTI ATASKAITĄ  (UNIT-TEST)
  - JEI ŽAIDIMAS BUVO NEBAIGTAS VIETOJ KIEKIO IŠVESTI N/B. POKYČIUI SKAIČIUOTI ŠIS ŽAIDIMAS NENAUDOJAMAS. PRIE POKYČIO IŠVESTI N/G.
  - SUSKAIČIUOTI ĖJIMŲ POKYTĮ NUO PASKUTINIO ŽAIDIMO
  - TURI BŪTI GALIMYBĖ ATASKAITOS STULPELĮ "Ėjimų kiekis iki laimėjimo" 
    PAKEISTI STULPELIU "Perteklinių ėjimų kiekis" (minimalus ėjimų kiekis yra 15)
    NAUDOTOJAS PASIRENKA KOKIOS FORMOS ATASKAITA NORI MATYTI
  - ATASKAITA TURI BŪTI IŠVEDAMA Į KONSOLĘ.
  - SERVISAI TURI MOKĖTI SKAITYTI VISUS FORMATUS (csv, html ir txt), TAČIAU PRIORITETAS TEIKIAMAS TOKIA TVARKA TXT -> HTML -> CSV (UNIT-TEST)

-------------------------------------------------------------- 
| Žaidimo data       | Ėjimų kiekis iki laimėjimo | Pokytis  |
-------------------------------------------------------------- 
|  2022-01-01 12:05  |    40                      |    N/G   |
--------------------------------------------------------------
|  2022-01-02 12:05  |    41                      |    +1    |
-------------------------------------------------------------- 
|  2022-01-02 12:10  |    N/B                     |    N/G   |
-------------------------------------------------------------- 
|  2022-01-02 12:15  |    15                      |   -26    |
-------------------------------------------------------------- 

-------------------------------------------------------------- 
| Žaidimo data       | Perteklinių ėjimų kiekis   | Pokytis  |
-------------------------------------------------------------- 
|  2022-01-01 12:05  |    25                      |    N/G   |
--------------------------------------------------------------
|  2022-01-02 12:05  |    26                      |    +1    |
-------------------------------------------------------------- 
|  2022-01-02 12:10  |    N/B                     |    N/G   |
-------------------------------------------------------------- 
|  2022-01-02 12:15  |    0                       |   -26    |
-------------------------------------------------------------- 


3. ŽAIDIMO METU ŽAIDĖJAS TURI TURĖTI GALIMYBĘ PAPRAŠYTI KOMPIUTERIO PAGALBOS
  - PAGALBOS SERVISAS NUSKAITO FAILO(-Ų) TURINĮ IR IEŠKO ĮRAŠYTOS ESAMOS SITUACIJOS (UNIT-TEST)
  - SERVISAS TURI MOKĖTI SKAITYTI VISUS FORMATUS (csv, html ir txt), TAČIAU PRIORITETAS TEIKIAMAS TOKIA TVARKA CSV -> HTML-> TXT (UNIT-TEST)
  - SURADUS JAU ŽAISTĄ TOKIĄ SITUACIJĄ SERVISAS PASIŪLO ĖJIMĄ su tekstu "paimkite diską iš ...... stulpelio padėkite į ......." (UNIT-TEST) 
  - JEI SITUACIJA NEBUVO RASTA, IŠVEDAMAS PRANEŠIMAS 'PAGALBA NEGALIMA' (UNIT-TEST)
  - JEI BUVO RASTOS KELIOS TOKIOS SITUACIJOS ATRENKAMA TAS ĖJIMAS KURIS GREIČIAUSIAI PRIVEDĖ PRIE LAIMĖJIMO (UNIT-TEST)
  - BŪTINAS UNIT-TEST AR TEISINGAI PADEDAMA, IR AR TIKRAI PARENKAMA GERIAUSIA ĮRAŠYTA PAGALBA              

            ↑↑↑↑↑        ↓↓↓↓↓
  1eil.       |            |            |      
  2eil.      #|#           |            |      
  3eil.     ##|##          |            |      
  4eil.    ###|###         |            |      
  5eil.   ####|####        |            |      
        -----[1]----------[2]----------[3]------

  <pagalba> - paimkite diską iš pirmo stulpelio ir padėkite į antrą
  Norėdami išeiti paspauskite 'Esc' 
  Pagalbai paspauskite 'H' 
  Pasirinkite stulpelį iš kurio paimti

4. BAIGIAMOJO DARBO KOREKTIŠKAM VEIKIMUI PATIKRINTI NAUDOJAMI TESTINIAI DUOMENYS .CSV, .HTML IR .TXT FAILUOSE
- ĮRAŠYTI TIE PATYS DUOMENYS GALI KARTOTIS KELIUOSE FAILUOSE. UNIKALUS RAKTAS YRA ŽAIDIMO DATA IR LAIKAS.
- DALIS ŽAIDIMO DUOMENŲ BUS VIENAME, DALIS KITAME FAILE, O DALIS KARTOSIS PER KELIS AR VISUS FAILUS, TODĖL NUSKAITYTI REIKIA VISUS
- BŪTINA LAIKYTIS ŽEMIAU PATEIKIAMŲ KONTRAKTŲ (atsiskaitymo metu dėstytojas gali paprašyti sudėti jo pateiktus testinius duomenis):

 ** CSV KONTRAKTAS
 zaidimo_pradzios_data, ejimo_nr, disko_1_vieta, disko_2_vieta, disko_3_vieta, disko_4_vieta 
PVZ:
2022-01-01 12:00,1,2,1,1,1
2022-01-01 12:00,2,2,3,1,1

 ** HTML LENTELĖS 
PVZ:
<table border>
<tr>
<th>ŽAIDIMO PRADŽIOS DATA</td>
<th>ĖJIMO NR</td>
<th>DISKO 1 VIETA</td>
<th>DISKO 2 VIETA</td>
<th>DISKO 3 VIETA</td>
<th>DISKO 4 VIETA</td>
</tr>
<tr>
<td>2022-01-01 12:00</td>
<td>1</td>
<td>2</td>
<td>1</td>
<td>1</td>
<td>1</td>
</tr>
<tr>
<td>2022-01-01 12:00</td>
<td>2</td>
<td>2</td>
<td>3</td>
<td>1</td>
<td>1</td>
</tr>
</table>

** NATŪRALIOS KALBOS VIENA EILUTĖ FORMUOJAMA TAIP:
 "žaidime kuris pradėtas {zaidimo_pradzios_data}, ėjimu nr {ejimo_nr} {disko_dydis} dalių diskas buvo paimtas iš {is_stulpelio_nr_zodziu} sulpelio ir padėtas į {i_stulpelio_nr_zodziu}" 
PVZ: 
žaidime kuris pradėtas 2022-01-01 12:00, ėjimu nr 1, 1 dalies diskas buvo paimtas iš pirmo stulpelio ir padėtas į antrą
žaidime kuris pradėtas 2022-01-01 12:00, ėjimu nr 2, 2 dalių diskas buvo paimtas iš pirmo stulpelio ir padėtas į trečią 

5. (BONUS) 
-
-
-
-

APRIBOJIMAI:
- TAIKYTI "Dependency inversion principle". t.y. VISI SERVISAI TURI BŪTI KONSTRUOJAMI Į INTERFACE
- TAIKYTI "Single-responsibility principle". t.y. KLASĖS TURI ATLIKTI TIK VIENOS ATSAKOMYBĖS UŽDUOTIS IR GALI BŪTI KEIČIAMOS TIK DĖL VIENOS PRIEŽASTIES 



 
 */


}