
using P035_DataReading.Domain.Models;
using P035_DataReading.Domain.Services;

namespace PraktinesUzduotys
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, File reading praktika!");


            //Uzd1();

            Uzd2();


            /*
            Uzduotis 3- Sukurkite isskleista property <HotelManager> AverageRating, kuris grazintu vidutini hoteliu ivertinima + unit test.
            Sukurkite <HotelManager> klasei isskleidziama property NewHotels, kuris grazintu sarasa visu hoteliu, kurie buvo pastatyti veliau nei 2010-01-01.
            Sukurkite <HotelManager> klasei metoda [AllocateUsersToLuxHotels(users)], kuris turetu naudotojus priskirti tik i hotelius, kuriu ivertinimas yra auksciau 3 ir yra NewHotels sarase.
            Sukurkite <Hotel> klasei [MenVisitors] ir [WomenVisitors] isskleidziamus property, kurie turetu grazinti besilankancius vyrus ir moteris individualiai.
            * 
            * 
            */

        }

        /*
 * 
 *        Uzduotis 1– Sukurkite programa, kuri moketu nuskaityti UserData1.csv failą. UserData1.csv galite pasiimti iš Teams pamokos Files sekcijos. 
 *        Atvaizduokite kiekvieno naudotojo duomenis tokiu formatu:”55. Petras Petraitis (Vyras) – petras@petramail.lt”.
          Headeri turetu atspausdinti pirmoje eiluteje.
    PAGALBA: Tam, kad turėtumėt patogų priėjimu visiems duomenims jums reikės susikurti naują <User> klasę.
*/
        public static void Uzd1()
        {
            FileService user1FileService = new FileService(Environment.CurrentDirectory + "\\InitialData\\UserData1.csv");

            Console.WriteLine(user1FileService.ExctractBasicUserCsvHeader());
            PrintAllBasicUsers1(user1FileService.FetchBasicUser1CsvRecords());

        }
        
        public static void PrintAllBasicUsers1(List<User1> users)
        {
            foreach (User1 user in users)
            {
                Console.WriteLine($"{user.Id}. {user.FullName()} ({user.GenderLT()})- {user.Email}");
            }
        }


        /*
          Uzduotis 2 – Sukurkite nauja <Hotel> klase, kuri savyje gali laikyti sarasa <User> (Hoteliu data importuokite is HotelData1.csv).
          Sukurkite nauja <HotelManager> klase, kuri savyje laiko sarasa hoteliu.
          Naujai sukurtai klasei <HotelManager> sukurkite metoda [AllocateUsersToHotels(users)], kuris priskirs kiekviena vartotoja atsitiktiniam (Random) hoteliui.
          Sukurkite atskleidziama <Hotel> property, AverageClientSalary, kuris grazintu besilankanciu klientu vidutine sumuota alga. Turi buti Unit Test Coverage.
        */

        public static void Uzd2()
        {
            FileService hotelFileService = new FileService(Environment.CurrentDirectory + "\\InitialData\\HotelData1.csv");

            Console.WriteLine(hotelFileService.ExctractBasicUserCsvHeader());     
            PrintAllHotels(hotelFileService.FetchHotelCsvRecords());
        }

        public static void PrintAllHotels(List<Hotel> hotels)
        {
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Id}. {hotel.Name} {hotel.StreetName} {hotel.CreationDate}");
            }
        }


    }




}