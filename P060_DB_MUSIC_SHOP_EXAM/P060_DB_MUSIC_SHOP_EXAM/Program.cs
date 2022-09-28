namespace P060_DB_MUSIC_SHOP_EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

/*

 * Duomenų bazių baigiamasis darbas: Muzikos elektroninė-parduotuvė
Baigiamąjam darbui naudokite: chinook.db (https://www.sqlitetutorial.net/sqlite-sample-database/)
Pagrindinis baigiamojo darbo tikslas turėti konsolinę elektroninę parduotuvę, kurioje galėtumėte kaip klientas užsiregistruoti, prisijungti, filtruoti/ieškoti dainų, atlikti pirkimus ir gauti išklotines; kaip darbuotojas turėtumėte turėti galimybę keisti ir/arba ištrinti klientų duomenis, keisti dainų statusus pagal kurį parduotuvę remsis ką turėtų atvaizduoti, gauti parduotuvės atąskaitas visų pardavimų.

Tam, kad galėtumėte pridėti [Status] stulpelį ir įgyvendinti vieną iš užduočių sąlygų jums reikės padaryti pakeitimą sukurtoje migracijoje, kuria privalėsite pasidaryti po Class failų sugeneravimo (Reverse-engineering). Instrukcija:
	1. Sugeneruojate visas klases naudodami scaffold
	2. Atliekate [add-migration]
	3. Sugeneruotoje migracijoje (TIK migracijoje, o ne Snapshot) ištrinate visą kodą Up ir Down, kad atrodytų taip kaip pavaizduota apačioje.
		public partial class InitialMigration : Migration
		    {
		        protected override void Up(MigrationBuilder migrationBuilder)
		        {
		            
		        }
		
		        protected override void Down(MigrationBuilder migrationBuilder)
		        {
		            
		        }
		    }
	4. Dabar galite atnaujinti betkurią klasę ir naudoti add-migration atnaujinant jūsų esamos duomenų bazės struktūrą.
	

UŽDUOTYS:
Sukurkite programą, kurioje galima būtų registruotis, prisijungti, pirkti ir gauti atąskaitas už
Padarytus pirkimus.
Pirmas langas turėtų būti skirtas registracijai, prisijungimui ir Employee skirtoms statistikoms. Jei naudotojas yra jau prisijungęs jis neturėtų grįžti į šį langą nebent pats pasirenka atsijungti nuo tuometinės aktyvios paskyros. (Būnant betkuriame lange turėtų būti galimybę parašyti 'q' raidę, kad grįžti į praeitą langą)
-------------------------------------------------------------- 
| #       | Pasirinkimas | 
-------------------------------------------------------------- 
| 1.  |   Prisijungti        |  
--------------------------------------------------------------
| 2.  |   Registruotis     |  
--------------------------------------------------------------
| 3.  |   Darbuotojų Parinktys        |  
--------------------------------------------------------------

EKRANAS [ENTRY EKRANAS]:
Pasirinkus "Prisijungti" turėtų išmesti visus esamus Customers su jiems priklausančiais ID. Pasirinkus ID vartotojas turėtų būti prijungtas prie sistemos ir matyti pirkimo langą.
Pasirinkus "Registruotis" vartotojas turėtų įvesti visus privalomus ir pasirinktinai optional Customer laukus. Jei registracija buvo sėkminga turėtų atsirasti naujas įrašas Customers lentelėje, jei registracija nepavyko turėtų atsirasti pranešimas su žinute kodėl registracija nepavyko ir būtų liepiama atnaujinti klaidą išmetusius laukus neišeinant iš registracijos lango.
Pasirinkus "Darbuotojų Parinktys" programa turėtų paprašyti PIN kodo (Gali būti talpinamas kažkur kode kaip const kintamasis), kurį įvedus turėtų atvesti vartotoją darbuotojo parinkciu. 
Kaip bonusą "Darbuotojų Parinktys" galite pasidaryti pasirinkimą, kuriame turėtume įrašyti EmployeeId kaip, kuris darbuotojas šiuo metu norėtumėte prisijungti.


EKRANAS [PIRKIMO EKRANAS]:

-------------------------------------------------------------- 
| #       | Pasirinkimas | 
-------------------------------------------------------------- 
| 1.  |   Peržiūrėti katalogą |  
--------------------------------------------------------------
| 2.  |   Įdėti į krepšelį     |  
--------------------------------------------------------------
| 3.  |   Peržiūrėti krepšelį     |  
--------------------------------------------------------------
| 4.  |   Peržiūrėti pirkimų istorija (Išrašai) |  
--------------------------------------------------------------


EKRANAS [PIRKIMO EKRANAS->Peržiūrėti katalogą]:
Pasirinkus "Peržiūrėti katalogą" turėtų išmesti visus esamus Tracks įrašus, kurių Status yra "Active". Šiam uždaviniui išspręsti turite atnaujinti Tracks lentelę ir pridėti naują stulpelį [Status] su default reiksme "Active". Darbuotojai turės galimybę pakeisti Tracks status iš Active į Inactive ir atvirkščiai. Šiame lange naviguoti turi būti galima naudojant raides 'q' - grįžti atgal; 'o' - turėtų atidaryti rikiavimo langą, kuriame vartotojas galėtų pasirinkti pagal ką rikiuoti, 's' - turėtų atidaryti paieškos langą, kuriame vartotojas galėtų pasirinkti pagal ką ieškoti.  Kiekvienam Track atvaizduokite tai kas jūsų nuomone yra svarbiausios dalys apsipirkinėjant šiam atvejui būtina įdėti Id, Name, Composer, Genre->Name, Album->Title, Milliseconds, Price.
{Pagrindinės rikiavimo funkcijos}:
Pagal Name abecėlės tvarka
Pagal Name atvirkštine abecėlės tvarka
Pagal Composer
Pagal Genre
Pagal Composer ir Album

{Pagrindinės paieškos funkcijos}:
Pagal Id
Pagal Name
Pagal Composer
Pagal Genre
Pagal Composer ir Album
Pagal Milliseconds (Mažiau nei X arba daugiau nei X)
(BONUS) Pagal Album ir Artist

(BONUS - DARYKITE TIK JEI BŪSITE PABAIGĘ VISA KITA) Padarykite jūsų katalogas turėtų puslapiavimą. Prie esamų funkcijų pridėkite 'a' ir 'd' raides kaip galimybę eiti pirmyn arba atgal per katalogo puslapius. Kiekvienas puslapis turėtų turėti 10 Tracks. Apačioje turėtų atvaizduoti kuriame puslapyje šiuo metu esame ir kiek iš viso puslapių yra. Pasidarykite patikrą, kad vartotojas negalėtų nužygiuoti toliau nei esami puslapiai. (BONUS) Įdėkite 'x' komandą, kuri leistų įvesti į kurį puslapį norite nusigauti.



EKRANAS [PIRKIMO EKRANAS -> Peržiūrėti katalogą]:

-------------------------------------------------------------- 
| #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | 
-------------------------------------------------------------- 
| Id.  |    Name, Composer, Genre->Name, Album->Title, Milliseconds, Price |  
--------------------------------------------------------------

EKRANAS [PIRKIMO EKRANAS->Įdėti į krepšelį]:
Pasirinkus "Įdėti į krepšelį" turi vartotojui į ekraną išvesti parinktis pagal, kurias vartotojas galės nuspręsti ką įsidėti į krepšelį. Privalo būti bent 4 pasirinkimai:
	1. Daina pagal Id
	2. Daina pagal pavadinimą
	3. Dainos pagal albumo Id
	4. Dainos pagal albumo pavadinimą
Pasirinkus vieną iš opcijų į ekraną turi būti išvedami visi įrašai su pavadinimais, jų kainom ir visa kita reikalinga informacija, kurie atitinka pateiktą sąlygą. Apačioje turi būti atvaizduojamos parinktys:
'q' - grįžti atgal
'y' - Įdeda į krepšelį visas rastas dainas

EKRANAS [PIRKIMO EKRANAS->Įdėti į krepšelį]:
-------------------------------------------------------------- 
| #       | Pasirinkimas | 
-------------------------------------------------------------- 
| 1.  |   Rasti dainą pagal Id |  
--------------------------------------------------------------
| 2.  |   Rasti dainą pagal pavadinimą |  
--------------------------------------------------------------
| 3.  |    Rasti dainas pagal albumo Id |  
--------------------------------------------------------------
| 4.  |   Rasti dainas pagal albumo pavadinimą       |  
--------------------------------------------------------------

EKRANAS [PIRKIMO EKRANAS->Įdėti į krepšelį->Rastos dainos]:
-------------------------------------------------------------- 
| #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | 
-------------------------------------------------------------- 
| Id.  |    Name, Composer, Genre->Name, Album->Title, Milliseconds, Price |  
--------------------------------------------------------------
'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas

(BONUS - DARYKITE TIK JEI BŪSITE PABAIGĘ VISA KITA [NĖRA BŪTINA]) Padarykite, kad perkant visą albumą pritaikytų 25% nuolaidą perkamoms dainoms.

EKRANAS [PIRKIMO EKRANAS->Peržiūrėti krepšelį]:
Pasirinkus "Peržiūrėti krepšelį" programa turėtų į ekraną išvesti visas dainas su jiems būtinais laukais (Name, price etc) ir apačioje turėtų išvesti įmanomas komandas.
'q' - Grįžti atgal || 'y' - Užbaigti pirkimą

EKRANAS [PIRKIMO EKRANAS->Peržiūrėti krepšelį]:
-------------------------------------------------------------- 
| #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | 
-------------------------------------------------------------- 
| Id.  |    Name, Composer, Genre->Name, Album->Title, Milliseconds, Price |  
--------------------------------------------------------------
'q' - Grįžti atgal || 'y' - Užbaigti pirkimą

EKRANAS [PIRKIMO EKRANAS->Peržiūrėti krepšelį->Užbaigti pirkimą]:
Pasirinkus "Užbaigti pirkimą" programa turėtų atspausdinti visą informaciją apie Invoice, kaip kliento vardas, pavardė, adresas, postalcode, telefono numeris ir visa kita informacija. Po kliento duomenų turėtų būti surašyti visos nupirktos dainos su joms būtina priklausančia informacija. Po nupirktų dainų sąrašu turėtų parašyti galutinę sumą be privalomo mokesčio (Tax), privalomo mokesčio suma ir galutinė mokėtina suma. Šiam uždaviniui Tax bus fiksuoto dydžio 21%, kurį galite laikyti kaip konstantą savo programoje.

EKRANAS [PIRKIMO EKRANAS->Peržiūrėti krepšelį->Užbaigti pirkimą]:
-------------------------------------------------------------- 
Name:Name
Surname:Surname
Address:Address
Phone:Phone
...
PostalCode:PostalCode
-------------------------------------------------------------- 
| #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | 
-------------------------------------------------------------- 
| Id.  |    Name, Composer, Genre->Name, Album->Title, Milliseconds, Price |  
--------------------------------------------------------------
Total without Tax: Total
Tax: 21%
Total: Total+21%
--------------------------------------------------------------
'q' - Grįžti atgal (Grįžta į PIRKIMO EKRANAS)

EKRANAS [PIRKIMO EKRANAS->Peržiūrėti pirkimų istorija (Išrašai)]:
Pasirinkus "Peržiūrėti pirkimų istorija (Išrašai)" į ekraną turi būti išvedami visi sukurti išrašai šiam prisijungusiam klientui.

InvoiceId:InvoiceId
-------------------------------------------------------------- 
Name:Name
Surname:Surname
Address:Address
Phone:Phone
...
PostalCode:PostalCode
-------------------------------------------------------------- 
| #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | 
-------------------------------------------------------------- 
| Id.  |    Name, Composer, Genre->Name, Album->Title, Milliseconds, Price |  
--------------------------------------------------------------
Total without Tax: Total
Tax: 21%
Total: Total+21%
--------------------------------------------------------------

***************************************************************************


EKRANAS [DARBUOTOJU PARINKTYS EKRANAS]:
-------------------------------------------------------------- 
| #       | Pasirinkimas | 
-------------------------------------------------------------- 
| 1.  |   Keisti klientų duomenis |  
--------------------------------------------------------------
| 2.  |   Pakeisti dainos statusą     |  
--------------------------------------------------------------
| 3.  |   Statistika (Darbuotojams)        |  
--------------------------------------------------------------

Pasirinkus "Statistika (Darbuotojams)" programa turėtų paprašyti PIN kodo (Gali būti talpinamas kažkur kode kaip const kintamasis), kurį įvedus turėtų atvesti vartotoją prie statistikos ištraukimo funkcijų.


EKRANAS [DARBUOTOJU PARINKTYS EKRANAS->Keisti klientų duomenis]:
Pasirinkus "Keisti klientų duomenis" turėtų leisti vartotojui išgauti, modifikuoti ir ištrinti vartotojo pasirinkto vartotojo duomenis.

EKRANAS [DARBUOTOJU PARINKTYS EKRANAS->Keisti klientų duomenis]:
-------------------------------------------------------------- 
| #       | Pasirinkimas | 
-------------------------------------------------------------- 
| 1.  |   Gauti pirkėjų sąrašą |  
--------------------------------------------------------------
| 2.  |   Pašalinti pirkėją pagal ID |  
--------------------------------------------------------------
| 3.  |   Modifikuoti pirkėjo duomenis    |  
--------------------------------------------------------------

Parinktys [1] ir [2] yra aiškios, todėl darykite pagal tokius standartus kokius taikėte praeitiems uždaviniams t.y. Gaunant pirkėjų sąrašą laikykis tvarkingo formato, kur galima perpanaudokit metodus, pašalinant pirkėją paprašykite įvesti ID ir vadovaukitės saugumo principu išvesdami į ekraną ir patikrindami ar tikrai norima atlikti šį veiksmą.
Pasirinkus [3] jums turi liepti įvesti ID pirkėjo, kurio duomenis norite keisti. Pasirinkus pirkėją turėtų išvesti į ekraną kiekvieną keičiamą pirkėjo informacijos lauką į ekraną su jau užpildytais esamais duomenimis pvz: keičiam Customer { Name: "Jonas"} duomenis, mums paprašius šio Customer duomenų keitimą į ekraną turėtų išvesti:
Name:
Jonas
Taip, kad žinotume ką keičiame. Taip darykite su visais privalomais laukais, kurie atrodo logiškiausi tokiais operacijai įgyvendinti.

EKRANAS [DARBUOTOJU PARINKTYS EKRANAS->Pakeisti dainos statusą]:
Pasirinkus "Pakeisti dainos statusą" ekrane turime gauti 2 pasirinkimus:
	1. Gauti dainu sarasa
	2. Keisti dainos statusą
[1] išveda į ekraną suformatuotas dainas. [2] Liepia įvesti dainos ID. Įvedus dainos ID [2] užklausoje mums į ekraną turėtų išvesti koks yra esamas statusas ir lieptų pasirinkti ar norime keisti į [Active] arba [Inactive] statusus. Pasirinkus [Inactive] ši daina turėtų būti slepiama ir nebeišgaunama likusioje programoje išskyrus atąskaitas ir darbuotojams prieinamą informaciją. 

[PAPILDOMAI]
EKRANAS [DARBUOTOJU PARINKTYS EKRANAS->Statistika (Darbuotojams)]:
Pasirinkus "Statistika (Darbuotojams)" ekrane turėtume turėti išmesti bent 5 parinktis:
	1. Išgauti visas kliento atąskaitas pagal kliento ID
	2. Išgauti veiklos pelna (Neatskaičius mokesčių pilna suma)
	3. Išgauti veiklos pelną pagal paduotus metus
	4. Išgauti kiek kokio žanro kūrinių buvo nupirkta (Rikiuota pagal dydį)
		a. Rock | 1178
		b. Indie | 588
		c. Ir t.t
	5. Išgauti kiek kiekvienas klienas išleido pinigų
	6. (BONUS) Išgauti kiek pelno atnešė kiekvienas indivualus Artist
		a. AC/DC | 8999
		b. Aerosmith | 7775
		c. Ir t.t

-----------------------

APRIBOJIMAI:
- TAIKYTI "Repository Pattern". t.y. VISA KOMUNIKACIJA SU DUOMENIMIS TURI BŪTI ATSKIRTA DUOMENIMS PRIKLAUSANČIU REPOSTIORY FAILU/KLASE
- PADENGTI UNIT-TESTAIS VISĄ FUNCKIONALUMĄ, KURIS SAVEIKAUJA SU DUOMENŲ BAZE PASITELKIANT IN-MEMORY DB IR MOQ.
- TAIKYTI "Dependency inversion principle". t.y. VISI SERVISAI TURI BŪTI KONSTRUOJAMI Į INTERFACE
- TAIKYTI "Single-responsibility principle". t.y. KLASĖS TURI ATLIKTI TIK VIENOS ATSAKOMYBĖS UŽDUOTIS IR GALI BŪTI KEIČIAMOS TIK DĖL VIENOS PRIEŽASTIES 

 */